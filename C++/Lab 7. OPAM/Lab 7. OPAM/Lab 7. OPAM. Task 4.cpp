#include<iostream>
#include<math.h>

using namespace std;

void showArray(double array[], int size)
{
	for (size_t i = 0; i < size; i++)
	{
		double value = array[i];

		cout << value << ", ";
	}

	cout << endl;
}

int main()
{
	double fourthArray[12] = { 12, -5, 4, -2, 2, -12, -7, 35, -7, 12, -6, 3 };

	cout << "Task - 4" << endl;
	showArray(fourthArray, 12);

	double max = 0, min = fourthArray[0];
	double maxIndex = 0, minIndex = 0;
	for (size_t i = 0; i < 12; i++)
	{
		double elem = fourthArray[i];

		if (abs(elem) > max)
		{
			max = abs(elem);
			maxIndex = i;
		}

		if (abs(elem) < min)
		{
			min = abs(elem);
			minIndex = i;
		}
	}

	double sum = 0;
	if (minIndex < maxIndex)
	{
		for (size_t i = minIndex + 1; i < maxIndex; i++)
		{
			sum += fourthArray[i];
		}
	}
	else {
		for (size_t i = maxIndex + 1; i < minIndex; i++)
		{
			sum += fourthArray[i];
		}
	}

	cout << "Sum result : " << sum << endl;

	return 0;
}