#ifndef KOLOKWIUM_DRUKARKA_H
#define KOLOKWIUM_DRUKARKA_H

#include <iostream>

using namespace std;

class Drukarka {
protected:
    string marka;
    int wydajnosc;
    float poziom_czarny;

    const virtual int ileStron();
public:
    Drukarka(string marka, int wydajnosc, float poziom_czarny);

    const void doTekstu();
};


#endif
