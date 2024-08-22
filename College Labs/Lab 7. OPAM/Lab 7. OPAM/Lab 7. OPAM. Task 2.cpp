#include<iostream>
#include<math.h>

using namespace std;

double countSumNegativeElemsToMaxValue(double array[], int size)
{
	double maxValue = 0;
	for (size_t i = 0; i <= size; i++)
	{
		double elem = array[i];

		if (elem < maxValue)
		{
			maxValue = elem;
		}
	}

	double sumNegativeElems = 0;
	for (size_t i = 0; i <= size; i++)
	{
		double elem = array[i];

		if (elem == maxValue)
		{
			break;
		}

		if (elem < 0)
		{
			sumNegativeElems += elem;
		}
	}

	return sumNegativeElems;
}

int main()
{
	const int n = 5;
	double array[n];

	for (size_t i = 0; i < n; i++)
	{
		double value = 0;
		cout << "Please enter array value : "; cin >> value;

		array[i] = value;
	}

	cout << "Sum of negative elems : " << countSumNegativeElemsToMaxValue(array, n) << endl;

	return 0;
}
