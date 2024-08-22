#include <iostream>

using namespace std;

int main() {
//#ifdef 0
//    int n;
//    cout << "Podaj liczbe elementów: ";
//    cin >> n;
//
//    while (n <= 0)
//    {
//        cout << "Podaj poprawną liczbę elementów: ";
//        cin >> n;
//    }
//
//    int s = 0, sn = 0, ln = 0, i = 0;
//    float sr = 0, srn = 0;
//    while(i < n)
//    {
//        cout << "Podaj " << i + 1 << " liczbę";
//        int liczba;
//        cin >> liczba;
//
//        s += liczba;
//        if (liczba % 2 == 1)
//        {
//            sn += liczba;
//            ln += 1;
//        }
//
//        i++;
//    }
//
//    sr = (float)(s / n);
//    cout << "Średnia arytm. wszystkich: " << sr << endl;
//    if (ln == 0)
//    {
//        cout << "Brak liczb nieparzystych." << endl;
//    }
//    else {
//        srn = sn / ln;
//        cout << "Średnia liczb nieparzystych: " << srn << endl;
//    }
//
//    lp = n - ln;
//    if (lp == 0)
//    {
//        cout << "Brak liczb nieparzystych." << endl;
//    }
//    else {
//        cout << "Liczba parzystych jest " << ln << "." << endl;
//    }
//#endif

    int original_array = [ 3, 7, 3, 0, 7, -1, 3, 7, 3, 2 ];
    int size = sizeof(original_array) / sizeof(int);

    int w[size] = { 0 };, nw[size] = { 0 };

    for (int i = 0; i < size; ++i) {
        bool isUnique = false;
        for (int j = 0; j < size; ++j) {
            if (w[j] == original_array[i])
            {
                nw[i]++;
                isUnique = false;
            }
            else {
                isUnique = true;
            }
        }

        nw[i] = original_array[i];
    }

    for (int i = 0; i < size; ++i) {
        cout << nw[i] << " ";
    }
    cout << endl;
    cout << endl;

    for (int i = 0; i < size; ++i) {
        cout << i << ". " << w[i];
    }
    cout << endl;

    return 0;
}
