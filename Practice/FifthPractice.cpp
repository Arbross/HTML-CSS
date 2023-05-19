#include<iostream>
#include<math.h>
#include <ctime>
#include <iomanip>

using namespace std;

void initialize(int rows, int cols, int** matrix)
{
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            matrix[i][j] = rand() % 100 + 1;
        }
    }
}

void print(int rows, int cols, int** matrix)
{
    for (int i = 0; i < rows; i++) {
        cout << " |";
        for (int j = 0; j < cols; j++) {
            if (j == 0)
            {
                if (matrix[i][j] < 10)
                {
                    cout << " " << matrix[i][j];
                    continue;
                }

                cout << matrix[i][j];
            }
            else {
                cout << setw(4) << matrix[i][j];
            }
        }
        cout << "|" << endl;
    }
}

void count(int rows, int cols, int** matrix, unsigned long long* result)
{
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            if (matrix[i][j] != 0 && i % 2 != 0 && j % 2 != 0)
            {
                *result *= matrix[i][j];
            }
        }
    }
}

int main()
{
    srand(time(0));

	// Task 1

    int rows, cols;
    cout << "Enter number of rows: ";
    cin >> rows;
    cout << "Enter number of columns: ";
    cin >> cols;

    int** matrix = new int* [rows];
    for (int i = 0; i < rows; i++) {
        matrix[i] = new int[cols];
    }

    initialize(rows, cols, matrix);

    print(rows, cols, matrix);

    unsigned long long result = 1;
    count(rows, cols, matrix, &result);

    cout << "Here is your result: " << result << endl;

    for (int i = 0; i < rows; i++) {
        delete[] matrix[i];
    }
    delete[] matrix;

    // Task 2

    int arr_0[12];

    for (size_t i = 0; i < 12; i++)
    {
        arr_0[i] = rand() % (190 - 163 + 1) + 163;

        cout << i << " - " << arr_0[i] << endl;
    }

    // Task 3

    int arr[] = { 3, -5, 1, 7, -2, -6, 8 };
    int n = sizeof(arr) / sizeof(arr[0]);

    int max_mod = abs(arr[0]);
    int min_mod = abs(arr[0]);
    int max_index = 0;
    int min_index = 0;

    for (int i = 1; i < n; i++) {
        if (abs(arr[i]) > max_mod) {
            max_mod = abs(arr[i]);
            max_index = i;
        }
        if (abs(arr[i]) < min_mod) {
            min_mod = abs(arr[i]);
            min_index = i;
        }
    }

    int prod = 1;
    int start_index, end_index;

    if (max_index > min_index) {
        start_index = min_index + 1;
        end_index = max_index;
    }
    else {
        start_index = max_index + 1;
        end_index = min_index;
    }

    for (int i = start_index; i < end_index; i++) {
        prod *= arr[i];
    }

    cout << "Your result value: " << prod << endl;


	return 0;
}
