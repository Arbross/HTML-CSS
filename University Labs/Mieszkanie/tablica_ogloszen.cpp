#include "tablica_ogloszen.h"

TablicaOgloszen &TablicaOgloszen::operator+=(const MieszkaniePodstawowe &mieszkanie) {
    mieszkania.push_back(mieszkanie);
    return *this;
}

double TablicaOgloszen::obliczSredniaCene() const {
    double sum = 0;
    for (auto value : mieszkania) {
        sum += value.cena;
    }

    return sum / (double)(mieszkania.end() - mieszkania.begin());
}

void TablicaOgloszen::wyswietl() const {
    for (auto value : mieszkania) {
        cout << "MIESZKANIE:\tcena m2:"
             << value.cena << "zł\tpiętro: "
             << value.pietro << "\tpowierzchnia: "
             << value.powierzchnia << " m2" << endl;
    }
}
