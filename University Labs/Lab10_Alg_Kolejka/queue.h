//
// Created by Arbross on 25.04.2024.
//

#ifndef LAB10_ALG_KOLEJKA_QUEUE_H
#define LAB10_ALG_KOLEJKA_QUEUE_H

template<class T>
class Element {
public:
    Element() {
        next = nullptr;
    }
    Element(T value, Element *next);

    virtual T getValue() const final;

    virtual Element<T> *getNext() const final;
    virtual void setNext(Element<T> *next) final;

    ~Element() {
        delete this->next;
    }
private:
    T value;
    Element<T> *next;
};

template<class T>
class Queue {
public:
    Queue() = default;

    bool static isEmpty(Queue<T> *queue);
    char static first(Queue<T> *queue);

    void push(T value);
    T pop();

    ~Queue();

private:
    Element<T> *head;
    Element<T> *tail;
};

// Element Class

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

// Queue Class

template<typename T>
bool Queue<T>::isEmpty(Queue<T> *queue) {
    return queue->head == nullptr;
}

template<typename T>
char Queue<T>::first(Queue<T> *queue) {
    return queue->head->getValue();
}

template<typename T>
void Queue<T>::push(T value) {
    auto newElement = new Element<T>(value, nullptr);

    if (this->tail != nullptr) {
        this->tail->setNext(newElement);
    }
    else {
        this->head = newElement;
    }

    this->tail = newElement;
}

template<typename T>
T Queue<T>::pop() {
    Element<T> *temp = this->head;
    auto deletedElement = temp->getValue();
    this->head = this->head->getNext();
    temp->setNext(nullptr);
    delete temp;

    if (this->head == nullptr) {
        this->tail = nullptr;
    }

    return deletedElement;
}

template<typename T>
Queue<T>::~Queue() {
    delete this->head;
    delete this->tail;
}


#endif //LAB10_ALG_KOLEJKA_QUEUE_H
