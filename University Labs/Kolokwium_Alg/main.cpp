#include <iostream>
#include <fstream>
#include <sstream>

using namespace std;

struct User {
    string country;
    string language;
    float users;
    string official;
};

enum SortType {
    ASCENDING = 0,
    DESCENDING = 1,
};

void wczytajUzytkownikow(User *&tab);
void bubbleSort(User*& array, int size, SortType type);
void findUsers(User*& array, int left, int right, float value);
string wyszukiwanieBisekcyjne(User*& array, int left, int right, float value);

int main() {
    User* array;
    wczytajUzytkownikow(array);
    bubbleSort(array, 656, ASCENDING);

    float value = 0;
    cout << "Wpisz ilość użytkowników w mln: "; cin >> value;

    cout << "---Zad 3---" << endl << "Find by users:" << endl;
    findUsers(array, 0, 656, value);

    cout << endl << "---Zad 4---" << endl << "Wyszukiwanie bisekcyjne rekurencyjne:" << endl;
    cout << "Rezultatem ze znaczeniem " << value << " jest kraj: " << wyszukiwanieBisekcyjne(array, 0, 656, value) << endl;

    delete []array;
    return 0;
}

string wyszukiwanieBisekcyjne(User*& array, int left, int right, float value) {
    int pivot = (int) (left + right) / 2;
    if (left <= right) {
        if (array[pivot].users == value) {
            return array[pivot].country;
        }
        else {
            if (array[pivot].users < value) {
                return wyszukiwanieBisekcyjne(array, pivot + 1, right, value);
            }
            else {
                return wyszukiwanieBisekcyjne(array, left, pivot - 1, value);
            }
        }
    }

    return "Not Found";
}

void findUsers(User*& array, int left, int right, float value) {
    while (left <= right) {
        int pivot = (int)(left + right) / 2;
        if (array[pivot].users == value) {
            cout << array[pivot].country << ", "
                 << array[pivot].language << ", "
                 << array[pivot].users << ", "
                 << array[pivot].official << endl;
            return;
        }
        else {
            if (value < array[pivot].users) {
                right = pivot - 1;
            }
            else {
                left = pivot + 1;
            }
        }
    }
}

void bubbleSort(User*& array, int size, SortType type) {
    for (int i = 0; i < size - 1; ++i) {
        for (int j = 0; j < size - i - 1; ++j) {
            if (type == ASCENDING) {
                if (array[j].users > array[j + 1].users) {
                    swap(array[j], array[j + 1]);
                }
            } else if (type == DESCENDING) {
                if (array[j].users < array[j + 1].users) {
                    swap(array[j], array[j + 1]);
                }
            }
        }
    }
}

void wczytajUzytkownikow(User*& array) {
    string line;
    char separator = ';';
    ifstream file("uzytkownicy.csv");

    if (!file.is_open()) {
        cout << "Plik nie istnieje!" << endl;
        return;
    }
    file >> line;

    array = new User[656];

    string tempUsers;
    for (int i = 0; i < 656; ++i) {
        getline(file >> ws, line);
        stringstream ss(line);

        getline(ss, array[i].country, separator);
        getline(ss, array[i].language, separator);
        getline(ss, tempUsers, separator);
        array[i].users = atof(tempUsers.c_str());
        getline(ss, array[i].official, '\r');
    }

    file.close();
}
