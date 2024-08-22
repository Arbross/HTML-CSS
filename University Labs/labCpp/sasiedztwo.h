//
// Created by victor on 20.03.2024.
//

#ifndef LABCPP_SASIEDZTWO_H
#define LABCPP_SASIEDZTWO_H


#include "ustawienia.h"

class Sasiedztwo {
private:
    RodzajMieszkanca sasiad[3][3];

    RodzajMieszkanca *elementWewnetrzny(Polozenie polozenie);

    static Polozenie losujPolozenie();

public:
    Sasiedztwo(RodzajMieszkanca rodzaj = NIEZNANE);

    void okreslSasiada(Polozenie polozenie, RodzajMieszkanca rodzaj);

    RodzajMieszkanca ktoJestSasiadem(Polozenie polozenie);

    unsigned short ile(RodzajMieszkanca rodzaj) const;

    Polozenie losujSasiada(RodzajMieszkanca rodzaj);

    static void zmienIdeksyWgPolozenia(Polozenie polozenie, long &wiersz, long &kolumna);

    static void zmienIdeksyWgPolozenia(Polozenie polozenie, unsigned int &wiersz, unsigned int &kolumna);
};


#endif //LABCPP_SASIEDZTWO_H
