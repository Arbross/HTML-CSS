#include "drukarka.h"
#include "drukarkakolorowa.h"

using namespace std;

int main() {
    Drukarka d1("Epson", 750, 13);
    DrukarkaKolorowa d2("HP", 900, 12, 10.3, 25, 30);

    // Drukarka
    Drukarka* d = &d1;
    d->doTekstu();

    // DrukarkaKolorowa
    d = &d2;
    d->doTekstu();

    return 0;
}
