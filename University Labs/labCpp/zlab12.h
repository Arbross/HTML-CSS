#ifndef LABCPP_ZLAB12_H
#define LABCPP_ZLAB12_H


#include <string>

class ZLab12 {

public:
    void strumienTekstowy();
    void zapisTekstowyDoPliku(std::string nazwaPliku);
    void odczytPlikuTekstowego(std::string nazwaPliku);
    void zapisBinarnyDoPliku(std::string nazwaPliku);
    void odczytPlikuBinarnego(std::string nazwaPliku);
};


#endif
