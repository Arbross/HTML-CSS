//
// Created by victor on 10.04.2024.
//

#ifndef LABCPP_OSOBNIKI_H
#define LABCPP_OSOBNIKI_H

#include <iostream>
#include "organizm.h"
#include "mieszkaniec.h"

using namespace std;

class Glon : protected Organizm, public Mieszkaniec {
public:
    Glon();

    virtual RodzajMieszkanca kimJestes() final;

    virtual ZamiarMieszkanca
    wybierzAkcje(Sasiedztwo sasiedztwo);

    virtual Mieszkaniec *dajPotomka();

    virtual void przyjmijZdobycz
            (Mieszkaniec *mieszkaniec);
};


class Grzyb : protected Organizm, public Mieszkaniec {
public:
    Grzyb();

    virtual RodzajMieszkanca kimJestes() final;

    virtual ZamiarMieszkanca
    wybierzAkcje(Sasiedztwo sasiedztwo);

    virtual Mieszkaniec *dajPotomka();

    virtual void przyjmijZdobycz
            (Mieszkaniec *mieszkaniec);
};

class Bakteria : protected Organizm, public Mieszkaniec {
public:
    Bakteria();

    virtual RodzajMieszkanca kimJestes() final;

    virtual ZamiarMieszkanca
    wybierzAkcje(Sasiedztwo sasiedztwo);

    virtual Mieszkaniec *dajPotomka();

    virtual void przyjmijZdobycz
            (Mieszkaniec *mieszkaniec);
};


#endif //LABCPP_OSOBNIKI_H
