#ifndef KOLOKWIUMDRUGI_C_STACJAMETEO_H
#define KOLOKWIUMDRUGI_C_STACJAMETEO_H


#include <iostream>

using namespace std;

class StacjaMeteo {
public:
    StacjaMeteo(string nazwa, float temperatura, int wilgotnosc);
    virtual string obliczBiometr() const final;

    virtual void zmienTemperature(float temperatura);
    virtual void zmienWilgotnosc(int wilgotnosc) final;
    friend ostream& operator <<(ostream& os, const StacjaMeteo& obj) {
        os << obj.doTekstu();
        return os;
    }

protected:
    string nazwa;
    float temperatura;
    int wilgotnosc;
    virtual string doTekstu() const;
private:
    bool czyKorzystny(float temp, int wilg) const;
};


#endif
