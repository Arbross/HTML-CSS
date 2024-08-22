#include <iostream>
#include <cstdlib>
#include <ctime>
#include "tablica_ogloszen.h"

using namespace std;

int rndNumber(int a, int b) {
    return a + rand() % (a - b + 1);
}

int main() {
    srand(time(NULL));
    TablicaOgloszen t;

    MieszkaniePodstawowe mieszkania[15] = {
            { rndNumber(5000, 8000), 1, 250 },
            { rndNumber(5000, 8000), 2, 250 },
            { rndNumber(5000, 8000), 3, 250 },
            { rndNumber(5000, 8000), 4, 250 },
            { rndNumber(5000, 8000), 5, 250 },
            { rndNumber(5000, 8000), 6, 250 },
            { rndNumber(5000, 8000), 7, 250 },
            { rndNumber(5000, 8000), 8, 250 },
            { rndNumber(5000, 8000), 9, 250 },
            { rndNumber(5000, 8000), 10, 250 },
            { rndNumber(5000, 8000), 11, 250 },
            { rndNumber(5000, 8000), 12, 250 },
            { rndNumber(5000, 8000), 13, 250 },
            { rndNumber(5000, 8000), 14, 250 },
            { rndNumber(5000, 8000), 15, 250 },
    };

    for (auto mieszkanie : mieszkania) {
        t += mieszkanie;
    }

    t.wyswietl();
    cout << "Średnia cena m2 wynosi: " << t.obliczSredniaCene() << " zł." << endl;

    return 0;
}
