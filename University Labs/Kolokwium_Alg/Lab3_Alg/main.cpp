#include <iostream>
#include "student.h"
#include "studentBuilder.h"

using namespace std;

enum SortType {
    ASCENDING = 0,
    DESCENDING = 1,
};

int partition(Student*& array, int startIndex, int endIndex, Student pivot, SortType type);
void sortowanieQuickSort(Student*& array, int startIndex, int endIndex, SortType type = DESCENDING);

int main() {
    Student* students = nullptr;

    StudentBuilder::wczytajZPliku(students);
    StudentBuilder::wyswietl(students, 14);

    sortowanieQuickSort(students, 0, 14, DESCENDING);

    StudentBuilder::wyswietl(students, 14);

    delete [] students;
    return 0;
}

int partition(Student*& array, int left, int right, Student pivot, SortType type)
{
    while (left <= right)
    {
        if (type == ASCENDING) {
            while (array[left].mark < pivot.mark)
                left++;
            while (array[right].mark > pivot.mark)
                right--;
        } else { // SortType::DESCENDING
            while (array[left].mark > pivot.mark)
                left++;
            while (array[right].mark < pivot.mark)
                right--;
        }

        if (left <= right)
        {
            swap(array[left], array[right]);
            left += 1;
            right -= 1;
        }
    }

    return left;
}

void sortowanieQuickSort(Student*& array, int startIndex, int endIndex, SortType type)
{
    if (startIndex < endIndex)
    {
        int pivotIndex = (startIndex + endIndex) / 2;
        Student pivot = array[pivotIndex];

        int index = partition(array, startIndex, endIndex, pivot, type);
        sortowanieQuickSort(array, startIndex, index - 1, type);
        sortowanieQuickSort(array, index, endIndex, type);
    }
}
