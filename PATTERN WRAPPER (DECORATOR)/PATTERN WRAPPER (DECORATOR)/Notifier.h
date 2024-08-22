#pragma once
#include <iostream>
using namespace std;

/*
		Notifier
	Decorator (Wrapper)
*/

__interface INotifier
{
	void send(const string& message);
};

// Core class
class SMS : public INotifier
{
public:
	void send(const string& message) override
	{
		cout << "SMS : " << message << endl;
	}
};

// abstract
class BaseDecorator : public INotifier
{
	INotifier* notifier;
public:
	BaseDecorator(INotifier* notifier)
		: notifier(notifier) {}

	void send(const string& message) override
	{
		notifier->send(message);
	}
};

class Facebook : public BaseDecorator
{
public:
	Facebook(INotifier* notifier)
		: BaseDecorator(notifier) {}
	void send(const string& message) override
	{
		BaseDecorator::send(message);
		cout << "Facebook : " << message << endl;
	}
};

class Telegram : public BaseDecorator
{
public:
	Telegram(INotifier* notifier)
		: BaseDecorator(notifier) {}
	void send(const string& message) override
	{
		BaseDecorator::send(message);
		cout << "Telegram : " << message << endl;
	}
};

