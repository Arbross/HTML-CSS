#include <iostream>
#include <fstream>
#include <string>

using namespace std;

const int ARRAY_SIZE = 17;

struct Person {
    string last_name;
    string first_name;
    char gender;
    double height;
    double weight;
};

int main() {
    ifstream input_file("input.txt");

    Person people[ARRAY_SIZE];

    for (int i = 0; i < ARRAY_SIZE; i++) {
        input_file >> people[i].last_name >> people[i].first_name >> people[i].gender
            >> people[i].height >> people[i].weight;
    }

    input_file.close();

    for (int i = 0; i < ARRAY_SIZE; i++) {
        if (people[i].height - people[i].weight < 100) {
            cout << people[i].last_name << endl;
        }
    }

    return 0;
}
