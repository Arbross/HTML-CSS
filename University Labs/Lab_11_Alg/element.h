#ifndef LAB_11_ALG_ELEMENT_H
#define LAB_11_ALG_ELEMENT_H


template<class T>
class Element {
public:
    Element() {
        next = nullptr;
    }

    Element(T value, Element *next);
    Element(T value);

    T getValue() const;
    Element<T> *getNext() const;
    void setNext(Element<T> *next);
private:
    T value;
    Element<T> *next;
};

template<class T>
Element<T>::Element(T value) {
    this->value = value;
    this->next = nullptr;
}

template<typename T>
Element<T>::Element(T value, Element<T> *next) {
    this->value = value;
    this->next = next;
}

template<typename T>
T Element<T>::getValue() const {
    return this->value;
}

template<typename T>
Element<T> *Element<T>::getNext() const {
    return this->next;
}

template<typename T>
void Element<T>::setNext(Element<T> *next) {
    this->next = next;
}


#endif
