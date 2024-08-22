#include <iostream>
using namespace std;
using ullong = unsigned long long;

class Budget
{
public:
	Budget(const Budget& other) = delete;

	static Budget* getInstance(const ullong& money = 10000000000)
	{
		if (instance == nullptr)
		{
			instance = new Budget();
		}

		return instance;
	}

	void addMoney(const ullong& money)
	{
		this->money += money;
	}

	void spendMoney(const ullong& money)
	{
		if (money <= this->money)
		{
			this->money -= money;
		}
	}

	const ullong& getMoney() const
	{
		return money;
	}
private:
	Budget(const ullong& money = 10000000000)
		: money(money) {}

	static Budget* instance;
	ullong money;
};

Budget* Budget::instance = nullptr; // 0

int main()
{
	Budget* a = Budget::getInstance(5'000'000'000'000);
	a->addMoney(3500000000);
	a->spendMoney(3453453453);
	cout << a->getMoney() << endl;

	Budget* c = Budget::getInstance(5'000'000'000'000);
	c->spendMoney(20000000000000);
	cout << c->getMoney() << endl;

	// Budget d = *a;


	delete a; // ???????
}
