#ifndef LAB_11_ALG_SINGLE_LIST_H
#define LAB_11_ALG_SINGLE_LIST_H

#include <iostream>
#include "element.h"

using namespace std;

template<typename T>
class SingleLinkedList {
public:
    SingleLinkedList() {
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

    ~SingleLinkedList() {
        auto current = this->head;
        while (current != nullptr) {
            auto next = current->getNext();
            delete current;
            current = next;
        }
        this->head = this->tail = nullptr;
    }
private:
    Element<T> *head;
    Element<T> *tail;
    int counter;
};

template<typename T>
void SingleLinkedList<T>::ToString() {
    auto temp = head;
    cout << "[ ";
    for (int i = 1; i < counter; ++i) {
        cout << temp->getValue() << ", ";
        temp = temp->getNext();
    }
    cout << temp->getValue() << " ]" << endl;
}

template<typename T>
T SingleLinkedList<T>::DeleteByIndex(int index) {
    if (this->head == nullptr) {
        cerr << "List jest pusty." << endl;
        return T();
    }

    if (index == 0) {
        auto temp = this->head;
        this->head = this->head->getNext();
        delete temp;
        return T();
    }

    auto previous = this->head;
    for (int i = 0; i < index - 1; ++i) {
        previous = previous->getNext();
    }

    auto temp = previous->getNext();
    int result = temp->getValue();
    previous->setNext(temp->getNext());
    delete temp;

    counter--;
    return result;
}

template<typename T>
T SingleLinkedList<T>::DeleteT() {
    if (this->head == nullptr) {
        cerr << "List jest pusty." << endl;
        return T();
    }

    if (tail == nullptr) {
        delete head;
        return T();
    }

    auto temp = head;
    for (int i = 1; i < counter - 1; ++i) {
        temp = temp->getNext();
    }
    int result = temp->getValue();
    delete temp->getNext();
    temp->setNext(nullptr);

    counter--;
    return result;
}

template<typename T>
T SingleLinkedList<T>::DeleteH() {
    if (head == nullptr) {
        cerr << "List jest pusty." << endl;
        return T();
    }

    auto temp = head;
    int result = temp->getValue();
    head = head->getNext();
    delete temp;

    counter--;
    return result;
}

template<typename T>
void SingleLinkedList<T>::Insert(T value, int index) {
    if (index == 0) {
        AddH(value);
        return;
    }

    auto newElement = new Element<T>(value, nullptr);
    auto temp = this->head;
    for (int i = 0; i < index - 1; ++i) {
        temp = temp->getNext();
    }
    newElement->setNext(temp->getNext());
    temp->setNext(newElement);

    if (newElement->getNext() == nullptr) {
        tail = newElement;
    }

    counter++;
}

template<typename T>
void SingleLinkedList<T>::AddT(T value) {
    auto newElement = new Element<T>(value, nullptr);
    if (head == nullptr) {
        head = tail = newElement;
    } else {
        tail->setNext(newElement);
        tail = newElement;
    }

    counter++;
}

template<typename T>
void SingleLinkedList<T>::AddH(T value) {
    auto newElement = new Element<T>(value, nullptr);
    if (head == nullptr) {
        head = tail = newElement;
    } else {
        newElement->setNext(head);
        head = newElement;
    }

    counter++;
}


#endif
