#include <iostream>
#include <math.h>

using namespace std;

// Task 1
double sqrtWrapper(double value)
{
    return sqrt(value);
}

// Task 2
double a[] = { 1, 2, 3, -1, -6.4, -2, 3, 8, 1, 3, 3, 0, 5, -0.1, 4.4 };
double b[] = { 0.5, -2, 3, 3, 4, 1, 0, 9, -3.2, 1, 0, 2, 1, -5.1 };

double firstSum()
{
    int m = 1, mMax = 5;
    double sum = 0;
    for (int i = m; i < mMax; ++i) {
        sum += a[i] - sin(abs(b[i]));
    }

    return sum;
}

double secondSum()
{
    int m = 2, mMax = 7;
    double sum = 0;
    for (int i = m; i < mMax; ++i) {
        sum += 3 * a[i] - sin(abs(b[i]));
    }

    return sum;
}

double thirdSum()
{
    int m = 1, mMax = 3;
    double sum = 0;
    for (int i = m; i < mMax; ++i) {
        sum += b[i] - sin(abs(a[i]));
    }

    return sum;
}

int main() {
    // Task 1

    double value = 0;
    cout << "Enter value: "; cin >> value;
    cout << "Here is your result: " << sqrtWrapper(value) << endl;

    // Task 2

    double x = -6.08, y = 2.24;
    double R = ((pow(sin(x - y), 2)) / (firstSum()) - ((secondSum()) / (pow(sin(1.3 - x * y), 2))) - ((pow(sin(1.3 * x - 0.6), 2)) / (thirdSum())));
    cout << "Your result value: " << R << endl;


    return 0;
}
