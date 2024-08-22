#ifndef LAB12_ALG_BINARYTREE_H
#define LAB12_ALG_BINARYTREE_H


#include <iostream>
using namespace std;

template<typename T>
struct Node {
    T key;
    Node* parent;
    Node* left;
    Node* right;
};

template<typename T>
class BinaryTree {
public:
    void AddNode(T value);
    void DeleteNode(Node<T>* delete_node);

    void static PreOrder(Node<T>* root);
    void static PostOrder(Node<T>* root);
    void static InOrder(Node<T>* root);

    Node<T>* Find(T value);

    [[nodiscard]] bool IsEmpty() const {
        return tree == nullptr;
    }

    Node<T>* GetTree() {
        return tree;
    }

    ~BinaryTree() {
        deleteTree(tree);
        tree = nullptr;
    }
private:
    Node<T>* tree = nullptr;

    Node<T>* makeNode(T value) {
        auto node = new Node<T>();
        node->key = value;
        node->parent = nullptr;
        node->left = nullptr;
        node->right = nullptr;
        return node;
    }
    Node<T>* FindSuccessor(Node<T>* node) const;

    void deleteTree(Node<T>* node) {
        if (node != nullptr) {
            deleteTree(node->left);
            deleteTree(node->right);
            delete node;
        }
    }
};

template<typename T>
void BinaryTree<T>::DeleteNode(Node<T> *delete_node) {
    if (delete_node == nullptr) {
        return;
    }

    if (delete_node->left == nullptr && delete_node->right == nullptr) {
        if (delete_node->parent != nullptr) {
            if (delete_node->parent->left == delete_node) {
                delete_node->parent->left = nullptr;
            } else {
                delete_node->parent->right = nullptr;
            }
        } else {
            tree = nullptr;
        }
        delete delete_node;
    }
    else if (delete_node->left == nullptr || delete_node->right == nullptr) {
        Node<T>* child = (delete_node->left != nullptr) ? delete_node->left : delete_node->right;

        if (delete_node->parent != nullptr) {
            if (delete_node->parent->left == delete_node) {
                delete_node->parent->left = child;
            } else {
                delete_node->parent->right = child;
            }
        } else {
            tree = child;
        }
        child->parent = delete_node->parent;
        delete delete_node;
    }
    else {
        Node<T>* successor = FindSuccessor(delete_node);
        delete_node->key = successor->key;
        DeleteNode(successor);
    }
}

template<typename T>
Node<T> *BinaryTree<T>::FindSuccessor(Node<T>* node) const {
    if (node->right != nullptr) {
        node = node->right;
        while (node->left != nullptr) {
            node = node->left;
        }
        return node;
    }

    auto temp = node->parent;
    while (temp != nullptr && temp->left != node) {
        node = temp;
        temp = temp->parent;
    }

    return temp;
}

template<typename T>
Node<T>* BinaryTree<T>::Find(T value) {
    auto tempTree = tree;
    while (tempTree != nullptr) {
        if (tempTree->key == value) {
            return tempTree;
        }

        if (value > tempTree->key) {
            tempTree = tempTree->right;
        }
        else {
            tempTree = tempTree->left;
        }
    }

    return nullptr;
}

template<typename T>
void BinaryTree<T>::InOrder(Node<T>* root) {
    if (root != nullptr) {
        BinaryTree::InOrder(root->left);
        cout << root->key << " ";
        BinaryTree::InOrder(root->right);
    }
}

template<typename T>
void BinaryTree<T>::PostOrder(Node<T>* root) {
    if (root != nullptr) {
        BinaryTree::PostOrder(root->left);
        BinaryTree::PostOrder(root->right);
        cout << root->key << " ";
    }
}

template<typename T>
void BinaryTree<T>::PreOrder(Node<T>* root) {
    if (root != nullptr) {
        cout << root->key << " ";
        BinaryTree::PreOrder(root->left);
        BinaryTree::PreOrder(root->right);
    }
}

template<typename T>
void BinaryTree<T>::AddNode(T value) {
    if (tree == nullptr) {
        tree = makeNode(value);
        return;
    }

    auto temp = tree;
    while (true) {
        if (value >= temp->key) {
            if (temp->right == nullptr) {
                temp->right = makeNode(value);
                temp->right->parent = temp;
                return;
            }
            else {
                temp = temp->right;
            };
        }
        else {
            if (temp->left == nullptr) {
                temp->left = makeNode(value);
                temp->left->parent = temp;
                return;
            }
            else {
                temp = temp->left;
            }
        }
    }
}


#endif
