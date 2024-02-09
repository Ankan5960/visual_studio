#include"line.h"

Line::Line(){
	this->point = nullptr;
}

Line::Line(Point2D* point) {
	this->point = point;
}

Line::Line(double x, double y) {
	point->x = x;
	point->y = y;
}

std::string Line::ToString() {
	return "(" + std::to_string(point->x) + "," + std::to_string(point->y) + ")";
}
Line* LinestringToInt(std::string temp) {
	Line* line = new Line(stringToInt(temp));
	return line;
	delete line;
}
std::string saveLine(std::vector<Line*>* data) 
{
	std::string contentToWrite = "Line:";
	int i = 0;
	while (i != data->size()) {
		contentToWrite = contentToWrite + data->at(i)->point->ToString();
		i++;
	}
	contentToWrite += "\n";
	return contentToWrite;
}

std::vector<Line*>* LineCmd(std::vector<Line*>* head) 
{
	Line* line = new Line();
	bool temprunning = true;
	int flag = 0;
	std::string temp;
	while (temprunning) {
		if (flag == 0) {
			std::cout << "Specify first point: ";
			flag++;
			std::cin >> temp;
			std::cout << std::endl;
			head->push_back(LinestringToInt(temp));
		}
		else if (flag == 1) {
			std::cout << "Specify next point or [Undo]: ";
			std::cin >> temp;
			std::cout << std::endl;

			if (stringCheck(temp, "Undo")) {
				std::cout << "All segments already undone." << std::endl;
				std::cout << std::endl;
				head->pop_back();
				flag--;
			}
			else {
				head->push_back(LinestringToInt(temp));
				flag++;
			}
		}
		else if (flag == 2) {
			std::cout << "Specify next point or [Undo]: ";
			std::cin >> temp;
			std::cout << std::endl;
			if (stringCheck(temp, "Undo")) {
				head->pop_back();
				flag--;
			}
			else {
				head->push_back(LinestringToInt(temp));
				flag++;
			}
		}
		else if (flag >= 3) {
			std::cout << "Specify next point or [Close/Undo]: ";
			std::cin >> temp;
			std::cout << std::endl;

			if (stringCheck(temp, "Undo")) {
				head->pop_back();
				flag--;
			}
			else if (stringCheck(temp, "Close")) {
				temprunning = false;
				flag = 0;
			}
			else {
				head->push_back(LinestringToInt(temp));
				flag++;
			}
		}
	}
	return head;
}