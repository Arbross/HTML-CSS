#include <iostream>
#include <fstream>
#include <string>

using namespace std;

// Task 1

struct DateTime
{
	int day;
	int month;
	int year;

	int hour;
};

struct Train
{
	int Number;
	string Name;
	DateTime Date;
	double Price;
};

void swap(Train& elem1, Train& elem2)
{
	Train temp = elem1;
	elem1 = elem2;
	elem2 = temp;
}

bool isSorted(Train a, Train b) { return a.Number >= b.Number; }

Train* sortArrayByDesc(Train array[], int size)
{
	bool flag = false;

	for (int i = 1; i < size; i++)
	{
		flag = false;

		for (int j = 0; j < size - i; j++)
		{
			if (!isSorted(array[j], array[j + 1]))
			{
				swap(array[j], array[j + 1]);
				flag = true;
			}
		}

		if (!flag)
		{
			break;
		}
	}

	return array;
}


int main()
{
	// Task 2

	const int SIZE = 2;
	Train autopark[2];

	for (size_t i = 0; i < SIZE; i++)
	{
		cout << "Enter number of train : "; cin >> autopark[i].Number;
		cout << "Enter name of train : "; cin >> autopark[i].Name;
		cout << "Enter price of train : "; cin >> autopark[i].Price;

		cout << "Enter day : "; cin >> autopark[i].Date.day;
		cout << "Enter month : "; cin >> autopark[i].Date.month;
		cout << "Enter year : "; cin >> autopark[i].Date.year;

		cout << "Enter hour : "; cin >> autopark[i].Date.hour;
	}

	Train* newArr = sortArrayByDesc(autopark, SIZE);

	cout << "-----------------------------------" << endl;

	DateTime date;
	cout << "Enter day : "; cin >> date.day;
	cout << "Enter month : "; cin >> date.month;
	cout << "Enter year : "; cin >> date.year;

	for (size_t i = 0; i < SIZE; i++)
	{
		if (newArr[i].Date.hour >= 15 && newArr[i].Date.day == date.day && newArr[i].Date.month == date.month && newArr[i].Date.year == date.year)
		{
			cout << "Name of train : " << newArr[i].Name << endl;
		}
	}

	return 0;
}
