#include <iostream>
#include "single_list.h"
#include "double_list.h"
#include "circular_single_list.h"
#include "circular_double_list.h"

using namespace std;

int listaJednokierunkowa();
int listaDwukierunkowa();

int main() {
    int listSelection;
    cout << "1. Lista jednokierunkowa" << endl
         << "2. Lista dwukierunkowa" << endl
         << "3. Lista cykiczna jednokierunkowa" << endl
         << "4. Lista cykiczna dwukierunkowa" << endl
         << "5. Wyjście" << endl;
    cin >> listSelection;

    switch (listSelection) {
        case 1: {
            SingleLinkedList<int> list;
            while (true) {
                switch (listaJednokierunkowa()) {
                    case 1: {
                        cout << "Lista jest " << (list.isEmpty() ? "pusta." : "nie pusta.") << endl;
                    } break;
                    case 2: {
                        int value;
                        cout << "Wpisz liczbe: "; cin >> value;
                        list.AddT(value);
                    } break;
                    case 3: {
                        int value;
                        cout << "Wpisz liczbe: "; cin >> value;
                        list.AddH(value);
                    } break;
                    case 4: {
                        int value, index;
                        cout << "Wpisz liczbe: "; cin >> value;
                        cout << "Wpisz pozycję: "; cin >> index;
                        list.Insert(value, index);
                    } break;
                    case 5: {
                        list.DeleteT();
                    } break;
                    case 6: {
                        list.DeleteH();
                    } break;
                    case 7: {
                        int index;
                        cout << "Wpisz pozycję: "; cin >> index;
                        list.DeleteByIndex(index);
                    } break;
                    case 8: {
                        cout << "Pierwszy element listy: " << list.getTopElement() << endl;
                    } break;
                    case 9: {
                        cout << "Ostatni element listy: " << list.getLastElement() << endl;
                    } break;
                    case 10: {
                        cout << "Ostatni element listy: " << list.getLastElement() << endl;
                    } break;
                    case 11: {
                        cout << "Średnia liczba elementów liczby: " << list.countAverage() << endl;
                    } break;
                    case 12: {
                        int *index = nullptr;
                        int max = list.max(index);
                        cout << "Maksymalny element listy: " << max << ". Indeks maksymalnego elementu: " << *index << endl;
                    } break;
                    case 13: {
                        list.ToString();
                    } break;
                    case 14: {
                        list.~SingleLinkedList();
                        cout << "Dane całej listy zostałe usunięte." << endl;
                    } break;
                    case 15: return 0;
                    default: return 0;
                }
            }
        }
        case 2: {
            DoubleLinkedList<int> list;
            while (true) {
                switch (listaDwukierunkowa()) {
                    case 1: {
                        cout << "Lista jest " << (list.isEmpty() ? "pusta." : "nie pusta.") << endl;
                    } break;
                    case 2: {
                        int value;
                        cout << "Wpisz liczbe: "; cin >> value;
                        list.AddT(value);
                    } break;
                    case 3: {
                        int value;
                        cout << "Wpisz liczbe: "; cin >> value;
                        list.AddH(value);
                    } break;
                    case 4: {
                        int value, index;
                        cout << "Wpisz liczbe: "; cin >> value;
                        cout << "Wpisz pozycję: "; cin >> index;
                        list.Insert(value, index);
                    } break;
                    case 5: {
                        list.DeleteT();
                    } break;
                    case 6: {
                        list.DeleteH();
                    } break;
                    case 7: {
                        int index;
                        cout << "Wpisz pozycję: "; cin >> index;
                        list.DeleteByIndex(index);
                    } break;
                    case 8: {
                        list.ToStringForward();
                    } break;
                    case 9: {
                        list.ToStringBackward();
                    } break;
                    case 10: {
                        int *index = nullptr;
                        int min = list.min(index);
                        cout << "Minimalny element listy: " << min << ". Indeks minimalny elementu: " << *index << endl;
                    } break;
                    case 11: {
                        list.~DoubleLinkedList();
                        cout << "Dane całej listy zostałe usunięte." << endl;
                    } break;
                    case 12: return 0;
                    default: return 0;
                }
            }
        }
        case 3: {
            CircularSingleLinkedList<int> list;
            while (true) {
                switch (listaJednokierunkowa()) {
                    case 1: {
                        cout << "Lista jest " << (list.isEmpty() ? "pusta." : "nie pusta.") << endl;
                    } break;
                    case 2: {
                        int value;
                        cout << "Wpisz liczbe: "; cin >> value;
                        list.AddT(value);
                    } break;
                    case 3: {
                        int value;
                        cout << "Wpisz liczbe: "; cin >> value;
                        list.AddH(value);
                    } break;
                    case 4: {
                        int value, index;
                        cout << "Wpisz liczbe: "; cin >> value;
                        cout << "Wpisz pozycję: "; cin >> index;
                        list.Insert(value, index);
                    } break;
                    case 5: {
                        list.DeleteT();
                    } break;
                    case 6: {
                        list.DeleteH();
                    } break;
                    case 7: {
                        int index;
                        cout << "Wpisz pozycję: "; cin >> index;
                        list.DeleteByIndex(index);
                    } break;
                    case 8: {
                        cout << "Pierwszy element listy: " << list.getTopElement() << endl;
                    } break;
                    case 9: {
                        cout << "Ostatni element listy: " << list.getLastElement() << endl;
                    } break;
                    case 10: {
                        cout << "Ostatni element listy: " << list.getLastElement() << endl;
                    } break;
                    case 11: {
                        cout << "Średnia liczba elementów liczby: " << list.countAverage() << endl;
                    } break;
                    case 12: {
                        int *index = nullptr;
                        int max = list.max(index);
                        cout << "Maksymalny element listy: " << max << ". Indeks maksymalnego elementu: " << *index << endl;
                    } break;
                    case 13: {
                        list.ToString();
                    } break;
                    case 14: {
                        list.~CircularSingleLinkedList();
                        cout << "Dane całej listy zostałe usunięte." << endl;
                    } break;
                    case 15: return 0;
                    default: return 0;
                }
            }
        }
        case 4: {
            CircularDoubleLinkedList<int> list;
            while (true) {
                switch (listaDwukierunkowa()) {
                    case 1: {
                        cout << "Lista jest " << (list.isEmpty() ? "pusta." : "nie pusta.") << endl;
                    } break;
                    case 2: {
                        int value;
                        cout << "Wpisz liczbe: "; cin >> value;
                        list.AddT(value);
                    } break;
                    case 3: {
                        int value;
                        cout << "Wpisz liczbe: "; cin >> value;
                        list.AddH(value);
                    } break;
                    case 4: {
                        int value, index;
                        cout << "Wpisz liczbe: "; cin >> value;
                        cout << "Wpisz pozycję: "; cin >> index;
                        list.Insert(value, index);
                    } break;
                    case 5: {
                        list.DeleteT();
                    } break;
                    case 6: {
                        list.DeleteH();
                    } break;
                    case 7: {
                        int index;
                        cout << "Wpisz pozycję: "; cin >> index;
                        list.DeleteByIndex(index);
                    } break;
                    case 8: {
                        list.ToStringForward();
                    } break;
                    case 9: {
                        list.ToStringBackward();
                    } break;
                    case 10: {
                        int *index = nullptr;
                        int min = list.min(index);
                        cout << "Minimalny element listy: " << min << ". Indeks minimalnego elementu: " << *index << endl;
                    } break;
                    case 11: {
                        list.~CircularDoubleLinkedList();
                        cout << "Dane całej listy zostałe usunięte." << endl;
                    } break;
                    case 12: return 0;
                    default: return 0;
                }
            }
        }
        case 5: {
            return 0;
        }
        default: return 0;
    }
}

