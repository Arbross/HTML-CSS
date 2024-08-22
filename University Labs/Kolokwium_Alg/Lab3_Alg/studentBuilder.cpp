#include "studentBuilder.h"

void StudentBuilder::wczytaj(Student *&array, int size) {
    for (int i = 0; i < size; ++i) {
        cout << "-----------------------------------" << endl;
        cout << "Enter student " << i + 1 << " first name: "; cin >> array[i].firstName;
        cout << "Enter student " << i + 1 << " last name: "; cin >> array[i].lastName;
        cout << "Enter student " << i + 1 << " mark: "; cin >> array[i].mark;
        cout << "-----------------------------------" << endl << endl;
    }
}

void StudentBuilder::usunTablice(Student *&array) {
    delete [] array;
}

void StudentBuilder::wyswietl(Student *array, int size) {
    for (int i = 0; i < size; ++i) {
        cout << "-----------------Student " << i + 1 << "-----------------" << endl;
        cout << "Student " << i + 1 << " first name is " << array[i].firstName << endl;
        cout << "Student " << i + 1 << " last name is " << array[i].lastName << endl;
        cout << "Student " << i + 1 << " mark is " << array[i].mark << endl;
        cout << "-------------------------------------------" << endl << endl;
    }
}

void StudentBuilder::wczytajZPliku(Student *&array) {
    string sciezka, linia, pomoc;
    int liczbaStudentow;
    ifstream plik;
    char sredniki;

    // Plik powinien znajdować się w cmake-build-debug
    sciezka = "studenci.csv";

    plik.open(sciezka);
    plik >> liczbaStudentow;

    // Alokowanie pamięci w tab o dlugosci liczbaStudentow
    array = new Student[liczbaStudentow];

    for (int i = 0; i < 2; i++)
        plik >> sredniki;

    for (int i = 0; i < liczbaStudentow; i++) {
        plik >> linia;

        stringstream ss(linia);
        getline(ss, array[i].firstName, ';');
        getline(ss, array[i].lastName, ';');
        getline(ss, pomoc);
        array[i].mark = atoi(pomoc.c_str());
    }
    plik.close();
}
