#pragma once
#include <iostream>
#include "Color.h"
using namespace std;

class Shape abstract
{
public:
	Shape(IColor* color)
		: color(color) {}

	virtual void draw() const = 0
	{
		color->paintColor();
	}
private:
	IColor* color;
};

class Circle : public Shape
{
public:
	Circle(const size_t& radius, IColor* color)
		: radius(radius), Shape(color) {}

	size_t getRadius() const
	{
		return radius;
	}

	virtual void draw() const override
	{
		Shape::draw();
		cout << "Draw Circle Radius : " << getRadius() << endl;
	}
private:
	size_t radius;
};

class Square : public Shape
{
public:
	Square(const size_t& side, IColor* color)
		: side(side), Shape(color) {}

	size_t getSide() const
	{
		return side;
	}

	virtual void draw() const override
	{
		Shape::draw();
		cout << "Draw Square Radius : " << getSide() << endl;
	}
private:
	size_t side;
};
