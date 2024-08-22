#ifndef LAB_11_ALG_DOUBLE_LIST_H
#define LAB_11_ALG_DOUBLE_LIST_H

#include <iostream>
#include "double_element.h"

using namespace std;

template<typename T>
class DoubleLinkedList {
public:
    DoubleLinkedList() {
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

    ~DoubleLinkedList() {
        auto current = this->head;
        while (current != nullptr) {
            auto next = current->getNext();
            delete current;
            current = next;
        }
        this->head = this->tail = nullptr;
    }
private:
    DoubleElement<T> *head;
    DoubleElement<T> *tail;
    int counter;
};

template<typename T>
void DoubleLinkedList<T>::ToStringBackward() {
    if (head == nullptr) {
        cerr << "List jest pusty." << endl;
        return;
    }

    auto temp = head;
    cout << "[ ";
    while (temp->getNext() != nullptr) {
        cout << temp->getValue() << ", ";
        temp = temp->getNext();
    }
    cout << temp->getValue() << " ]" << endl;
}

template<typename T>
void DoubleLinkedList<T>::ToStringForward() {
    if (head == nullptr) {
        cerr << "List jest pusty." << endl;
        return;
    }

    auto temp = tail;
    cout << "[ ";
    while (temp->getPrev() != nullptr) {
        cout << temp->getValue() << ", ";
        temp = temp->getPrev();
    }
    cout << temp->getValue() << " ]" << endl;
}

template<typename T>
T DoubleLinkedList<T>::DeleteByIndex(int index) {
    if (index <= 0) {
        return DeleteH();
    }

    auto current = head;
    for (int i = 0; i < index - 1; ++i) {
        current = current->getNext();
    }

    int result;
    if (current != nullptr) {
        if (current->getPrev() != nullptr) {
            current->getPrev()->setNext(current->getNext());
        } else {
            head = current->getNext();
        }

        if (current->getNext() != nullptr) {
            current->getNext()->setPrev(current->getPrev());
        } else {
            tail = current->getPrev();
        }

        result = current->getValue();
        delete current;
    }

    counter--;
    return result;
}

template<typename T>
T DoubleLinkedList<T>::DeleteT() {
    int result;
    if (tail != nullptr) {
        auto temp = tail;
        tail = tail->getPrev();
        if (tail != nullptr) {
            tail->setNext(nullptr);
        } else {
            head = nullptr;
        }
        result = temp->getValue();
        delete temp;
    }

    counter--;
    return result;
}

template<typename T>
T DoubleLinkedList<T>::DeleteH() {
    int result;
    if (head != nullptr) {
        auto temp = head;
        head = head->getNext();
        if (head != nullptr) {
            head->setPrev(nullptr);
        } else {
            tail = nullptr;
        }
        result = temp->getValue();
        delete temp;
    }

    counter--;
    return result;
}

template<typename T>
void DoubleLinkedList<T>::Insert(T value, int index) {
    if (index <= 0) {
        AddH(value);
        return;
    }

    auto newElement = new DoubleElement<T>(value);
    auto current = head;
    for (int i = 0; i < index - 1; ++i) {
        current = current->getNext();
    }

    if (current != nullptr) {
        newElement->setNext(current);
        newElement->setPrev(current->getPrev());
        if (current->getPrev() != nullptr) {
            current->getPrev()->setNext(newElement);
        } else {
            head = newElement;
        }
        current->setPrev(newElement);
    } else {
        AddT(value);
    }

    counter++;
}

template<typename T>
void DoubleLinkedList<T>::AddT(T value) {
    auto newElement = new DoubleElement<T>(nullptr, tail, value);
    if (tail != nullptr) {
        tail->setNext(newElement);
    } else {
        head = newElement;
    }

    tail = newElement;
    counter++;
}

template<typename T>
void DoubleLinkedList<T>::AddH(T value) {
    auto newElement = new DoubleElement<T>(head, nullptr, value);
    if (head != nullptr) {
        head->setPrev(newElement);
    } else {
        tail = newElement;
    }

    head = newElement;
    counter++;
}

#endif
