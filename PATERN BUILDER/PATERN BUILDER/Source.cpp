#include <iostream>
#include "Builder.h"
using namespace std;

int main()
{
	/*Car car;
	car.engineVolume = 12;
	car.amount = 5;
	car.gps = true;
	car.print();*/

	/*CarBuilder carBuilder;
	carBuilder.reset();

	carBuilder.setGPS(true);
	carBuilder.setSeats(4);
	
	Car* car = carBuilder.getResult();
	car->print();*/

	try
	{
		CarBuilder carBuilder;
		Director director(&carBuilder);
		director.make(CarType::ORDINARY);

		Car* car = carBuilder.getResult();
		car->print();

		director.make(CarType::SPORT);

		Car* car2 = carBuilder.getResult();
		car2->print();

		delete car;
		delete car2;
	}
	catch (const exception& msg)
	{
		cout << "Exception : " << msg.what() << endl;
	}
	
}
