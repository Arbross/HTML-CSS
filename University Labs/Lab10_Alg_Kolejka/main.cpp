#include <iostream>
#include <cstdlib>
#include <fstream>
#include "queue.h"

using namespace std;

int main() {
    Queue<char> queue{};

    int choose;
    while (true) {
        cout << "1. Czy kolejka jest pusta?" << endl
             << "2. Dodać losowy element do kolejki." << endl
             << "3. Usunięcie elementów kolejki." << endl
             << "4. Pobranie pierwszego elementu z kolejki." << endl
             << "5. Usunięcie wszystkich elementów z kolejki." << endl
             << "6. Wczytywanie danych do kolejki z pliku." << endl
             << "7. Wyjście z programu." << endl;
        cin >> choose;

        switch (choose) {
            case 1: {
                if (Queue<char>::isEmpty(&queue)) {
                    cout << "Kolejka jest pusta." << endl;
                } else {
                    cout << "Kolejka nie jest pusta." << endl;
                }
            }
                break;
            case 2: {
                char randomizedSymbol = (char) (rand() % 255);
                queue.push(randomizedSymbol);
            }
                break;
            case 3: {
                if (Queue<char>::isEmpty(&queue)) {
                    cout << "Kolejka jest pusta, nie da się usunąć elementu." << endl;
                } else {
                    cout << "Element " << queue.pop() << " został usunięty" << endl;
                }
            }
                break;
            case 4: {
                cout << "Pierwszy element kolejki - '" << Queue<char>::first(&queue) << "'." << endl;
            }
                break;
            case 5: {
                while (!Queue<char>::isEmpty(&queue)) {
                    char symbol = queue.pop();
                    cout << "Element kolejki - '" << symbol << "' został usunięty." << endl;
                }
            }
                break;
            case 6: {
                ifstream file("../znaki2.txt");

                if (!file.is_open()) {
                    cerr << "Błąd: Nie udało się otworzyć plik." << endl;
                    return 0;
                }

                char symbol;
                while (file.get(symbol)) {
                    if (symbol >= 65 && symbol <= 90) {
                        queue.push(symbol);
                    }
                }

                file.close();
            }
                break;
            case 7: {
                cout << "Goodbye!" << endl;
                return 0;
            }
            default:
                cerr << "Wprowadzono nieprawidłowe dane." << endl;
                break;
        }
    }

    return 0;
}
