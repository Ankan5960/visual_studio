#include"Circle.h"
#include"my_string.h"
double previous_rad = 0;

Circle::Circle() {
	center = nullptr;
	rad = 0;
}

Circle::Circle(double x, double y, double rad) {
	center->x = x;
	center->y = y;
	this->rad = rad;
}

std::string Circle::ToString() {
	return "center point: (" + std::to_string(center->x) + "," + std::to_string(center->y) + ") Diameter: "+std::to_string(rad*2);
}

std::string saveCircle(std::vector<Circle*>* data) {
	std::string contentToWrite = "Circle: ";
	int i = 0;
	while (i != data->size()) {
		contentToWrite = contentToWrite + data->at(i)->ToString();
		i++;
	}
	contentToWrite += "\n";
	return contentToWrite;
}

std::vector<Circle*>* CircleCmd(std::vector<Circle*>* head,int flag) {
	bool temprunning = true;
	std::string temp;
	
	double value1 = 0;
		
		if (flag == 0) {
			Circle* cir = new Circle();
			std::cout << "Specify center point for circle or [3P/2P/Ttr (tan tan radius)]: ";
			std::cin >> temp;
			std::cout << std::endl;
			cir->center = stringToInt(temp);
			std::cout << "Specify radius of circle or [Diameter]: ";
			std::cin >> temp;
			std::cout << std::endl;

			const char* str = temp.c_str();
			while (*str && *str != ',') {
				value1 = value1 * 10 + (*str - '0');
				++str;
			}
			cir->rad = value1;
			previous_rad = value1;
			head->push_back(cir);
			return head;
			delete cir;
		}

		else if (flag >= 1) {
			Circle* cir = new Circle();
			std::cout << "Specify center point for circle or [3P/2P/Ttr (tan tan radius)]: ";
			std::cin >> temp;
			std::cout << std::endl;
			cir->center = stringToInt(temp);
			std::cout << "Specify radius of circle or [Diameter]: <"+ std::to_string(previous_rad)+"> ";
			//std::cout << "Specify radius of circle or [Diameter]: ";
			std::cin >> temp;
			std::cout << std::endl;

			const char* str = temp.c_str();
			while (*str && *str != ',') {
				value1 = value1 * 10 + (*str - '0');
				++str;
			}
			cir->rad = value1;
			previous_rad = value1;
			head->push_back(cir);
			return head;
			delete cir;
		}
	
	return head;
}