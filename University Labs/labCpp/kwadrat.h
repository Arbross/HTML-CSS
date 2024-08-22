//
// Created by victor on 27.03.2024.
//

#ifndef LABCPP_KWADRAT_H
#define LABCPP_KWADRAT_H


#include <iostream>
#include "zlab03.h"
#include "zlab06.h"

using namespace std;

class Kwadrat : public Prostokat, public Obliczenia {
public:
    Kwadrat(string nazwa = "?", double bok = 0)
            : Prostokat(nazwa, bok, bok) {}

    virtual string doTekstu();

    double promienKolaWgPola() override;

    double promienOkreguWgObwodu() override;

    virtual ~Kwadrat() {
        cout << "Kwadrat: " << nazwa
             << " kończy działanie" << endl;
    }
};


#endif //LABCPP_KWADRAT_H
