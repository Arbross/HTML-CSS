#include "stacjameteous.h"

StacjaMeteoUS::StacjaMeteoUS(string nazwa, float temperatura, int wilgotnosc, bool trybUS)
    : StacjaMeteo(nazwa, temperatura, wilgotnosc) {
    this->trybUS = trybUS;

    if (trybUS) {
        zmienTemperature(temperatura);
    }
}

void StacjaMeteoUS::zmienTemperature(float temperatura) {
    if (trybUS) {
        this->temperatura = ((temperatura - 32) * 5)/9;
    }
    else {
        StacjaMeteo::zmienTemperature(temperatura);
    }
}

string StacjaMeteoUS::doTekstu() const {
    if (trybUS) {
        float fahrenheitTemperature = 5 / 9 * (temperatura - 32);
        string temp = to_string(fahrenheitTemperature);
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
        return "Stacja pomiarowa: " + nazwa + "\tTemperatura = " + result + "F\tWilgotność=" + to_string(wilgotnosc) + "%\tBiometr: " + obliczBiometr();
    }
    else {
        return StacjaMeteo::doTekstu();
    }
}
