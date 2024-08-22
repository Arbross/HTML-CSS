#include "drukarka.h"

const int Drukarka::ileStron() {
    return (int)(((float)wydajnosc * poziom_czarny) / 100);
}

Drukarka::Drukarka(string marka, int wydajnosc, float poziom_czarny)
{
    this->marka = marka;
    this->wydajnosc = wydajnosc;
    this->poziom_czarny = poziom_czarny;
}

const void Drukarka::doTekstu() {
    cout << marka << "\t" << "Wydrukujesz jeszcze .." << ileStron() << ".. stron." << endl;
}
