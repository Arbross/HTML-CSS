#ifndef KOLOKWIUMDRUGI_C_STACJAMETEOUS_H
#define KOLOKWIUMDRUGI_C_STACJAMETEOUS_H


#include <iostream>
#include "stacjameteo.h"

using namespace std;

class StacjaMeteoUS : public StacjaMeteo {
public:
    friend class StacjaMeteo;

    StacjaMeteoUS(string nazwa, float temperatura, int wilgotnosc, bool trybUS = false);
    virtual void zmienTemperature(float temperatura) override final;

    friend ostream& operator <<(ostream& os, const StacjaMeteoUS& obj) {
        os << obj.doTekstu();
        return os;
    }

protected:
    bool trybUS;
    virtual string doTekstu() const override final;
};


#endif
