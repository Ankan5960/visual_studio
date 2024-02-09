#pragma once
#include"Utils.h"
#include"Point2D.h"

class Circle {
public:
	Point2D* center;
	double rad;

	Circle();
	Circle(double x, double y, double rad);
	std::string ToString();
};


Circle* CircleStrinToInt(std::string);
std::string saveCircle(std::vector<Circle*>*);
std::vector<Circle*>* CircleCmd(std::vector<Circle*>*,int);