#include"point.h"

void point2D::Display() {
	std::cout << x << " " << y;
}

double point2D::Distance(point2D temp) {
	double x2 = temp.x;
	double y2 = temp.y;

	double x1 = this->x;
	double y1 = this->y;

	return (sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))));
}