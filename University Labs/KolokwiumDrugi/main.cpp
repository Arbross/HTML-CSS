#include <iostream>
#include "stacjameteo.h"
#include "stacjameteous.h"

using namespace std;

int main() {
    StacjaMeteo sm1("Warszawa", 20, 45);
    sm1.zmienTemperature(21);
    sm1.zmienWilgotnosc(50);

    StacjaMeteoUS sm2("Boston", 15, 30);
    StacjaMeteoUS sm3("Detroit", 59, 30, true);

    cout << sm3 << endl;
    sm3.zmienTemperature(0);
    cout << sm3 << endl;

    cout << endl;

    cout << sm1 << endl;
    cout << sm2 << endl;
    cout << sm3 << endl;

    return 0;
}
