#include <iostream>
#include "Notifier.h"
using namespace std;

int main()
{
	INotifier* notifier = new Telegram(new Facebook(new SMS));
	notifier->send("Welcome to IT-conference : 'SOLID'");

	INotifier* not2 = new Facebook(notifier);
	not2->send("Weclome to OSU");
}
