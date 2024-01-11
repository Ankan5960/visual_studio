#include <iostream>
#include <cmath>

struct point2D {
	float x;
	float y;
};

float distanceBetweenPoint(struct point2D a, struct point2D b)
{
	float res = ((b.x - a.x) * (b.x - a.x)) + ((b.y - a.y) * (b.y - a.y));
	return(sqrt(res));
}

void main()
{
	point2D a;
	a.x = 5;
	a.y = 10;

	point2D b;
	b.x = 10;
	b.y = 20;

	float dis = distanceBetweenPoint(a, b);
	std::cout << "Distance between (" << a.x << "," << a.y << ")" << " and (" << b.x << "," << b.y << ") = " << dis << std::endl
}