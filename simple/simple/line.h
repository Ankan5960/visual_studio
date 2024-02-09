#pragma once
#include"Point2D.h"
#include"my_string.h"
#include"Utils.h"

class Line {
public:
	Point2D* point;
	Line();
	Line(Point2D* point);
	Line(double, double);

	std::string ToString();
};

Line* LinestringToInt(std::string);
std::string saveLine(std::vector<Line*>*);
std::vector<Line*>* LineCmd(std::vector<Line*>*);