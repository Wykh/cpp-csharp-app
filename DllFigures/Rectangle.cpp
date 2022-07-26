#include "Rectangle.h"

void Rectangle::setASide(int newA)
{
	a = newA;
}

void Rectangle::setBSide(int newB)
{
	b = newB;
}

int Rectangle::getASide()
{
	return a;
}

int Rectangle::getBSide()
{
	return b;
}

Rectangle::Rectangle()
{
	a = 0;
	b = 0;
}

Rectangle::Rectangle(int a, int b)
{
	this->a = a;
	this->b = b;
}

int Rectangle::getArea()
{
	return a * b;
}
