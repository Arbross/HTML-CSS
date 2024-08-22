#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;

template<class T>
class Element {
public:
    Element() {
        next = nullptr;
    }
    Element(T value, Element *next) {
        this->value = value;
        this->next = next;
    }

    virtual T getValue() const final {
        return this->value;
    }

    virtual Element<T> *getNext() const final {
        return this->next;
    }

    virtual void setNext(Element<T> *next) final {
        this->next = next;
    }

    ~Element() {
        delete this->next;
    }
private:
    T value;
    Element<T> *next;
};

template<class T>
class Stack {
public:
    Stack() {
        storage = nullptr;
    }

    bool static isEmpty(Stack stack) {
        return stack.storage == nullptr;
    }

    T static top(Stack stack) {
        return stack.storage->getValue();
    }

    void push(T value) {
        auto newElement = new Element<T>(value, this->storage);
        storage = newElement;
    }

    T pop() {
        T poppedValue = this->storage->getValue();
        Element<T> *temp = this->storage;
        this->storage = this->storage->getNext();
        temp->setNext(nullptr);
        delete temp;
        return poppedValue;
    }

//    ~Stack() {
//        delete this->storage;
//    }

private:
    Element<T> *storage;
};

string reverse(string str);
string reverseFile(string filename);
void writeToFile(string filename, string text);

int main() {
    // Zadanie 9.2
    writeToFile("wyniki.txt", reverseFile("znaki1.txt"));

    // Zadanie 9.1
    Stack<int> stack{};

    int choose = 0;
    while (true) {
        cout << "1 - Czy jest zbiór pusty" << endl
             << "2 - Dodanie liczby" << endl
             << "3 - Usunięcie elementu" << endl
             << "4 - Pobranie elementu ze stosu" << endl
             << "5 - Zdejmowanie wszystkich elementów ze stosu" << endl
             << "6 - Wyjście" << endl;
        cin >> choose;

        switch (choose) {
            case 1: {
                if (Stack<int>::isEmpty(stack)) {
                    cout << "Stos jest pusty." << endl;
                }
                else {
                    cout << "Stos nie jest pusty." << endl;
                }
            } break;
            case 2: {
                int element = rand() % 10 + 1;
                stack.push(element);
                cout << "Został dodany element - " << element << "." << endl;
            } break;
            case 3: {
                if (Stack<int>::isEmpty(stack)) {
                    cout << "Stos jest pusty." << endl;
                }

                stack.pop();
                cout << "Element został usunięty." << endl;
            } break;
            case 4: {
                cout << "Ostatni element stosu - " << Stack<int>::top(stack) << "." << endl;
            } break;
            case 5: {
                while (Stack<int>::isEmpty(stack)) {
                    stack.pop();
                }

                if (Stack<int>::isEmpty(stack)) {
                    cout << "Elementy zostali usunięte." << endl;
                }
                else {
                    cout << "Error." << endl;
                }
            } break;
            case 6:
                return 0;
            default:
                return 0;
        }
    }
}

string reverse(string str)
{
    Stack<char> stack;
    for (int i = 0; i < str.length(); ++i) {
        stack.push(str[i]);
    }

    string result;
    for (int i = 0; i < str.length(); ++i) {
        result += Stack<char>::top(stack);
        stack.pop();
    }

    return result;
}

string reverseFile(string filename) {
    ifstream file(filename);

    if (!file.is_open()) {
        cerr << "Błąd: Nie udało się otworzyć plik - " << filename << "." << endl;
        return "";
    }

    char symbol;
    string text;
    while (file.get(symbol)) {
        text += symbol;
    }

    file.close();

    return reverse(text);
}

void writeToFile(string filename, string text)
{
    ofstream file(filename);
    file << text;
    file.close();
}
