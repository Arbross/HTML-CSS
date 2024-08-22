#ifndef MIESZKANIE_TABLICA_OGLOSZEN_H
#define MIESZKANIE_TABLICA_OGLOSZEN_H

#include <iostream>
#include <vector>
#include "mieszkanie_podstawowe.h"

using namespace std;

class MieszkaniePodstawowe;

class TablicaOgloszen {
private:
    vector<MieszkaniePodstawowe> mieszkania;
public:
    TablicaOgloszen& operator +=(const MieszkaniePodstawowe& mieszkanie);
    double obliczSredniaCene() const;
    void wyswietl() const;
};


#endif
