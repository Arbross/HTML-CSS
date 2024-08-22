#include <iostream>
using namespace std;
using ullong = unsigned long long;

class Budget
{
public:
	Budget(const Budget& other) = delete;

	static shared_ptr<Budget> getInstance(const ullong& money = 10000000000)
	{
		if (instance == nullptr)
		{
			instance = make_shared<Budget>(money);
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

	static shared_ptr<Budget> instance;
	ullong money;
};

shared_ptr<Budget> Budget::instance = nullptr; // 0

int main()
{
	/*Budget* a = Budget::getInstance(5'000'000'000'000);
	a->addMoney(3500000000);
	a->spendMoney(3453453453);
	cout << a->getMoney() << endl;*/

	



}
