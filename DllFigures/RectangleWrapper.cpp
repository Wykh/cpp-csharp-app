#include "Rectangle.h"

extern "C" __declspec(dllexport) Rectangle * CreateRectangleBySides(int a, int b) {
	return new Rectangle(a, b);
}

extern "C" __declspec(dllexport) Rectangle * CreateRectangleEmpty() {
	return new Rectangle();
}

extern "C" __declspec(dllexport) void DeleteRectangle(Rectangle* rectanglePointer) {
	delete rectanglePointer;
}

extern "C" __declspec(dllexport) int getARectangleSide(Rectangle * rectanglePointer) {
	return rectanglePointer->getASide();
}

extern "C" __declspec(dllexport) int getBRectangleSide(Rectangle * rectanglePointer) {
	return rectanglePointer->getBSide();
}

extern "C" __declspec(dllexport) void setARectangleSide(Rectangle * rectanglePointer, int a) {
	rectanglePointer->setASide(a);
}

extern "C" __declspec(dllexport) void setBRectangleSide(Rectangle * rectanglePointer, int b) {
	rectanglePointer->setBSide(b);
}

extern "C" __declspec(dllexport) int getRectangleArea(Rectangle * rectanglePointer) {
	return rectanglePointer->getArea();
}