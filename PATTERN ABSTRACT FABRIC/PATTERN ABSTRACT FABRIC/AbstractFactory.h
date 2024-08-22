#pragma once
#include <iostream>
#include <string>
#include "Items.h"
using namespace std;

__interface IGUIFactory
{
	Button* createButton(const string& title) = 0;
	CheckBox* createCheckBox(const string& title) = 0;
};

class MacFactory : public IGUIFactory
{
public:
	Button* createButton(const string& title) override
	{
		return new MacButton(title);
	}

	CheckBox* createCheckBox(const string& title) override
	{
		return new MacCheckBox(title); 
	}
};

class WinFactory : public IGUIFactory
{
public:
	Button* createButton(const string& title) override
	{
		return new WinButton(title);
	}

	CheckBox* createCheckBox(const string& title) override
	{
		return new WinCheckBox(title);
	}
};
