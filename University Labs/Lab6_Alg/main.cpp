#include <iostream>

using namespace std;

#define ASCII_MAX 256

void boyerMoore(string text, string pattern);
void buildBadCharacterTable(string pattern, int badCharacterTable[]);

int main() {
    boyerMoore("ABBBABB", "AB");

    return 0;
}

void buildBadCharacterTable(string pattern, int badCharacterTable[])
{
    // Filling all ASCII array of bad characters with -1
    for (int i = 0; i < ASCII_MAX; ++i) {
        badCharacterTable[i] = -1;
    }

    for (int i = 0; i < pattern.size(); ++i) {
        badCharacterTable[pattern[i]] = i;
    }
}

int max(int a, int b)
{
    return (a > b) ? a : b;
}

void boyerMoore(string text, string pattern)
{
    int textSize = text.size();
    int patternSize = pattern.size();

    int badCharacterTable[ASCII_MAX];
    buildBadCharacterTable(pattern, badCharacterTable);

    for (int i = 0; i <= textSize - patternSize;) {
        int step = patternSize - 1;
        if (step >= 0 && pattern[step] == text[i + step])
        {
            --step;
        }

        if (step == -1)
        {
            cout << "Pattern was found on index: " << i << endl;
            ++i;
        }
        else {
            i += max(1, step - badCharacterTable[text[i + step]]);
        }
    }
}
