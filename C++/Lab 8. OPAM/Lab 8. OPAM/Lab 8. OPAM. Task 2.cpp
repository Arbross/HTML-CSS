#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	srand((unsigned)time(NULL));

	int array[2][3];

	// Fill random numbers
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			array[i][j] = rand() % 10;
		}
	}

	// Show Array
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			cout << array[i][j] << ", ";
		}

		cout << endl;
	}

	// Count

	cout << endl;

	int max = 0;
	for (int i = 0; i < 2; i++)
	{
		int sum = 0;
		for (int j = 0; j < 3; j++)
		{
			sum += array[i][j];
		}

		if (max < sum)
		{
			max = sum;
		}
	}

	cout << "Max sum : " << max << endl;

	return 0;
}
