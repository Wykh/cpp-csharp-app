#include "Triangle.h"
#include <math.h>
#include <iostream>

Triangle::Triangle()
{
	a = 0;
	b = 0;
	c = 0;
}

Triangle::Triangle(double a, double b, double c)
{
	this->a = a;
	this->b = b;
	this->c = c;
}

Triangle::Triangle(Point* p1, Point* p2, Point* p3)
{
	this->a = p1->getDistance(p2);
	this->b = p2->getDistance(p3);
	this->c = p3->getDistance(p1);
}

double Triangle::getASide()
{
	return a;
}

double Triangle::getBSide()
{
	return b;
}

double Triangle::getCSide()
{
	return c;
}

void Triangle::setASide(double a)
{
	this->a = a;
}

void Triangle::setASide(Point* p1, Point* p2)
{
	this->a = p1->getDistance(p2);
}


void Triangle::setBSide(double b)
{
	this->b = b;
}

void Triangle::setBSide(Point* p1, Point* p2)
{
	this->b = p1->getDistance(p2);
}

void Triangle::setCSide(double c)
{
	this->c = c;
}

void Triangle::setCSide(Point* p1, Point* p2)
{
	this->c = p1->getDistance(p2);
}

double Triangle::getArea()
{
	double s = (double)(a + b + c) / 2;
	return sqrt(s * (s - a) * (s - b) * (s - c));
}
