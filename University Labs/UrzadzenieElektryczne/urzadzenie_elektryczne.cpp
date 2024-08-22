//
// Created by victor on 22.03.2024.
//

#include "urzadzenie_elektryczne.h"

UrzadzenieElektryczne::UrzadzenieElektryczne(string marka) {
    this->marka = marka;
    this->stan = false;
}

const void UrzadzenieElektryczne::wlacz() {
    stan = true;
}

const void UrzadzenieElektryczne::wylacz() {
    stan = false;
}

const string UrzadzenieElektryczne::jakaMarka() {
    return marka;
}

const bool UrzadzenieElektryczne::jakiStan() {
    return stan;
}

const void UrzadzenieElektryczne::wpisz() {
    cout << "Wpisz markę urządzenia elektrycznego: "; cin >> marka;
    cout << "Wpisz stan urządzenia elektrycznego: "; cin >> stan;
}
