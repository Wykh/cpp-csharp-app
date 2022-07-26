#pragma once
#include "Point.h"
class Triangle
{
private:
	double a;
	double b;
	double c;
public:
	Triangle();
	Triangle(double a, double b, double c);
	Triangle(Point* a, Point* b, Point* c);

	double getASide();
	double getBSide();
	double getCSide();
	void setASide(double a);
	void setASide(Point* p1, Point* p2);
	void setBSide(double b);
	void setBSide(Point* p1, Point* p2);
	void setCSide(double c);
	void setCSide(Point* p1, Point* p2);

	double getArea();
};

