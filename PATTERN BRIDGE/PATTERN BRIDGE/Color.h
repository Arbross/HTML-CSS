#pragma once
#include <iostream>
using namespace std;
__interface IColor
{
	void paintColor() const;
};

class Red : public IColor
{
public:
	void paintColor() const override
	{
		cout << "Color red.\n" << endl;
	}
};

class Blue : public IColor
{
public:
	void paintColor() const override
	{
		cout << "Color blue.\n" << endl;
	}
};

class Yellow : public IColor
{
public:
	void paintColor() const override
	{
		cout << "Color yellow.\n" << endl;
	}
};
