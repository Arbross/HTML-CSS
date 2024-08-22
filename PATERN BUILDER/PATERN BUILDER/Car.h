#pragma once
#include <iostream>
using namespace std;

struct Car
{
	Car() = default;

	bool gps = false;
	size_t amount = 0;
	float engineVolume = 0.0;

	void print() const
	{
		cout << "Car engine : " << engineVolume << endl;
		cout << "GPS : " << boolalpha << gps << endl;
		cout << "Amount : " << amount << endl << endl;
	}
};

