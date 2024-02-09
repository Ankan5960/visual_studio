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
	/*std::vector<Point2D>* vec = new std::vector<Point2D>();*/
	/*vec->push_back(temp);*/
	return temp;

}