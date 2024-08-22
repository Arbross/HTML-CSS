#include <iostream>
#include "CoffeeMachine.h"
using namespace std;

int main()
{
	ICoffeeMachine* coffee = new CoffeeMachine();

	coffee->makeLatte();
	
}