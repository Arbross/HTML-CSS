#include <iostream>
#include "urzadzenie_elektryczne.h"

using namespace std;

int main() {
    UrzadzenieElektryczne u1("LG");
    u1.wlacz();
    cout << "Urzadzenie elekryczne " << u1.jakaMarka() << ", stan: " << u1.jakiStan() << endl;

    return 0;
}
