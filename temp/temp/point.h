#pragma once
#include<iostream>
#include<cmath>

struct point2D {
	double x;
	double y;

	void Display();
	double Distance(point2D temp);
};