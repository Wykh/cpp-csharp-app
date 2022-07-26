#pragma once
class Rectangle
{
private:
	int a;
	int b;
public:
	Rectangle();
	Rectangle(int a, int b);

	int getArea();

	void setASide(int newA);
	void setBSide(int newB);
	int getASide();
	int getBSide();
};

