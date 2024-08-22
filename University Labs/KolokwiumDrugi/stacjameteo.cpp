#include "stacjameteo.h"

string StacjaMeteo::doTekstu() const {
    string temp = to_string(temperatura);
    string result;
    bool exit = false;
    for (int i = 0; i < temp.length(); ++i) {
        if (temp[i] == '-' && temp[i + 1] == '0') {
            continue;
        }

        result += temp[i];

        if (exit) {
            break;
        }
        if (temp[i] == '.') {
            exit = true;
        }
    }
    return "Stacja pomiarowa: " + nazwa + "\tTemperatura = " + result + "C\tWilgotność=" + to_string(wilgotnosc) + "%\tBiometr: " + obliczBiometr();
}

StacjaMeteo::StacjaMeteo(string nazwa, float temperatura, int wilgotnosc) {
    zmienWilgotnosc(wilgotnosc);

    this->nazwa = nazwa;
    this->temperatura = temperatura;
}

string StacjaMeteo::obliczBiometr() const {
    if (temperatura >= 15 && temperatura <= 25
        && wilgotnosc >= 30 && wilgotnosc <= 60
        && !czyKorzystny(temperatura, wilgotnosc)) {
        return "obojętny";
    }
    else if (czyKorzystny(temperatura, wilgotnosc)) {
        return "korzystny";
    }
    else {
        return "niekorzystny";
    }
}

bool StacjaMeteo::czyKorzystny(float temp, int wilg) const {
    return temp >= 20 && temp <= 22 && wilg >= 40 && wilg <= 50;
}

void StacjaMeteo::zmienTemperature(float temperatura) {
    this->temperatura = temperatura;
}

void StacjaMeteo::zmienWilgotnosc(int wilgotnosc) {
    if (wilgotnosc < 0) {
        this->wilgotnosc = 0;
    }
    else if (wilgotnosc > 100) {
        this->wilgotnosc = 100;
    }
    else {
        this->wilgotnosc = wilgotnosc;
    }
}


