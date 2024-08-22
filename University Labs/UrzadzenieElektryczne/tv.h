//
// Created by victor on 09.04.2024.
//

#ifndef URZADZENIEELEKTRYCZNE_TV_H
#define URZADZENIEELEKTRYCZNE_TV_H

#include <iostream>
#include "urzadzenie_elektryczne.h"

using namespace std;

class TV : public UrzadzenieElektryczne {
private:
    int kanal;
    int glosnosc;
public:
    TV(string marka);
    void podglosnij();
    void scisz();
    void zmienKanal(int kanal);
    void wypisz();
};


#endif //URZADZENIEELEKTRYCZNE_TV_H
