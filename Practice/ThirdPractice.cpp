#include <iostream>
#include <math.h>

using namespace std;

int main() {
    // Task 1

    int num, i = 1, sum = 0;
    cout << "Enter number: ";
    cin >> num;
    do {
        if(num % i == 0) {
            sum += i;
        }
        i++;
    } while(i <= num);
    cout << "Result: " << num << " = " << sum << endl;

    // Task 2

    int passagersNValue = 0;
    double maxLiftWeight = 0, sumWeight = 0;

    cout << "Enter max lift weight: "; cin >> maxLiftWeight;
    cout << "Enter number of passagers: "; cin >> passagersNValue;

    for (int j = 0; j < passagersNValue; ++j) {
        double weight = 0;
        cout << "Enter weight of passager: "; cin >> weight;
        sumWeight += weight;
    }

    if (sumWeight >= maxLiftWeight)
    {
        cout << passagersNValue << " people died." << endl;
    }
    else {
        cout << "Successful list operation." << endl;
    }

    // Task 3

    double result = 0, x1 = 0;
    cout << "Enter 'x' value: "; cin >> x1;

    double n = 0;
    cout << "Enter 'n' value: "; cin >> n;

    double a = x1;
    double b = 3.14/2;
    double h = (b - a) / n;
    double sum1 = 0;

    for (int i = 0; i < n; i++) {
        double x = a + i * h;
        sum1 += sin(x);
    }

    sum += (sin(a) + sin(b)) / 2.0;
    sum *= h;

    cout << "The value of the integral is: " << sum1 << endl;

    return 0;
}
