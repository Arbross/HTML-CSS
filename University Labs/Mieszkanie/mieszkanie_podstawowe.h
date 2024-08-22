#ifndef MIESZKANIE_MIESZKANIE_PODSTAWOWE_H
#define MIESZKANIE_MIESZKANIE_PODSTAWOWE_H

#include <iostream>
#include "tablica_ogloszen.h"

using namespace std;

class MieszkaniePodstawowe {
protected:
    int cena = 0;
    int pietro = 1;
    double powierzchnia = 0;
public:
    friend class TablicaOgloszen;

    MieszkaniePodstawowe() = default;
    MieszkaniePodstawowe(int cena, int pietro, double powierzchnia);
    void wyswietl() const;
};

#endif
