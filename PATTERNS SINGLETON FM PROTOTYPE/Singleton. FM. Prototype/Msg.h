#pragma once
#include <iostream>
#include <string>
using namespace std;

class Msg
{
public:
	Msg(const string& msg = "No msg")
		: msg(msg) {}

	void print() const
	{
		cout << msg << endl;
	}

	string getMsg() const
	{
		return msg;
	}

	void setMsg(const string& msg)
	{
		this->msg = msg;
	}
private:
	string msg;
};

