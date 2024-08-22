#include <iostream>
#include "Transport.h"
#include "Factory.h"
using namespace std;

int main()
{
	Factory* seaFactory = new SeaFactory();
	Factory* roadFactory = new RoadFactory();

	// ITransport* t = new Truck();
	ITransport* t = roadFactory->createTransport();
	t->deliver(1000);

	ITransport* t2 = roadFactory->createTransport();
	t2->deliver(2000);
}