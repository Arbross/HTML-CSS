#include <iostream>
#include <string>
#include <cmath>
#include <fstream>

using namespace std;

// !!!
// Mam Algorytm Booyera-Moora w poprzednim laboratorium(Lab 5)

int make_hash(string str, int length);
void rabin_karp(string text, string pattern);

int main() {
    ifstream file("../tekst.txt");

    string text, pattern;
    bool isFirstLine = false;
    while (getline(file, text)) {
        if (!isFirstLine) {
            pattern = text;
            isFirstLine = true;

            continue;
        }

        cout << "----------" << text << "----------" << endl;
        rabin_karp(text, pattern);
    }

    file.close();
    return 0;
}

int make_hash(string str, int length) {
    int hash = 0;
    for (int i = 0; i < length; ++i) {
        hash += (int)str[i] * (int)pow(97, length - i - 1);
    }

    return hash;
}

void rabin_karp(string text, string pattern) {
    int textSize = text.size();
    int patternSize = pattern.size();
    int patternHash = make_hash(pattern, patternSize);
    int textHash = make_hash(text.substr(0, patternSize), patternSize);

    bool isFoundAtLeastOnce = false;
    for (int i = 0; i <= textSize - patternSize; ++i) {
        bool isEqual = true;
        if (textHash == patternHash) {
            for (int j = 0; j < patternSize; ++j) {
                if (text[i + j] != pattern[j]) {
                    isEqual = false;
                    break;
                }
            }

            if (isEqual) {
                cout << "Wzorzec jest równy tekstowi w pozycji - " << i << "." << endl;
                isFoundAtLeastOnce = true;
            }
        }

        if (i < textSize - patternSize) {
            textHash = 97 * (textHash - (int)text[i] * (int)pow(97, patternSize - 1)) + (int)text[i + patternSize];
        }
    }

    if (!isFoundAtLeastOnce) {
        cout << "Wzorzec nie został znaleziony - -1." << endl;
    }
}
