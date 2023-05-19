#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	srand((unsigned)time(NULL));

	// Fill random numbers

	int array[5][5];
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			array[i][j] = rand() % 10;
		}
	}

	// Show Array

	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			cout << array[i][j] << ", ";
		}

		cout << endl;
	}

	// Count

	cout << endl;

	for (int i = 0; i < 5; i++)
	{
		int sum = 0, count = 0;

		for (int j = 0; j < 5; j++)
		{
			if (array[j][i] % 2 != 0)
			{
				count++;
			}

			sum += array[j][i];
		}

		cout << "Count : " << count << ", Sum : " << sum << endl;
	}

	return 0;
}
