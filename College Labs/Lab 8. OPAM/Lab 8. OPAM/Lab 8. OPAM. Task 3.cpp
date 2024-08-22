#include<iostream>
#include<math.h>

using namespace std;

int main()
{
	// Enter array
	int array[5][5];

	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			cout << "Please enter array value " << i << ", " << j << " : "; cin >> array[i][j];
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

	// Count Task 1
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			if (array[i][j] < 0)
			{
				cout << "Please enter array value " << i << ", " << j << " : "; cin >> array[i][j];
			}
		}
	}

	// Count Task 1
	for (int i = 0; i < 5; i++)
	{
		int sum = 0;
		for (int j = 0; j < 5; j++)
		{
			sum += array[i][j];
		}

		cout << "Array sum : " << sum << endl;
	}

	return 0;
}