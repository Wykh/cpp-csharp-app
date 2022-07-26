#pragma once
class Point
{
private:
	int x;
	int y;
public:
	Point();
	Point(int x, int y);

	void setX(int x);
	void setY(int y);
	int getX();
	int getY();

	double getDistance(Point * p);
};

