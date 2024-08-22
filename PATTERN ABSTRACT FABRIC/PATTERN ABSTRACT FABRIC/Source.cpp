#include <iostream>
#include <vector>
#include "AbstractFactory.h"
using namespace std;

class Application
{
public:
	Application(IGUIFactory* factory)
		: factory(factory) {}

	void addButton(const string& title)
	{
		buttons.push_back(factory->createButton(title));
	}
	
	void addCheckBox(const string& title)
	{
		checkBoxes.push_back(factory->createCheckBox(title));
	}

	void print()
	{
		for (const auto& btn : buttons)
		{
			btn->paint();
		}

		cout << endl;

		for (const auto& ch : checkBoxes)
		{
			ch->paint();
		}
	}

	~Application()
	{
		for (auto& i : buttons)
		{
			delete i;
		}

		for (auto& i : checkBoxes)
		{
			delete i;
		}

		buttons.clear();
		checkBoxes.clear();
	}

private:
	vector<Button*> buttons;
	vector<CheckBox*> checkBoxes;
	IGUIFactory* factory;
};

int main()
{
	/*Button* b = new MacButton("Go");
	b->paint();
	b->onClick();

	CheckBox* ch = new WinCheckBox("English");
	ch->paint();
	ch->onClick();*/

	/*IGUIFactory* factory = new WinFactory();
	Button* btn = factory->createButton("Start");
	btn->paint();
	btn->onClick();

	CheckBox* chb = factory->createCheckBox("French");
	chb->paint();
	chb->onClick();*/

	MacFactory macFactory;
	Application app(&macFactory);
	app.addButton("First");
	app.addCheckBox("Second");
	app.addCheckBox("Third");
	app.print();

	return 0;
}