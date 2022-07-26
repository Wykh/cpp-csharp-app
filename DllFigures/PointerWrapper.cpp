#include "Point.h"

extern "C" __declspec(dllexport) Point * CreatePointByChords(int a, int b) {
	return new Point(a, b);
}

extern "C" __declspec(dllexport) Point * CreatePointEmpty() {
	return new Point();
}

extern "C" __declspec(dllexport) void DeletePoint(Point * pointPointer) {
	delete pointPointer;
}

extern "C" __declspec(dllexport) int getX(Point * pointPointer) {
	return pointPointer->getX();
}

extern "C" __declspec(dllexport) int getY(Point * pointPointer) {
	return pointPointer->getY();
}

extern "C" __declspec(dllexport) void setX(Point * pointPointer, int x) {
	return pointPointer->setX(x);
}

extern "C" __declspec(dllexport) void setY(Point * pointPointer, int y) {
	return pointPointer->setY(y);
}

extern "C" __declspec(dllexport) int getDistance(Point * pointPointer, Point * target) {
	return pointPointer->getDistance(target);
}




