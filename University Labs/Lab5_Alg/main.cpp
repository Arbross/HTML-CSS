#include <iostream>
#include <string>

using namespace std;

void algorytmNaiwny(string text, string temp);
void algorytmKnuthaMorrisaPratta(string text, string pattern);
int *budowanieTablicyDopasowan(string pattern);
void boyerMoore(string text, string pattern);
void buildBadCharacterTable(string pattern, int badCharacterTable[]);

int max(int a, int b);

int main() {
    string text;
    cout << "Enter compared text: ";
    getline(cin, text);

    string pattern;
    cout << "Enter pattern: ";
    getline(cin, pattern);

    if (text.empty() || pattern.empty()) {
        cout << "Entered 'text' or 'pattern' is empty. Nothing to compare." << endl;
        return 0;
    }

    // Algorytm naiwny
    cout << "---Algorytm naiwny---" << endl;
    algorytmNaiwny(text, pattern);

    cout << endl;

    // Algorytm Knutha-Morrisa-Pratta
    cout << "---Algorytm Knutha-Morrisa-Pratta---" << endl;
    algorytmKnuthaMorrisaPratta(text, pattern);

    // Algorytm Boyer'a-Moore'a
    cout << "---Algorytm Boyer'a-Moore'a---" << endl;
    boyerMoore(text, pattern);

    return 0;
}

void algorytmNaiwny(string text, string temp) {
    int j = 0;
    string temporary;
    for (int i = 0; i < text.length() - 1;) {
        if (text[i] == temp[j]) {
            temporary += text[i];
            if (temporary != temp) {
                ++i;
                ++j;
            } else {
                temporary = "";
                cout << "Pattern was successfully found. Here is it start index: " << i - j << endl;
                j = 0;
            }
        } else {
            ++i;
        }
    }
}

int *budowanieTablicyDopasowan(string pattern) {
    int patternLen = pattern.length();
    int *patternArray = new int[patternLen + 1];

    patternArray[0] = -1;
    patternArray[1] = 0;

    int prefixLen = 0;
    int i = 1;

    while (i < patternLen) {
        if (pattern[i] == pattern[prefixLen]) {
            ++prefixLen;
            ++i;
            patternArray[i] = prefixLen;
        } else if (prefixLen > 0) {
            prefixLen = patternArray[prefixLen];
        } else {
            ++i;
            patternArray[i] = 0;
        }
    }

    return patternArray;
}

void algorytmKnuthaMorrisaPratta(string text, string pattern) {
    int t = 0;
    int p = 0;

    int tLen = text.length();
    int pLen = pattern.length();

    int *prefixLen = budowanieTablicyDopasowan(pattern);

    while (t < tLen) {
        if (pattern[p] == text[t]) {
            ++p;
            ++t;

            if (p == pLen) {
                cout << "Pattern was successfully found. Here is it start index: " << t - p << endl;
                p = prefixLen[p];
            }
        } else {
            p = prefixLen[p];
            if (p < 0) {
                ++t;
                ++p;
            }
        }
    }
}

void buildBadCharacterTable(string pattern, int badCharacterTable[]) {
    int m = pattern.size();

    for (int i = 0; i < 256; ++i) {
        badCharacterTable[i] = -1;
    }

    for (int i = 0; i < m; ++i) {
        badCharacterTable[pattern[i]] = i;
    }
}

int max(int a, int b) {
    return (a > b) ? a : b;
}

void boyerMoore(string text, string pattern) {
    int n = text.size();
    int m = pattern.size();
    int badCharacterTable[256];

    buildBadCharacterTable(pattern, badCharacterTable);

    int s = 0;

    while (s <= n - m) {
        int j = m - 1;
        while (j >= 0 && pattern[j] == text[s + j]) {
            --j;
        }
        if (j < 0) {
            cout << "Pattern was successfully found. Here is it start index: " << s << endl;
            if (s + m < n) {
                s += m - badCharacterTable[text[s + m]];
            } else {
                s += 1;
            }
        } else {
            s += max(1, j - badCharacterTable[text[s + j]]);
        }
    }
}
