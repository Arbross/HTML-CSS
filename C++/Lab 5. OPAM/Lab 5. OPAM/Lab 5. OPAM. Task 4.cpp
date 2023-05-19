#include<iostream>
#include<math.h>

using namespace std;

int main()
{
	// Task 1

	int s = 0;
	for (size_t i = 2; i < 12; i++)
	{
		s += pow(-1, i) * ((pow(i, 4) - 2) / (pow(i, 2) + 3));
	}

	cout << "Your 's' parameter : " << s << endl;

	// Task 2
	int y = 0;
	for (size_t i = 2; i < 6; i++)
	{
		y *= (5 * pow(i, 2) - 2 * i + 1) / (3 * i + 5);
	}

	return 0;
}
