#include <iostream>
#include "IFleet.h"
using namespace std;

int main()
{
	IShip* shipA = new Ship("Ship A(t)", 50);
	IShip* shipB = new Ship("Ship B(t)", 60);

	Fleet* fleet = new Fleet(1, shipA);
	fleet->print();
	fleet->add(shipB);
	fleet->remove(shipA);
	fleet->print();

	cout << endl;
	cout << endl;
	cout << endl;

	Fleet* fleetGovermant = new Fleet(2, fleet);
	IShip* shipPresident = new Ship("President ship", 60);
	fleetGovermant->add(shipPresident);
	fleet->print();
}