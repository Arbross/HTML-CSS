#include <iostream>

using namespace std;

struct Date {
	int hours;
	int minutes;
	int day;
	int month;
	int year;
};

struct Train
{
	string Name;
	int Number;
	Date Date;
	float Price; // Time, ціна одиниці товару
};

void bubbleSort(Train arr[], int n) {
	for (int i = 0; i < n - 1; i++) {
		for (int j = 0; j < n - i - 1; j++) {
			if (arr[j].Number < arr[j + 1].Number) {
				Train temp = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = temp;
			}
		}
	}
}

int main() {
	Train autopark[5];

	// Fill an array
	for (size_t i = 0; i < 5; i++)
	{
		cout << "Enter Date - minutes value: "; cin >> autopark[i].Date.minutes;
		cout << "Enter Date - hours value: "; cin >> autopark[i].Date.hours;
		cout << "Enter Date - day value: "; cin >> autopark[i].Date.day;
		cout << "Enter Date - month value: "; cin >> autopark[i].Date.month;
		cout << "Enter Date - year value: "; cin >> autopark[i].Date.year;

		cout << "Enter name of train: "; cin >> autopark[i].Name;
		cout << "Enter the number of train: "; cin >> autopark[i].Number;
		cout << "Enter the price of the current bull of train: "; cin >> autopark[i].Price;

		system("cls");
	}

	// Sort array by number value
	bubbleSort(autopark, 5);

	// Print an array
	for (int i = 0; i < 5; i++) {
		cout << "Train " << autopark[i].Number << " - " << autopark[i].Name << endl;
	}

	cout << endl;

	// Print an array that date more than 15.00
	for (int i = 0; i < 5; i++) {
		if (autopark[i].Date.hours >= 15 && autopark[i].Date.minutes >= 0)
		{
			cout << "Train " << autopark[i].Number << " - " << autopark[i].Name << endl;
		}
	}

	return 0;
}
