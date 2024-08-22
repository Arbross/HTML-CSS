#include <iostream>
#include <math.h>

using namespace std;

int main() {
    // Task 1

    bool isPassed = false;
    int x = 0, y = 0;

    cout << "Enter 'x' value: "; cin >> x;
    cout << "Enter 'y' value: "; cin >> y;

    if ((x >= 0 && y >= 1) || (x <= 0 && x >= -1 && y <= 0))
    {
        isPassed = true;
    }

    switch (isPassed) {
        case true: {
            cout << "Point owns this range." << endl;
        } break;
        case false: {
            cout << "Point don't own this range." << endl;
        } break;
    }

    // Task 2

    int solutionCount = 0;
    double a = 0, b = 0, c = 0, D = 0;

    cout << "Enter 'a' value: "; cin >> a;
    cout << "Enter 'b' value: "; cin >> b;
    cout << "Enter 'c' value: "; cin >> c;

    D = sqrt(pow(b, 2) - 4 * a * c);

    if (D == 0)
    {
        solutionCount++;
    }
    else if (D != NAN)
    {
        solutionCount += 2;
    }

    cout << "Here is your solution count - " << solutionCount << "." << endl;

    // Task 3

    int choose = 0;
    cout << "1 - Plus" << endl;
    cout << "2 - Minus" << endl;
    cout << "3 - Multiplication" << endl;
    cout << "4 - Division" << endl;
    cin >> choose;

    switch (choose) {
        case 1: {
            double value1 = 0, value2 = 0;
            cout << "Enter first value: "; cin >> value1;
            cout << "Enter second value: "; cin >> value2;

            cout << "Here is your result: " << value1 + value2 << endl;
        } break;
        case 2: {
            double value1 = 0, value2 = 0;
            cout << "Enter first value: "; cin >> value1;
            cout << "Enter second value: "; cin >> value2;

            cout << "Here is your result: " << value1 - value2 << endl;
        } break;
        case 3: {
            double value1 = 0, value2 = 0;
            cout << "Enter first value: "; cin >> value1;
            cout << "Enter second value: "; cin >> value2;

            cout << "Here is your result: " << value1 * value2 << endl;
        } break;
        case 4: {
            double value1 = 0, value2 = 0;
            cout << "Enter first value: "; cin >> value1;
            cout << "Enter second value: "; cin >> value2;

            cout << "Here is your result: " << value1 / value2 << endl;
        } break;
        default: cout << "Wrong selection method." << endl;
    }

    return 0;
}
