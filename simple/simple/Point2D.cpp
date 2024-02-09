#include"Point2D.h"

Point2D::Point2D() {
	x = 0;
	y = 0;
}

Point2D::Point2D(double x, double y) {
	this->x = x;
	this->y = y;
}

std::string Point2D::ToString() {
	return "(" + std::to_string(x) + "," + std::to_string(y) + ")";
}