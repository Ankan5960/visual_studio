#include"Utils.h"
#include"Point2D.h"
#include"line.h"
#include"Circle.h"
#include"my_string.h"

void save(std::string& contentToWrite, std::string& name) {
	std::string temp;
	std::string folderPath = "C:/Users/ankan/OneDrive/Desktop/textfile";
	std::string fileName = name + ".txt";

	std::string filePath = folderPath + "/" + fileName;

	std::ofstream outputFile(filePath);

	if (outputFile.is_open()) {
		std::cout << "Save drawing as < " << filePath << "> :";
		std::cin >> temp;
		if (stringCheck(temp, "yes")) {
			outputFile << contentToWrite;
			outputFile.close();
		}
		else {
			std::cout << "wrong command" << std::endl;
		}
	}
	else {
		std::cerr << "Error opening file for writing." << std::endl;
	}
}

int main()
{
	int flag = 0;
	std::string str;
	std::string contentToWrite = "";
	bool isrunning = true;
	std::string temp;
	
	std::vector<Point2D>* line = new std::vector<Point2D>();
	std::vector<Circle>* circle = new std::vector<Circle>();
	while (isrunning) {
		std::cout << "command: ";
		std::cin >> str;
		std::cout << std::endl;

		switch (hashit(str)) {
		case 1:	
			flag=1;
			line=LineCmd(line);
			contentToWrite += saveLine(line);
			line->clear();
			break;

		case 2:	
			flag = 2;
			circle=CircleCmd(circle);
			contentToWrite += saveCircle(circle);
			circle->clear();
			break;

		case 3:
			isrunning = false;
			break;

		case 4:
			if (stringCheck(str, "save")) {
				std::cout << "Enter File name: ";
				std::cin >> temp;
				save(contentToWrite, temp);
				break;
			}
			break;

		default:
			std::cout << "Worng choice.";
			break;

		}
	}

	delete line;
	delete circle;
}
