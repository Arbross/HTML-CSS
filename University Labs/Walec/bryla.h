#ifndef WALEC_BRYLA_H
#define WALEC_BRYLA_H


#include <iostream>
#include <math.h>

using namespace std;

class Bryla {
public:
    Bryla(string name = "?") {
        this->name = name;
    }

    virtual double obliczPolePowirzchni() const = 0;
    const string& kimJestes() const {
        return name;
    }

private:
    string name;
};

class Walec : public Bryla {
public:
    Walec(double r = 0, double h = 0, string name = "Walec")
        : Bryla(name) {
        if (r < 0) {
            this->r = 0;
        }
        if (h < 0) {
            this->h = 0;
        }

        this->r = r;
        this->h = h;
    }

    double obliczPolePowirzchni() const override {
        if (h < 0 || r < 0) {
            return 0;
        }

        return 2 * M_PI * r * h + 2 * M_PI * pow(r, 2);
    }

    friend ostream& operator <<(ostream& os, const Walec& obj);
private:
    double r, h;
};

bool operator <(const Walec& obj1, const Walec& obj2) {
    return obj1.obliczPolePowirzchni() < obj2.obliczPolePowirzchni();
}

ostream& operator <<(ostream& os, const Walec& obj) {
    os << "Walec " << obj.kimJestes() << " o promieniu r = " << obj.r << " i wysokości h = " << obj.h;
    return os;
}

#endif
