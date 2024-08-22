//
// Created by victor on 09.04.2024.
//

#include "tv.h"

TV::TV(string marka)
    : UrzadzenieElektryczne(marka) {
    this->kanal = 0;
    this->glosnosc = 0;
}

void TV::podglosnij() {
    if (glosnosc < 40 && jakiStan())
    {
        glosnosc += 1;
    }
}

void TV::scisz() {
    if (glosnosc != 0 && jakiStan())
    {
        glosnosc -= 1;
    }
}

void TV::zmienKanal(int kanal) {
    if (!jakiStan())
    {
        wlacz();
    }

    if (kanal > 40)
    {
        this->kanal = 40;
    }
    else if (kanal < 0)
    {
        this->kanal = 0;
    }
    else {
        this->kanal = kanal;
    }
}

void TV::wypisz() {
    cout << "TV " << jakaMarka() << ", stan: " << jakiStan() << endl;
    cout << "TV kanal: " << kanal << ", głosność" << glosnosc << endl;
}
