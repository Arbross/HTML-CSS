//
// Created by victor on 27.03.2024.
//

#ifndef LABCPP_ZLAB06_H
#define LABCPP_ZLAB06_H


class Obliczenia {
protected:
    const double pi = 3.14;
public:
    virtual double promienKolaWgPola() = 0; // że nie będzie mieć kodu do napisania (dla metod virtualnych/abstraktnych)
    virtual double promienOkreguWgObwodu() = 0;

    virtual ~Obliczenia();
};


#endif //LABCPP_ZLAB06_H
