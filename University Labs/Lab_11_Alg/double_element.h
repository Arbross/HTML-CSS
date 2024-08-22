#ifndef LAB_11_ALG_DOUBLE_ELEMENT_H
#define LAB_11_ALG_DOUBLE_ELEMENT_H

#include "element.h"

template<typename T>
class DoubleElement {
public:
    DoubleElement() = default;
    DoubleElement(DoubleElement<T> *next, DoubleElement<T> *prev, T value) {
        this->next = next;
        this->prev = prev;
        this->value = value;
    }

    DoubleElement(T value) {
        this->next = nullptr;
        this->prev = nullptr;
        this->value = value;
    }

    T getValue() const;

    DoubleElement<T> *getNext() const;
    void setNext(DoubleElement<T> *next);

    DoubleElement<T> *getPrev() const;
    void setPrev(DoubleElement<T> *prev);
private:
    T value;
    DoubleElement<T> *next;
    DoubleElement<T> *prev;
};

template<typename T>
T DoubleElement<T>::getValue() const {
    return value;
}

template<typename T>
void DoubleElement<T>::setNext(DoubleElement<T> *next) {
    this->next = next;
}

template<typename T>
DoubleElement<T> *DoubleElement<T>::getNext() const {
    return this->next;
}

template<typename T>
void DoubleElement<T>::setPrev(DoubleElement<T> *prev) {
    this->prev = prev;
}

template<typename T>
DoubleElement<T> *DoubleElement<T>::getPrev() const {
    return this->prev;
}

#endif
