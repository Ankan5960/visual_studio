#pragma once
#include<string>

class Point2D {
	
public:
	double x;
	double y;
	Point2D();
	Point2D(double, double);
	
	std::string ToString();
};