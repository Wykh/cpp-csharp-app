#include "Triangle.h"
#include <iostream>

extern "C" __declspec(dllexport) Triangle * CreateTriangleBySides(double a, double b, double c) {
	return new Triangle(a, b, c);
}

extern "C" __declspec(dllexport) Triangle * CreateTriangleByPoints(Point * p1, Point * p2, Point * p3) {
	return new Triangle(p1, p2, p3);
}

extern "C" __declspec(dllexport) Triangle * CreateTriangleEmpty() {
	return new Triangle();
}

extern "C" __declspec(dllexport) void DeleteTriangle(Triangle * trianglePointer) {
	delete trianglePointer;
}

extern "C" __declspec(dllexport) double getATriangleSide(Triangle * trianglePointer) {
	return trianglePointer->getASide();
}

extern "C" __declspec(dllexport) double getBTriangleSide(Triangle * trianglePointer) {
	return trianglePointer->getBSide();
}

extern "C" __declspec(dllexport) double getCTriangleSide(Triangle * trianglePointer) {
	return trianglePointer->getCSide();
}

extern "C" __declspec(dllexport) void setATriangleSide(Triangle * trianglePointer, double a) {
	trianglePointer->setASide(a);
}

extern "C" __declspec(dllexport) void setBTriangleSide(Triangle * trianglePointer, double b) {
	trianglePointer->setBSide(b);
}

extern "C" __declspec(dllexport) void setCTriangleSide(Triangle * trianglePointer, double c) {
	trianglePointer->setCSide(c);
}

extern "C" __declspec(dllexport) void setATriangleSideViaPoints(Triangle * trianglePointer, Point * p1, Point * p2) {
	trianglePointer->setASide(p1, p2);
}

extern "C" __declspec(dllexport) void setBTriangleSideViaPoints(Triangle * trianglePointer, Point * p1, Point * p2) {
	trianglePointer->setBSide(p1, p2);
}

extern "C" __declspec(dllexport) void setCTriangleSideViaPoints(Triangle * trianglePointer, Point * p1, Point * p2) {
	trianglePointer->setCSide(p1, p2);
}

extern "C" __declspec(dllexport) double getTriangleArea(Triangle * trianglePointer) {
	return trianglePointer->getArea();
}

