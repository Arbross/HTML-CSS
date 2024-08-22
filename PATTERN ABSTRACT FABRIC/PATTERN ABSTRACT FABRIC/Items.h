#pragma once
#include <iostream>
#include <string>
using namespace std;

class Item abstract
{
public:
	Item(const string& title = "")
		: title(title) {}

	virtual void paint() = 0;
	virtual void onClick() = 0;
	void setTitle(const string& text) 
	{
		this->title = text; 
	}

	const string& getTitle() const { return title; }
private:
	string title;
};

class Button : public Item
{
public:
	Button(const string& title = "Button")
		: Item(title) {}
};

class MacButton : public Button
{
public:
	MacButton(const string& title = "Mac Button")
		: Button(title) {}

	virtual void paint() { cout << "Paint mac button." << getTitle() << endl; }
	virtual void onClick() { cout << "Clicked mac button." << getTitle() << endl; }
};

class WinButton : public Button
{
public:
	WinButton(const string& title = "Win Button")
		: Button(title) {}

	virtual void paint() { cout << "Paint win button." << getTitle() << endl; }
	virtual void onClick() { cout << "Clicked win button." << getTitle() << endl; }
};

class CheckBox : public Item
{
public:
	CheckBox(const string& title = "CheckBox", const bool& checked = false)
		: Item(title), checked(checked) {}

	void onClick() override
	{
		checked = (!checked);
	}

	bool getCheck() const { return checked; }
private:
	bool checked;
};

class MacCheckBox : public CheckBox
{
public:
	MacCheckBox(const string& title = "Mac CheckBox")
		: CheckBox(title) {}

	void paint() override
	{
		CheckBox::onClick();
		cout << "Mac Check box " << getTitle() << " paints\n";
	}

	void onClick() override
	{
		CheckBox::onClick();
		cout << "Mac checkbox " << getTitle() << " change its check " << getCheck() << endl;
	}
};

class WinCheckBox : public CheckBox
{
public:
	WinCheckBox(const string& title = "Win CheckBox")
		: CheckBox(title) {}

	void paint() override
	{
		CheckBox::onClick();
		cout << "Win Check box " << getTitle() << " paints\n";
	}

	void onClick() override
	{
		CheckBox::onClick();
		cout << "Win checkbox " << getTitle() << " change its check " << getCheck() << endl;
	}
};
