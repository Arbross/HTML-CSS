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

// Task 1

double countSumFourFirstNegative(double array[], int size)
{
	int n = 0;
	double sumFourFirstNegative = 0;
	for (size_t i = 0; i < size; i++)
	{
		if (n >= 4)
		{
			break;
		}

		double elem = array[i];

		if (elem < 0)
		{
			sumFourFirstNegative += elem;
			++n;
		}
	}

	return sumFourFirstNegative;
}

// Task 2

int returnIndexPlusElem(double array[], int size)
{
	int n = 0;
	for (size_t i = size; i > 0; i--)
	{
		double elem = array[i];

		if (elem > 0 && n == 1)
		{
			return elem;
		}

		if (elem > 0)
		{
			++n;
			continue;
		}
	}
}

int main()
{
	// 1. Обчислити суму перших чотирьох відємних елементів, якщо відомо, що у
	// масиві є шість від’ємних елементів.
	// 2. Вивести номер передостаннього додатного елемента.
	// 3. Утворити новий масив з відємних елементів масиву А.
	// 4. Знайти добуток другого та четвертого від’ємних елементів.
	// 5. Максимальний елемент поміняти місцями з нульовими елементами масиву.

	// Task 1
	double firstArray[12] = { 12, -5, 4, -2, 2, -12, -7, 35, -7, 12, -6, 3 };

	cout << "Task - 1" << endl;
	showArray(firstArray, 12);
	cout << "Answer : " << countSumFourFirstNegative(firstArray, 12) << endl;

	// Task 2
	double secondArray[12] = { 12, -5, 4, -2, 2, -12, -7, 35, -7, 12, -6, 3 };

	cout << "Task - 2" << endl;
	showArray(secondArray, 12);
	cout << "Answer : " << returnIndexPlusElem(secondArray, 12) << endl;

	// Task 3
	double thirdArray[12] = { 12, -5, 4, -2, 2, -12, -7, 35, -7, 12, -6, 3 };

	cout << "Task - 3" << endl;
	showArray(thirdArray, 12);

	int size = 0;
	for (size_t i = 0; i < 12; i++)
	{
		double elem = thirdArray[i];
		
		if (elem < 0)
		{
			size++;
		}
	}

	int j = 0;
	double* thirdTwoArray = new double[size];
	for (size_t i = 0; i < 12; i++)
	{
		if (thirdArray[i] < 0)
		{
			thirdTwoArray[j] = thirdArray[i];
			++j;
		}
	}

	showArray(thirdTwoArray, size);

	// Task 4

	double fourthArray[12] = { 12, -5, 4, -2, 2, -12, -7, 35, -7, 12, -6, 3 };

	cout << "Task - 4" << endl;
	showArray(fourthArray, 12);

	int n = 0; 
	double sum = 0;
	for (size_t i = 0; i < 12; i++)
	{
		double elem = fourthArray[i];

		if (elem < 0)
		{
			++n;
		}

		if (elem < 0 && (n == 2 || n == 4))
		{
			sum += elem;
		}
	}

	cout << "Sum result : " << sum << endl;

	// Task 5

	double fifthArray[12] = { 12, -5, 0, -2, 2, -12, 0, 35, -7, 12, -6, 3 };

	cout << "Task - 5" << endl;
	showArray(fifthArray, 12);

	int zeroIndex = -1, maxElemIndex = 0;
	double maxElem = 0;
	for (size_t i = 0; i < 12; i++)
	{
		double elem = fifthArray[i];

		if (maxElem < elem)
		{
			maxElemIndex = i;
			maxElem = elem;
		}
	}

	for (size_t i = 0; i < 12; i++)
	{
		double elem = fifthArray[i];

		if (elem == 0)
		{
			if (zeroIndex != -1)
			{
				fifthArray[zeroIndex] = maxElem;
			}

			zeroIndex = i;

			fifthArray[zeroIndex] = maxElem;
			fifthArray[maxElemIndex] = 0;
		}
	}

	showArray(fifthArray, 12);

	return 0;
}