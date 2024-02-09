#include"Circle.h"
#include"my_string.h"

Circle::Circle() {
	center.x = 0;
	center.y = 0;
	rad = 0;
}

Circle::Circle(double x, double y, double rad) {
	center.x = x;
	center.y = y;
	this->rad = rad;
}

std::string Circle::ToString() {
	return "center point: (" + std::to_string(center.x) + "," + std::to_string(center.y) + ") Diameter: "+std::to_string(rad);
}

std::string saveCircle(std::vector<Circle>* data) {
	std::string contentToWrite = "Circle: ";
	
	int i = 0;
	while (i != data->size()) {
		contentToWrite = contentToWrite + data->at(i).ToString();
		i++;
	}
	contentToWrite += "\n";

	return contentToWrite;
	
}

std::vector<Circle>* CircleCmd(std::vector<Circle>* head) {
	bool temprunning = true;
	int flag = 0;
	std::string temp;
	
		Circle cir;
		
		std::cout << "Specify center point for circle or [3P/2P/Ttr (tan tan radius)]: ";
		flag++;
		std::cin >> temp;
		std::cout << std::endl;
		cir.center = stringToInt(temp);
		std::cout <<"Specify radius of circle or [Diameter]: ";
		std::cin >> temp;
		std::cout << std::endl;
		const char* str = temp.c_str();
		double value1 = 0;
		while (*str && *str != ',') {
			value1 = value1 * 10 + (*str - '0');
			++str;
		}
		cir.rad=value1;
		head->push_back(cir);
		temprunning = false;

		return head;
}