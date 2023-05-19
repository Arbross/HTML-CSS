#include <iostream>
#include <fstream>

using namespace std;

const int ARRAY_SIZE = 50;

int main() {
    // Task 1

    ifstream input_file("input.txt");

    double numbers[ARRAY_SIZE];

    int index = 0;
    while (input_file >> numbers[index] && index < ARRAY_SIZE) {
        index++;
    }

    input_file.close();

    int negative_count = 0;

    ofstream output_file("output.txt");
    for (int i = 0; i < ARRAY_SIZE; i++) {
        if (numbers[i] < 0) {
            negative_count++;

            output_file << "Position: " << i << ", Value: " << numbers[i] << endl;
        }
    }

    output_file.close();

    cout << "Number of negative numbers: " << negative_count << endl;

    return 0;
}
