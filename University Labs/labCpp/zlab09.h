//
// Created by victor on 24.04.2024.
//

#ifndef LABCPP_ZLAB09_H
#define LABCPP_ZLAB09_H


#include <iostream>

using namespace std;

class ZLab09 {
public:
    int *wskInt1D = nullptr;
    int **wskInt2D = nullptr;

    void rozmiary();
    void tablica1D();
    void tablica2D(int w, int k);
    void referencja();
    void skalar();
};


#endif //LABCPP_ZLAB09_H
