#pragma once
#include <iostream>
__interface ITransport
{
	void deliver(size_t distance);
};

class Ship : public ITransport
{
public:
	Ship() = default;

	void deliver(size_t distance)
	{
		std::cout << "Deliver by ship on distance " << distance << "." << std::endl;
	}
};

class Truck : public ITransport
{
public:
	Truck() = default;

	void deliver(size_t distance)
	{
		std::cout << "Deliver by truck on distance " << distance << "." << std::endl;
	}
};
