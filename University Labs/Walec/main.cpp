#include <iostream>
#include "bryla.h"

using namespace std;

int main() {
    Walec bryla1(23.3, 54.3);
    Walec bryla2(433.3, 234.3);

    cout << "Pole: " << bryla1.obliczPolePowirzchni() << endl;
    cout << "Nazwa: " << bryla2.kimJestes() << endl;
    cout << "Porównanie: " << (bryla2 < bryla1 ? "true" : "false") << endl;
    cout << bryla1 << endl;
    cout << bryla2 << endl;

    return 0;
}
