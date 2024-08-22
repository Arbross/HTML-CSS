//
// Created by Victor Pavlovskyi on 06.03.2024.
//

#include <iostream>
#include "organizm.h"

using namespace std;

Organizm::Organizm(unsigned short dlugoscZycia,
                   unsigned short limitPosilkow,
                   unsigned short kosztPotomka) :
        limitPosilkow(limitPosilkow),
        kosztPotomka(kosztPotomka),
        licznikZycia(dlugoscZycia),
        licznikPosilkow(0) {}

bool Organizm::posilek() {
    if (glodny()) {
        licznikPosilkow++;
        return true;
    } else return false;
}

bool Organizm::potomek() {
    if (paczkujacy()) {
        licznikPosilkow -= kosztPotomka;
        return true;
    } else return false;
}

void Organizm::krokSymulacji() {
    if (zywy()) licznikZycia--;
}
