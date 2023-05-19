#include <iostream>
#include <math.h>
#include <array> 

using namespace std;

void swap(int& elem1, int& elem2)
{
    int temp = elem1;
    elem1 = elem2;
    elem2 = temp;
}

bool isSorted(int a, int b) { return a >= b; }

int* sortArrayByDesc(int array[], int size)
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
    int arr[] = { 3, 5, 44, 2, 5, 64, 12, 85, 102, 12, 214, 15, 76 };
    int size = end(arr) - begin(arr);

    int* newArr = sortArrayByDesc(arr, size);

    for (size_t i = 0; i < size; i++)
    {
        int elem = newArr[i];

        cout << elem << ", ";
    }

    return 0;
}
