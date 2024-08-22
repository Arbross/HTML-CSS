//
// Created by victor on 22.03.2024.
//

#ifndef URZADZENIEELEKTRYCZNE_URZADZENIE_ELEKTRYCZNE_H
#define URZADZENIEELEKTRYCZNE_URZADZENIE_ELEKTRYCZNE_H

#include <iostream>

using namespace std;

class UrzadzenieElektryczne {
private:
    string marka;
    bool stan;
public:
    UrzadzenieElektryczne(string marka);
    const void wlacz();
    const void wylacz();
    const string jakaMarka();
    const bool jakiStan();
    const void wpisz();
};


#endif //URZADZENIEELEKTRYCZNE_URZADZENIE_ELEKTRYCZNE_H
