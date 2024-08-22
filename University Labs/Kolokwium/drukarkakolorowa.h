#ifndef KOLOKWIUM_DRUKARKAKOLOROWA_H
#define KOLOKWIUM_DRUKARKAKOLOROWA_H

#include <iostream>
#include "drukarka.h"

using namespace std;

class DrukarkaKolorowa : public Drukarka {
protected:
    float poziom_cyan;
    float poziom_magenta;
    float poziom_zolty;

    const int ileStron() override;
public:
    DrukarkaKolorowa(string marka, int wydajnosc,
                     float poziom_czarny, float poziom_cyan, float poziom_magenta,
                     float poziom_zolty);
};


#endif
