#include <iostream>
#include "BinaryTree.h"

using namespace std;

int main() {
    BinaryTree<int> tree;
    while (true) {
        int choose = 0;
        cout << "1 - Czy drzewo jest puste?" << endl
             << "2 - Dodanie nowego węzla." << endl
             << "3 - Czy istnieje podany klucz w drzewie." << endl
             << "4 - Wyświetlenie drzewa - PreOrder." << endl
             << "5 - Wyświetlenie drzewa - InOrder." << endl
             << "6 - Wyświetlenie drzewa - PostOrder." << endl
             << "7 - Usunięcie węzla za kluczem." << endl
             << "8 - Usunięcie całego drzewa." << endl
             << "9 - Wyjście" << endl;
        cin >> choose;

        switch (choose) {
            case 1: {
                cout << "Czy drzewo jest puste: " << (tree.IsEmpty() ? "tak" : "nie") << endl;
            } break;
            case 2: {
                BinaryTree<int>::InOrder(tree.GetTree());
                cout << endl;

                int value;
                cout << "Wpisz znaczenie: "; cin >> value;
                tree.AddNode(value);

                BinaryTree<int>::InOrder(tree.GetTree());
                cout << endl;
            } break;
            case 3: {
                int value;
                cout << "Wpisz znaczenie: "; cin >> value;
                cout << "Czy element istnieje: " << (tree.Find(value) != nullptr ? "tak" : "nie") << endl;
            } break;
            case 4: {
                BinaryTree<int>::PreOrder(tree.GetTree());
                cout << endl;
            } break;
            case 5: {
                BinaryTree<int>::InOrder(tree.GetTree());
                cout << endl;
            } break;
            case 6: {
                BinaryTree<int>::PostOrder(tree.GetTree());
                cout << endl;
            } break;
            case 7: {
                BinaryTree<int>::InOrder(tree.GetTree());
                cout << endl;

                int value;
                cout << "Wpisz znaczenie: "; cin >> value;
                tree.DeleteNode(tree.Find(value));

                BinaryTree<int>::InOrder(tree.GetTree());
                cout << endl;
            } break;
            case 8: {
                tree.~BinaryTree();
            } break;
            default: return 0;
        }
    }
}
