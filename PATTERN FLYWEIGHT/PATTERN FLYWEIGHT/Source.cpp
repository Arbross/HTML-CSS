#include <iostream>
#include "Class.h"
using namespace std;

int main()
{
	/*TreeFactory factory;
	TreeType* tt = factory.getTreeType("Oak", "Green");
	tt->draw(1, 1);*/

	Forest forest;
	forest.plantTree(3, 4, "lime", "green");
	forest.plantTree(7, 5, "oak", "light green");
	forest.plantTree(1, 6, "birch", "green");
	forest.plantTree(2, 7, "lime", "green");

	forest.draw();
}