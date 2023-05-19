#include <iostream>
#include <math.h>

using namespace std;

int main() {
    // Task 1

    double k = 0, x = 0, l = 0;

    cout << "Enter 'k' value: "; cin >> k;
    cout << "Enter 'x' value: "; cin >> x;

    l = (1 / pow(2.7, -k * x + 0.5)) * (((log(abs(k + x)) - sqrt(pow(sin(x), 4))) / (abs(atan((x + 1) / (x - k) + (3.14 / 10) * log(3.14))) + 1)) + 2);

    cout << "Here is your 'l' result: " << l << endl;

    // Task 2

    double x1 = 3, c = 2.5, y = 0, d = 0;

    y = pow(x, 4) - pow(sqrt(c), 1/3);
    d = 2 * y + cos(c);

    cout << "Here is your 'x' value: " << x1 << endl;
    cout << "Here is your 'c' value: " << c << endl;
    cout << "Here is your 'y' value: " << y << endl;
    cout << "Here is your 'd' value: " << d << endl;

    // Task 3

    int countOfNumbers = 1;
    cout << "Enter count of numbers: "; cin >> countOfNumbers;

    double array[countOfNumbers];
    for (int i = 0; i < countOfNumbers; ++i) {
        double number = 0;
        cout << "Enter '" + to_string(i) + "' number value: "; cin >> number;
        array[i] = number;
    }

    double sum = 0, mult = 1;
    for (int i = 0; i < countOfNumbers; ++i) {
        sum += array[i];
        mult *= array[i];
    }

    cout << "Here is your 'sum' value: " << sum << endl;
    cout << "Here is your 'mult' value: " << mult << endl;

    return 0;
}
