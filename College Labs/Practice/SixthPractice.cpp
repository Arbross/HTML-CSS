#include <iostream>
#include <math.h>
#include <ctime>
#include <iomanip>

using namespace std;

void initialize(int rows, int cols, int** matrix)
{
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            matrix[i][j] = rand() % 150 + 1;
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

void count(int rows, int cols, int** matrix, int* arr)
{
    for (int i = 0; i < rows; i++) {
        int count = 0;
        for (int j = 0; j < cols; j++) {
            count += matrix[i][j];
        }
        arr[i] = count;
    }
}

void countCandidate(int rows, int cols, int** matrix)
{
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            if ((j == 1 || j == 5) && matrix[i][j] > 100)
            {
                cout << "Candidate number - " << i << " got more then 100 votes." << endl;
            }
        }
    }
}

int main()
{
    srand(time(0));

    // Task 1

    int rows = 5, cols = 6;

    int** matrix = new int* [rows];
    for (int i = 0; i < rows; i++) {
        matrix[i] = new int[cols];
    }

    initialize(rows, cols, matrix);

    print(rows, cols, matrix);

    int arr[5];
    count(rows, cols, matrix, arr);

    for (size_t i = 0; i < 5; i++)
    {
        cout << arr[i] << " ";
    }

    countCandidate(rows, cols, matrix);

    // Task 2

    const int ROWS = 3;
    const int COLS = 7;

    int A[ROWS][COLS] = {
        { 1, 2, 3, 4, 5, 6, 7 },
        { 8, 9, 10, 11, 12, 13, 14 },
        { 15, 16, 17, 18, 19, 20, 21 }
    };

    int B[ROWS][COLS];

    // Copy A to B
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
            B[i][j] = A[i][j];
        }
    }

    // Iterate over each column
    for (int j = 0; j < ROWS; j++) {
        // Find the maximum element in the column
        int maxIndex = 0;
        int maxElement = A[maxIndex][j];
        for (int i = 1; i < ROWS; i++) {
            if (A[i][j] > maxElement) {
                maxIndex = i;
                maxElement = A[i][j];
            }
        }

        // Find the diagonal element in the same column
        int diagonalIndex = j;
        int diagonalElement = A[j][j];

        // If the maximum element is greater than the diagonal element, swap them
        if (maxElement > diagonalElement) {
            B[diagonalIndex][j] = maxElement;
            B[maxIndex][j] = diagonalElement;
        }
    }

    // Print the original
    for (int i = 0; i < ROWS; i++) {
        cout << " |";
        for (int j = 0; j < COLS; j++) {
            if (j == 0)
            {
                if (A[i][j] < 10)
                {
                    cout << " " << A[i][j];
                    continue;
                }

                cout << A[i][j];
            }
            else {
                cout << setw(4) << A[i][j];
            }
        }
        cout << "|" << endl;
    }

    cout << endl;

    // Print the result
    for (int i = 0; i < ROWS; i++) {
        cout << " |";
        for (int j = 0; j < COLS; j++) {
            if (j == 0)
            {
                if (B[i][j] < 10)
                {
                    cout << " " << B[i][j];
                    continue;
                }

                cout << B[i][j];
            }
            else {
                cout << setw(4) << B[i][j];
            }
        }
        cout << "|" << endl;
    }

    return 0;
}
