#include <iostream>
#include <fstream>
#include <sstream>

using namespace std;

class Student {
public:
    string imie;
    string nazwisko;
    int ocena;
};

int wyszukiwanieLiniowe(Student array[], int size, int value);

int wyszukiwanieLinioweRekurencyjnie(Student array[], int size, int value, int temp);

int wyszukiwanieBisekcyjne(Student array[], int size, int value);

int wyszukiwanieBisekcyjneRekurencyjnie(Student array[], int left, int right, int value);

void wczytajZPliku(Student *&array);

int main() {
    Student *array;

    int choose = 0;
    while (true) {
        cout << "1 - Wczytanie z pliku" << endl
             << "2 - Wyszukiwanie liniowe" << endl
             << "3 - Wyszukiwanie bisekcyjne" << endl
             << "4 - Zapisz do pliku" << endl
             << "5 - Wyjście" << endl;
        cin >> choose;

        switch (choose) {
            case 1: {
                wczytajZPliku(array);
            }
                break;
            case 2: {
                cout << "Liniowe proste: " << wyszukiwanieLiniowe(array, 5, 21) << endl;
                cout << "Liniowe rekurencyjnie: " << wyszukiwanieLinioweRekurencyjnie(array, 5, 21, 0) << endl;
            }
                break;
            case 3: {
                cout << "Bisekcyjne proste: " << wyszukiwanieBisekcyjne(array, 5, 45) << endl;
                cout << "Bisekcyjne rekurencyjnie: " << wyszukiwanieBisekcyjneRekurencyjnie(array, 0, 4, 15) << endl;
            }
                break;
            case 4: {
                ofstream stream;
                string path = "wyniki.csv";
                stream.open(path);

                stream << 5 << endl;
                for (int i = 0; i < 5; ++i) {
                    stream << array[i].imie << ";" << array[i].nazwisko << ";";
                    stream << array[i].ocena << endl;
                }

                stream.close();
            }
                break;
            case 5: {
                return 0;
            }
            default:
                return 0;
        }
    }
}

void wczytajZPliku(Student *&array) {
    string sciezka, linia, pomoc;
    int liczbaStudentow;
    ifstream plik;
    char sredniki;

    // Plik powinien znajdować się w cmake-build-debug
    sciezka = "wyniki.csv";

    plik.open(sciezka);
    plik >> liczbaStudentow;

    // Alokowanie pamięci w tab o dlugosci liczbaStudentow
    array = new Student[liczbaStudentow];

    for (int i = 0; i < 2; i++)
        plik >> sredniki;

    for (int i = 0; i < liczbaStudentow; i++) {
        plik >> linia;

        stringstream ss(linia);
        getline(ss, array[i].imie, ';');
        getline(ss, array[i].nazwisko, ';');
        getline(ss, pomoc);
        array[i].ocena = atoi(pomoc.c_str());
    }
    plik.close();
}

int wyszukiwanieBisekcyjne(Student array[], int size, int value) {
    int left = 0, right = size - 1;
    for (int i = left; i < right; ++i) {
        int pivot = (left + right) / 2;
        if (array[pivot].ocena == value) {
            return array[pivot].ocena;
        } else {
            if (value < array[pivot].ocena) {
                right = pivot - 1;
            } else {
                left = pivot + 1;
            }
        }
    }

    return -1;
}

int wyszukiwanieBisekcyjneRekurencyjnie(Student array[], int left, int right, int value) {
    int pivot = (left + right) / 2;
    if (left <= right) {
        if (array[pivot].ocena == value) {
            return array[pivot].ocena;
        } else {
            if (value < array[pivot].ocena) {
                return wyszukiwanieBisekcyjneRekurencyjnie(array, left, pivot - 1, value);
            } else {
                return wyszukiwanieBisekcyjneRekurencyjnie(array, pivot + 1, right, value);
            }
        }
    } else {
        return -1;
    }
}

int wyszukiwanieLiniowe(Student array[], int size, int value) {
    for (int i = 0; i < size; ++i) {
        if (array[i].ocena == value) {
            return array[i].ocena;
        }
    }

    return -1;
}

int wyszukiwanieLinioweRekurencyjnie(Student array[], int size, int value, int temp = 0) {
    if (array[temp].ocena == value) {
        return array[temp].ocena;
    } else if (temp == size) {
        return -1;
    }

    return wyszukiwanieLinioweRekurencyjnie(array, size, value, ++temp);
}
