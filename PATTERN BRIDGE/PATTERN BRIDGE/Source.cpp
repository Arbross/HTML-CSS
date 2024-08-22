#include <iostream>
#include "Shape.h"
using namespace std;

int main()
{
	IColor* redColor = new Red();
	IColor* yellowColor = new Red();

	Shape* redCircle = new Circle(50, redColor);
	redCircle->draw();

	cout << "Hello world!" << endl;
}
