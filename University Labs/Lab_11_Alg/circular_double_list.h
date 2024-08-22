#ifndef LAB_11_ALG_CIRCULAR_DOUBLE_LIST_H
#define LAB_11_ALG_CIRCULAR_DOUBLE_LIST_H

#include <iostream>
#include "double_element.h"

using namespace std;

template<typename T>
class CircularDoubleLinkedList {
public:
    CircularDoubleLinkedList() {
        head = nullptr;
        tail = nullptr;
        counter = 0;
    }

    [[nodiscard]] bool isEmpty() const {
        return head == nullptr;
    }

    T min(int* index = nullptr) {
        if (typeid(T) != typeid(int) &&
            typeid(T) != typeid(double) &&
            typeid(T) != typeid(float) &&
            typeid(T) != typeid(char) &&
            typeid(T) != typeid(long)) {
            cerr << "Błąd typu szablonu do policzenia średniej." << endl;
            return T();
        }

        auto temp = head;
        T min = 0;
        int localIndex = 0;
        for (int i = 1; i < counter; ++i) {
            T value = temp->getValue();
            if (min > value) {
                min = value;
                localIndex = i;
            }
            temp = temp->getNext();
        }

        index = &localIndex;
        return min;
    }

    void AddH(T value);
    void AddT(T value);
    void Insert(T value, int index);
    T DeleteH();
    T DeleteT();
    T DeleteByIndex(int index);
    void ToStringForward();
    void ToStringBackward();

    ~CircularDoubleLinkedList() {
        if (head != nullptr) {
            auto current = head;
            DoubleElement<T>* temp;
            do {
                temp = current;
                current = current->getNext();
                delete temp;
            } while (current != head);
        }
    }
private:
    DoubleElement<T> *head;
    DoubleElement<T> *tail;
    int counter;
};

template<typename T>
void CircularDoubleLinkedList<T>::AddH(T value) {
    auto newElement = new DoubleElement<T>(value);
    if (head != nullptr) {
        newElement->setNext(head);
        newElement->setPrev(tail);
        tail->setNext(newElement);
        head->setPrev(newElement);
        head = newElement;
    } else {
        head = newElement;
        tail = newElement;
        head->setNext(head);
        head->setPrev(head);
    }

    counter++;
}

template<typename T>
void CircularDoubleLinkedList<T>::AddT(T value) {
    auto newElement = new DoubleElement<T>(head, nullptr, value);
    if (tail != nullptr) {
        newElement->setPrev(tail);
        tail->setNext(newElement);
        head->setPrev(newElement);
        tail = newElement;
    } else {
        head = newElement;
        tail = newElement;
        head->setNext(head);
        head->setPrev(head);
    }

    counter++;
}

template<typename T>
void CircularDoubleLinkedList<T>::Insert(T value, int index) {
    if (index <= 0) {
        AddH(value);
        return;
    }

    auto newElement = new DoubleElement<T>(value);
    auto temp = head;
    for (int i = 0; i < index - 1; ++i) {
        if (temp->getNext() == head) {
            cerr << "Index jest zły." << endl;
            return;
        }

        temp = temp->getNext();
    }

    newElement->setPrev(temp);
    newElement->setNext(temp->getNext());
    temp->getNext()->setPrev(newElement);
    temp->setNext(newElement);
    if (newElement->getNext() == head) {
        tail = newElement;
    }

    counter++;
}

template<typename T>
T CircularDoubleLinkedList<T>::DeleteH() {
    if (head == nullptr) {
        cerr << "List jest pusty." << endl;
        return T();
    }

    int result = head->getValue();
    if (head->getNext() == head) {
        delete head;
        head = nullptr;
        tail = nullptr;
        counter--;
        return result;
    }

    auto temp = head;
    head = head->getNext();
    head->setPrev(tail);
    tail->setNext(head);
    delete temp;

    counter--;
    return result;
}

template<typename T>
T CircularDoubleLinkedList<T>::DeleteT() {
    if (head == nullptr) {
        cerr << "List jest pusty." << endl;
        return T();
    }

    int result = head->getValue();
    if (head->getNext() == head) {
        delete head;
        head = nullptr;
        tail = nullptr;
        counter--;
        return result;
    }

    auto temp = tail;
    tail = tail->getPrev();
    tail->setNext(head);
    head->setPrev(tail);
    result = temp->getValue();
    delete temp;

    counter--;
    return result;
}

template<typename T>
T CircularDoubleLinkedList<T>::DeleteByIndex(int index) {
    if (index <= 0) {
        return DeleteH();
    }

    auto temp = head;
    for (int i = 0; i < index; ++i) {
        if (temp->getNext() == head) {
            cerr << "Indeks jest zły." << endl;
            return T();
        }
        temp = temp->getNext();
    }
    temp->getPrev()->setNext(temp->getNext());
    temp->getNext()->setPrev(temp->getPrev());
    int result = temp->getValue();
    delete temp;
    if (temp->getNext() == head) {
        tail = temp->getPrev();
    }

    counter--;
    return result;
}

template<typename T>
void CircularDoubleLinkedList<T>::ToStringForward() {
    if (head == nullptr) {
        cerr << "List jest pusty." << endl;
        return;
    }

    auto temp = head;
    cout << "[ ";
    for (int i = 1; i < counter; ++i) {
        cout << temp->getValue() << ", ";
        temp = temp->getNext();
    }
    cout << temp->getValue() << " ]" << endl;
}

template<typename T>
void CircularDoubleLinkedList<T>::ToStringBackward() {
    if (head == nullptr) {
        cerr << "List jest pusty." << endl;
        return;
    }

    auto temp = tail;
    cout << "[ ";
    for (int i = 1; i < counter; ++i) {
        cout << temp->getValue() << ", ";
        temp = temp->getPrev();
    }
    cout << temp->getValue() << " ]" << endl;
}

#endif
