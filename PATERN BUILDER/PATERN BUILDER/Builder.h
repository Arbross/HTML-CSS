#pragma once
#include "Car.h"

__interface IBuilder
{
	void reset();
	void setEngine(float volume);
	void setSeats(size_t amount);
	void setGPS(bool exist);
};

class CarBuilder : public IBuilder
{
public:
	void reset()
	{
		car = new Car();
	}

	void setEngine(float volume)
	{
		car->engineVolume = volume;
	}

	void setSeats(size_t amount)
	{
		car->amount = amount;
	}

	void setGPS(bool exist)
	{
		car->gps = exist;
	}

	Car* getResult()
	{
		return car;
	}
private:
	Car* car;
};

enum class CarType { SPORT, ORDINARY };
class Director
{
public:
	Director(IBuilder* builder)
		: builder(builder) {}

	void make(CarType type)
	{
		builder->reset();
		
		if (type == CarType::SPORT)
		{
			builder->setEngine(3.5f);
			builder->setSeats(2);
		}
		else if (type == CarType::ORDINARY)
		{
			builder->setEngine(2.0f);
			builder->setSeats(4);
			builder->setGPS(true);
		}
		else {
			throw exception("Bad type of a car.");
		}
	}
private:
	IBuilder* builder;
};

