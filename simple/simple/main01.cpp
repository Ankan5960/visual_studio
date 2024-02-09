#include"Utils.h"
#include"Point2D.h"
#include"line.h"
#include"Circle.h"
#include"my_string.h"

void save(std::string& contentToWrite, std::string& name) 
{
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
	int flag = 0,circleCount=0;
	std::string str;
	std::string contentToWrite = "";
	double previous_rad = 0;
	bool isrunning = true;
	std::string temp;
	
	Point2D* point = new Point2D();
	std::vector<Line*>* line = new std::vector<Line*>();
	std::vector<Circle*>* circle = new std::vector<Circle*>();
	while (isrunning) {
		std::cout << "command: ";
		std::cin >> str;
		std::cout << std::endl;

		switch (hashit(str)) {
		case 1:	
			line=LineCmd(line);
			contentToWrite += saveLine(line);
			line->clear();
			break;

		case 2:	
			circle=CircleCmd(circle, circleCount);
			circleCount++;
			contentToWrite += saveCircle(circle);
			circle->clear();
			break;

		case 3:
			isrunning = false;
			break;

		case 4:
			std::cout << "Enter File name: ";
			std::cin >> temp;
			save(contentToWrite, temp);
			break;
		
		case 5:
			std::cout << contentToWrite;
			std::cout << std::endl;
			break;

		default:
			std::cout << "Worng choice.";
			std::cout << std::endl;
			break;
		}

	}

	delete line;
	delete circle;
}
