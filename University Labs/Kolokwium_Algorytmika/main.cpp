#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
#include <cstdlib>

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

void wczytajUzytkownikow(User*& array);
void bubbleSort(User*& array, int size, SortType type);
void findUsers(User*& array, int left, int right, float value);
string wyszukiwanieBisekcyjne(User*& array, int left, int right, float value);

int main() {
    User* array;
    // Zad 1
    wczytajUzytkownikow(array);

    // Zad 2
    bubbleSort(array, 656, ASCENDING);

    for (int i = 0; i < 656; ++i) {
        cout << array[i].country << ", "
             << array[i].language << ", "
             << array[i].users << ", "
             << array[i].official;
    }

    cout << "---Zad 3---" << endl << "Find by users:" << endl;
    findUsers(array, 0, 656, 422);

    cout << endl << "---Zad 4---" << endl << "Wyszukiwanie bisekcyjne rekurencyjne:" << endl;
    float value = 0.6;
    cout << "Rezultatem za znaczeniem " << value << " jest kraj: " << wyszukiwanieBisekcyjne(array, 0, 656, value) << endl;

    delete []array;
    return 0;
}

string wyszukiwanieBisekcyjne(User*& array, int left, int right, float value) {
    int pivot = (int) (left + right) / 2;
    if (left <= right) {
        if (array[pivot].users == value) {
            return array[pivot].country;
        }
        else if (array[pivot].users < value) {
            return wyszukiwanieBisekcyjne(array, pivot + 1, right, value);
        }
        else {
            return wyszukiwanieBisekcyjne(array, left, pivot - 1, value);
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

void wczytajUzytkownikow1(User*& array) {
    string line;
    char separator = ';';
    ifstream file("uzytkownicy.csv");

    if (!file.is_open()) {
        cout << "Failed to open file!" << endl;
        return; // Or handle the error appropriately
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
        getline(ss, array[i].official);
    }

    file.close();
}

void wczytajUzytkownikow(User *&tab) {
    string sciezka, linia, pomoc;
    ifstream plik;

    //Plik powinien znajdować się w cmake-build-debug
    sciezka = "uzytkownicy.csv";

    plik.open(sciezka);
    plik >> linia;

    //alokowanie pamięci w tab o dlugosci liczbaStudentow
    tab = new User[656];


    for (int i = 0; i < 656; i++) {
        getline(plik >> ws, linia);

        stringstream ss(linia);
        getline(ss, tab[i].country, ';');
        getline(ss, tab[i].language, ';');
        getline(ss, pomoc, ';');
        tab[i].users = atof(pomoc.c_str());
        getline(ss, tab[i].official);
    }
    plik.close();
}
