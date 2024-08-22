#pragma once
#include <iostream>
using namespace std;

class DrinkMachine // OLD CLASS
{
public:
	void makeTea()
	{
		cout << "Black tea\n";
	}

	void makeCoffee()
	{
		cout << "Coffee\n";
	}

	void addMilk()
	{
		cout << "Add milk\n";
	}
};

__interface ICoffeeMachine
{
	void makePureCoffee();
	void makeLatte();
};

// first way to do it

//class CoffeeMachine : public ICoffeeMachine
//{
//public:
//	void makePureCoffee() override
//	{
//		machine.makeCoffee();
//	}
//
//	void makeLatte() override
//	{
//		machine.makeCoffee();
//		machine.addMilk();
//	}
//private:
//	DrinkMachine machine;
//};

class CoffeeMachine : public ICoffeeMachine, protected DrinkMachine
{
public:
	void makePureCoffee() override
	{
		makeCoffee();
	}

	void makeLatte() override
	{
		makeCoffee();
		addMilk();
	}
};
