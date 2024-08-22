#ifndef LAB_11_ALG_CIRCULAR_SINGLE_LIST_H
#define LAB_11_ALG_CIRCULAR_SINGLE_LIST_H

#include <iostream>
#include "element.h"

using namespace std;

template<typename T>
class CircularSingleLinkedList {
public:
    CircularSingleLinkedList() {
        head = nullptr;
        tail = nullptr;
        counter = 0;
    }

    [[nodiscard]] bool isEmpty() const {
        return head == nullptr;
    }

    T getTopElement() const {
        if (head == nullptr) {
            cerr << "Lista jest pusta." << endl;
            return T();
        }

        return head->getValue();
    }

    T getLastElement() const {
        if (tail == nullptr) {
            cerr << "Lista nie ma ostatniego elementu." << endl;
            return T();
        }

        return tail->getValue();
    }

    T countAverage() const {
        if (typeid(T) != typeid(int) &&
            typeid(T) != typeid(double) &&
            typeid(T) != typeid(float) &&
            typeid(T) != typeid(char) &&
            typeid(T) != typeid(long)) {
            cerr << "Błąd typu szablonu do policzenia średniej." << endl;
            return T();
        }

        auto temp = head;
        T sum = 0;
        for (int i = 1; i < counter; ++i) {
            sum += temp->getValue();
            temp = temp->getNext();
        }

        return sum / counter;
    }

    T max(int* index = nullptr) const {
        if (typeid(T) != typeid(int) &&
            typeid(T) != typeid(double) &&
            typeid(T) != typeid(float) &&
            typeid(T) != typeid(char) &&
            typeid(T) != typeid(long)) {
            cerr << "Błąd typu szablonu do policzenia średniej." << endl;
            return T();
        }

        auto temp = head;
        T max = 0;
        int localIndex = 0;
        for (int i = 1; i < counter; ++i) {
            T value = temp->getValue();
            if (max < value) {
                max = value;
                localIndex = i;
            }
            temp = temp->getNext();
        }

        index = &localIndex;
        return max;
    }

    void AddH(T value);
    void AddT(T value);
    void Insert(T value, int index);
    T DeleteH();
    T DeleteT();
    T DeleteByIndex(int index);
    void ToString();

    ~CircularSingleLinkedList() {
        if (head != nullptr) {
            auto current = head;
            Element<T>* temp = nullptr;
            do {
                temp = current;
                current = current->getNext();
                delete temp;
            } while (current != head);
        }
    }

private:
    Element<T> *head;
    Element<T> *tail;
    int counter;
};

template<typename T>
void CircularSingleLinkedList<T>::ToString() {
    if (head == nullptr) {
        cerr << "List jest pusty." << endl;
        return;
    }

    auto temp = head;
    cout << "[ ";
    while (temp->getNext() != head) {
        cout << temp->getValue() << ", ";
        temp = temp->getNext();
    }

    cout << temp->getValue() << " ]" << endl;
}

template<typename T>
T CircularSingleLinkedList<T>::DeleteByIndex(int index) {
    if (index <= 0) {
        return DeleteH();
    }
    auto temp = head;
    Element<T> *prev = nullptr;
    for (int i = 0; i < index; ++i) {
        if (temp->getNext() == head) {
            cerr << "Indeks jest zły." << endl;
            return T();
        }
        prev = temp;
        temp = temp->getNext();
    }
    prev->setNext(temp->getNext());
    int result = temp->getValue();
    delete temp;
    if (prev->getNext() == head) {
        tail = prev;
    }

    counter--;
    return result;
}

template<typename T>
T CircularSingleLinkedList<T>::DeleteT() {
    if (head == nullptr) {
        cerr << "List jest pusty." << endl;
        return T();
    }

    auto temp = head;
    int result = temp->getValue();
    Element<T> *prev = nullptr;
    while (temp->getNext() != head) {
        prev = temp;
        temp = temp->getNext();
    }
    if (prev == nullptr) {
        delete head;
        head = nullptr;
        tail = nullptr;
    } else {
        prev->setNext(head);
        result = temp->getValue();
        delete temp;
        tail = prev;
    }

    counter--;
    return result;
}

template<typename T>
T CircularSingleLinkedList<T>::DeleteH() {
    if (head == nullptr) {
        cerr << "List jest pusty." << endl;
        return T();
    }

    auto temp = head;
    int result = temp->getValue();
    if (head->getNext() == head) {
        delete head;
        head = nullptr;
        tail = nullptr;
    } else {
        head = head->getNext();
        tail->setNext(head);
        result = temp->getValue();
        delete temp;
    }

    counter--;
    return result;
}

template<typename T>
void CircularSingleLinkedList<T>::Insert(T value, int index) {
    if (index <= 0) {
        AddH(value);
        return;
    }

    auto newElement = new Element<T>(value);
    auto current = head;
    for (int i = 0; i < index - 1; ++i) {
        if (current->getNext() == head) {
            cerr << "Index out of bounds" << endl;
            return;
        }
        current = current->getNext();
    }
    newElement->setNext(current->getNext());
    current->setNext(newElement);
    if (newElement->getNext() == head) {
        tail = newElement;
    }

    counter++;
}

template<typename T>
void CircularSingleLinkedList<T>::AddT(T value) {
    auto newElement = new Element<T>(value);
    if (head == nullptr) {
        head = newElement;
        tail = newElement;
        newElement->setNext(head);
    } else {
        newElement->setNext(head);
        tail->setNext(newElement);
        tail = newElement;
    }

    counter++;
}

template<typename T>
void CircularSingleLinkedList<T>::AddH(T value) {
    auto newElement = new Element<T>(value);
    if (head == nullptr) {
        head = newElement;
        tail = newElement;
        newElement->setNext(head);
    } else {
        newElement->setNext(head);
        head = newElement;
        tail->setNext(newElement);
    }

    counter++;
}

#endif
