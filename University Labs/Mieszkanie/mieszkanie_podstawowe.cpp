#include "mieszkanie_podstawowe.h"

MieszkaniePodstawowe::MieszkaniePodstawowe(int cena, int pietro, double powierzchnia) {
    if (cena < 0) {
        cena = 0;
        return;
    }

    if (pietro < 0) {
        pietro = 1;
        return;
    }
    else if (pietro > 15) {
        pietro = 15;
        return;
    }

    if (powierzchnia < 0) {
        powierzchnia = 0;
        return;
    }

    this->cena = cena;
    this->pietro = pietro;
    this->powierzchnia = powierzchnia;
}

void MieszkaniePodstawowe::wyswietl() const {
    cout << "MIESZKANIE:\tcena m2: "
         << cena << "zł\tpiętro: "
         << pietro << "\tpowierzchnia: "
         << powierzchnia << " m2" << endl;
}
