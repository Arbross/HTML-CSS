#ifndef LAB3_ALG_STUDENTBUILDER_H
#define LAB3_ALG_STUDENTBUILDER_H

#include <fstream>
#include "student.h"

class StudentBuilder {
public:
    static void wczytaj(Student*& array, int size);
    static void wczytajZPliku(Student*& array);
    static void usunTablice(Student*& array);
    static void wyswietl(Student* array, int size);
};

#endif
