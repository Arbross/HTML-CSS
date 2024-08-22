#pragma once
#include <iostream>
#include "Transport.h"
using namespace std;

class Factory abstract
{
public:
	virtual ITransport* createTransport() = 0;
};

class SeaFactory : public Factory
{
public:
	virtual ITransport* createTransport() override
	{
		return new Ship();
	}
};

class RoadFactory : public Factory
{
public:
	virtual ITransport* createTransport() override
	{
		return new Truck();
	}
};
