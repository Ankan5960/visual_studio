#include"line.h"


std::string saveLine(std::vector<Point2D>* data) {

	std::string contentToWrite = "Line:";
	int i = 0;
	while (i != data->size()) {
		contentToWrite = contentToWrite + data->at(i).ToString();
		i++;
	}
	contentToWrite += "\n";

	return contentToWrite;

}

std::vector<Point2D>* LineCmd(std::vector<Point2D>* head) {

	bool temprunning = true;
	int flag = 0;

	std::string temp;
	while (temprunning) {
		if (flag == 0) {
			std::cout << "Specify first point: ";
			flag++;
			std::cin >> temp;
			std::cout << std::endl;
			head->push_back(stringToInt(temp));
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
				head->push_back(stringToInt(temp));
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
				head->push_back(stringToInt(temp));
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
				head->push_back(stringToInt(temp));
				flag++;
			}
		}
	}
	return head;
	//delete head;
}