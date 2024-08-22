#include "drukarkakolorowa.h"

DrukarkaKolorowa::DrukarkaKolorowa(string marka, int wydajnosc,
                                   float poziom_czarny, float poziom_cyan, float poziom_magenta,
                                   float poziom_zolty) : Drukarka(marka, wydajnosc, poziom_czarny) {
    this->poziom_cyan = poziom_cyan;
    this->poziom_magenta = poziom_magenta;
    this->poziom_zolty = poziom_zolty;
}

const int DrukarkaKolorowa::ileStron() {
    float tab[4] = {((float) wydajnosc * poziom_czarny) / 100, ((float) wydajnosc * poziom_cyan) / 100,
                    ((float) wydajnosc * poziom_magenta) / 100, ((float) wydajnosc * poziom_zolty) / 100};

    float min = tab[0];
    for (float i : tab) {
        if (min > i) {
            min = i;
        }
    }

    return (int)min;
}
