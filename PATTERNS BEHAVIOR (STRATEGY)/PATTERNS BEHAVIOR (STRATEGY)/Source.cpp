#include <iostream>
#include <string>
#include <map>
#include "Date.h"
using namespace std;

__interface ShoppingCart
{
	void addThingToBox(string& thing, size_t& price);
	void eraseThingFromBox(string& thing);
	size_t countAllPrice() const;
	void payForThings();
};

class RealCard : public ShoppingCart
{
public:
	RealCard(const string& name = "Noname", const int& numberID = 0, const string& cvv = "No cvv", const int& money = 0, const int& day = 1, const int& month = 1, const int& year = 1)
		: name(name), numberID(numberID), cvv(cvv), money(money) 
	{
		date.setDay(day);
		date.setMonth(month);
		date.setYear(year);
	}

	void addThingToBox(string& thing, size_t& price) override
	{
		msc.emplace(thing, price);
	}

	void eraseThingFromBox(string& thing) override
	{
		msc.erase(msc.find(thing));
	}

	size_t countAllPrice() const
	{
		size_t count = 0;

		for (auto& elem : msc)
		{
			count += elem.second;
		}

		return count;
	}

	void payForThings()
	{
		if (money > 0)
		{
			for (auto& elem : msc)
			{
				if (money >= elem.second)
				{
					msc.erase(msc.find(elem.first));
					money -= elem.second;
				}
			}
		}
	}
private:
	map<string, size_t> msc;

	string name;
	int numberID;
	string cvv;
	Date date;

	int money;
};

class PayPal : public ShoppingCart
{
	PayPal(const string& emailID = "No emailID", const string& password = "No password", const int& money = 0)
		: emailID(emailID), password(password), money(money) {}

	void addThingToBox(string& thing, size_t& price) override
	{
		msc.emplace(thing, price);
	}

	void eraseThingFromBox(string& thing) override
	{
		msc.erase(msc.find(thing));
	}

	size_t countAllPrice() const
	{
		size_t count = 0;

		for (auto& elem : msc)
		{
			count += elem.second;
		}

		return count;
	}

	void payForThings()
	{
		if (money > 0)
		{
			for (auto& elem : msc)
			{
				if (money >= elem.second)
				{
					msc.erase(msc.find(elem.first));
					money -= elem.second;
				}
			}
		}
	}
private:
	map<string, size_t> msc;

	string emailID;
	string password;

	int money;
};

class Basic
{
public:
	Basic(ShoppingCart* strategy = nullptr) 
		: sc(strategy) {}

	void setShoppingCart(const ShoppingCart* sc = nullptr)
	{
		delete[] sc;
		this->sc = const_cast<ShoppingCart*>(sc);
	}

	~Basic()
	{
		delete[] sc;
	}
private:
	ShoppingCart* sc;
};

int main()
{
	ShoppingCart* rc = new RealCard();

	Basic* basic = new Basic();
	basic->setShoppingCart(rc);

	return 0;
}
