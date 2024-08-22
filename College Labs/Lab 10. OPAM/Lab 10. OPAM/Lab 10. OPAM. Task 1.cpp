#include <iostream>
#include <math.h>

using namespace std;

// Counting triangle side
double getTriangleSide(int x1, int x2, int y1, int y2)
{
	return sqrt(pow((x2 - x1), 2) + pow((y2 - y1), 2));
}

// Counting median
double countMedian(double a, double b, double c)
{
	return sqrt((2 * pow(a, 2)) + (2 * pow(b, 2)) - (2 * pow(c, 2))) / 2;
}

// Counting in-radius
double countInRadius(double a, double b, double c)
{
	double p = (a + b + c) / 2;
	return sqrt(((p - a) * (p - b) * (p - c)) / p);
}

int main()
{
	try
	{
		while (true)
		{
			// 'i' parameter for counting triangle points
			int i = 0;
			cout << "Please enter 'i' parameter : "; cin >> i;

			// Triangle parameters
			int ax = 0, ay = 0;
			int bx = i, by = i + 1;
			int cx = -i, cy = i + 1;

			// Count and view median
			double median = countMedian(getTriangleSide(bx, cx, by, cy), getTriangleSide(ax, cx, ay, cy), getTriangleSide(ax, bx, ay, by));
			cout << "Your counted median : " << median << "cm" << endl;

			// Count and view in-radius
			double inRadius = countInRadius(getTriangleSide(bx, cx, by, cy), getTriangleSide(ax, cx, ay, cy), getTriangleSide(ax, bx, ay, by));
			cout << "Your counted in radius : " << inRadius << "cm" << endl;
		}
	}
	catch (const exception& ex)
	{
		cout << ex.what() << endl;
	}
}
