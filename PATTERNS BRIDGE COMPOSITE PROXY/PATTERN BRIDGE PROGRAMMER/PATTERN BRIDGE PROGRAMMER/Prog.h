#pragma once
#include <iostream>
using namespace std;
__interface ILanguage
{
	int getPayment() const;
	void add();
};

class CSharp : public ILanguage
{
public:
	int getPayment() const override
	{
		return payment;
	}

	void add()
	{
		this->payment += 250;
	}
private:
	int payment;
};

class CPlusPlus : public ILanguage
{
public:
	int getPayment() const override
	{
		return payment;
	}

	void add()
	{
		this->payment += 600;
	}
private:
	int payment;
};

class Java : public ILanguage
{
public:
	int getPayment() const override
	{
		return payment;
	}

	void add()
	{
		this->payment += 550;
	}
private:
	int payment;
};