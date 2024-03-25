#include"my_string.h"

bool stringCheck(std::string str1, std::string str2) {
	int i = 0;
	if (str1.length() != str2.length()) {
		return false;
	}
	while (i != str1.length()) {
		if (std::tolower(str1[i]) == std::tolower(str2[i]) ){
			i++;
			continue;
		}
		return false;
	}
	return true;
}

int hashit(std::string str) {
	if (stringCheck(str, "Line"))
		return 1;
	else if (stringCheck(str, "Circle"))
		return 2;
	else if (stringCheck(str, "Quit"))
		return 3;
	else if (stringCheck(str, "Save"))
		return 4;
	else if (stringCheck(str, "Show"))
		return 5;
	else
		return 0;
}

Point2D* stringToInt(std::string instr)
{
	const char* str = instr.c_str();
	double value1 = 0;
	double value2 = 0;
	while (*str && *str != ',') {
		value1 = value1 * 10 + (*str - '0');
		++str;
	}

	if (*str == ',') {
		++str;
	}

	while (*str) {
		value2 = value2 * 10 + (*str - '0');
		++str;
	}
	
	Point2D* temp = new Point2D(value1, value2);
	return temp;
}

Point2D* stringToDouble(std::string instr)
{
	int i = 0, j = 0;
	std::string str1;
	std::string str2;
	while (instr[i] && instr[i] != ',') {
		str1[i] = instr[i];
		i++;
	}
	const char* s1 = str1.c_str();
	double value1 = std::atof(s1);
	if (instr[i] == ',') {
		i++;
	}

	while (instr[i]) {
		str2[i] = instr[i];
		i++;
	}
	const char* s2 = str2.c_str();
	double value2 = std::atof(s2);

	Point2D* temp = new Point2D(value1, value2);
	return temp;
}