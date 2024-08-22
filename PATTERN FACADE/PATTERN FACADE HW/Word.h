#pragma once
#include <iostream>
using namespace std;

class Word
{
public:
	void setEU(const string& EU)
	{
		this->EU = EU;
	}

	void setUA(const string& UA)
	{
		this->UA = UA;
	}

	string getEU() const
	{
		return EU;
	}

	string getUA() const
	{
		return UA;
	}
private:
	string EU;
	string UA;
};

