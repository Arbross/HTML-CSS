#ifndef LABCPP_SRODOWISKO_H
#define LABCPP_SRODOWISKO_H

#include <iostream>
#include "ustawienia.h"

using namespace std;

class Nisza;
class Mieszkaniec;
class Sasiedztwo;

class Srodowisko {
public:
    const unsigned int wiersze, kolumny;
    const unsigned long liczbaNisz;
private:
    Nisza **nisza;
public:
    Srodowisko(unsigned int _wiersze, unsigned int _kolumny);
    ~Srodowisko();

    static Srodowisko czytajZPliku(std::string nazwaPliku);
    void lokuj(Mieszkaniec *mieszkaniec, unsigned int wiersz, unsigned int kolumna);
    Sasiedztwo ustalSasiedztwo(unsigned int wiersz, unsigned int kolumna) const;
    unsigned long liczba(RodzajMieszkanca rodzaj) const;
    bool martwy();
    void wykonajSkok(unsigned int wiersz, unsigned int kolumna);
    void wykonajAkcje(unsigned int wiersz, unsigned int kolumna);
    void wykonajKrokSymulacji();
    string doTekstu() const;
    void operator++(int) { wykonajKrokSymulacji(); }
    bool operator!() { return !martwy(); }
};

std::ostream & operator<<(std::ostream & strumien, const Srodowisko & srodowisko);

#endif
