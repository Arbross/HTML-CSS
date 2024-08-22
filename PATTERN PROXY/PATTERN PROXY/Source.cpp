#include <iostream>
using namespace std;

__interface IAccount
{
	void withDraw(int money);
	void showBalance();
};

class Account : public IAccount
{
	int money;
public:
	void withDraw(int money)
	{
		cout << money << endl;
		this->money -= money;
	}
	void showBalance()
	{
		cout << "Money balance : " << money << endl;
	}
};

class CreditCard : public IAccount
{
	int pin = 12345;
	IAccount* account;
public:
	CreditCard(IAccount* account)
		: account(account) {}

	bool checkAccess(int pin)
	{
		return this->pin == pin;
	}

	void withDraw(int money)
	{
		int pin;
		cout << "Enter pin : ";
		cin >> pin;

		if (checkAccess(pin))
		{
			account->withDraw(money);
		}
	}

	void showBalance()
	{
		int pin;
		cout << "Enter pin : ";
		cin >> pin;

		if (checkAccess(pin))
		{
			account->showBalance();
		}
	}
};

int main()
{
	Account account;
	CreditCard card(&account);
	card.withDraw(3000);
}
