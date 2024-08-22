#pragma once
#include <iostream>
#include "Prog.h"
using namespace std;

class Programmer abstract
{
public:
	Programmer(ILanguage* language)
		: language(language) {}

	virtual int count(const size_t& monthes) = 0
	{
		for (size_t i = 0; i < monthes; i++)
		{
			language->add();
		}

		return language->getPayment();
	}

	virtual void print() const = 0
	{
		cout << "Current payment : " << language->getPayment() << endl;
	}
private:
	ILanguage* language;
};

class Freelance : public Programmer
{
public:
	Freelance(const int& interest, ILanguage* language)
		: interest(interest), Programmer(language) {}

	int getInterest() const
	{
		return interest;
	}

	virtual int count(const size_t& monthes) override
	{
		int tmp = Programmer::count(monthes);
		int new_tmp = tmp * getInterest() / 100;
		return new_tmp;
	}

	virtual void print() const override
	{
		Programmer::print();
	}
private:
	int interest;
};

class PlaceJob : public Programmer
{
public:
	PlaceJob(const int& interest, ILanguage* language)
		: interest(interest), Programmer(language) {}

	int getInterest() const
	{
		return interest;
	}

	virtual int count(const size_t& monthes) override
	{
		int tmp = Programmer::count(monthes);
		int new_tmp = tmp * getInterest() / 100;
		return new_tmp;
	}

	virtual void print() const override
	{
		Programmer::print();
	}
private:
	int interest;
};