int listaJednokierunkowa() {
    int operationSelection;
    cout << "1. Czy lista jest pusta?" << endl
         << "2. Dodanie elementu na koniec listy." << endl
         << "3. Dodanie elementu na początek listy." << endl
         << "4. Dodanie elementu na określoną pozycję." << endl
         << "5. Usunięcie elementu z końca listy." << endl
         << "6. Usunięcie elementu z początku listy." << endl
         << "7. Usunięcie elementu znajdującego się na określonej pozycji." << endl
         << "8. Pobranie pierwszego elementu z listy." << endl
         << "9. Pobranie ostatniego elementu z listy." << endl
         << "10. Wyświetlenie ostatniego elementu." << endl
         << "11. Policzenie średniej arytmetycznej elementów w liście." << endl
         << "12. Znalezienie elementu maksymalnego w liście." << endl
         << "13. Wyświetlenie całej listy." << endl
         << "14. Usunięcie całej listy wraz ze zwolnieniem pamięci." << endl
         << "15. Wyjście z programu." << endl;
    cin >> operationSelection;
    return operationSelection;
}

int listaDwukierunkowa() {
    int operationSelection;
    cout << "1. Czy lista jest pusta?" << endl
         << "2. Dodanie elementu na koniec listy." << endl
         << "3. Dodanie elementu na początek listy." << endl
         << "4. Dodanie elementu na określoną pozycję." << endl
         << "5. Usunięcie elementu z końca listy." << endl
         << "6. Usunięcie elementu z początku listy." << endl
         << "7. Usunięcie elementu znajdującego się na określonej pozycji." << endl
         << "8. Wyświetlenie elementów od początku do końca." << endl
         << "9. Wyświetlenie elementów od końca do początku." << endl
         << "10. Znalezienie elementu minimalnego w liście." << endl
         << "11. Usunięcie całej listy wraz ze zwolnieniem pamięci." << endl
         << "12. Wyjście z programu." << endl;
    cin >> operationSelection;
    return operationSelection;
}
