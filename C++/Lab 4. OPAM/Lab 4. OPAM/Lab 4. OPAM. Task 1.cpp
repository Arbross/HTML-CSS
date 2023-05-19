#include <iostream>
#include <math.h>

using namespace std;

// Method by solving task one
double methodSolvingTaskOne(double l, double k)
{
    return (l + k) / 5;
}

// Method by solving task two
double methodSolvingTaskTwo(double l, double k)
{
    return (l - k) / k;
}

// Method by solving task three
double methodSolvingTaskThree(double l, double k)
{
    return (l * k) + 4.2;
}

// Method by solving task four
double methodSolvingTaskFour(double a, double b, double c)
{
    return min(a, b) + max(b, c);
}

int main()
{
    while (true)
    {
        int choose = 0;
        cout << "1 - Task 1" << endl;
        cout << "2 - Exit" << endl;
        cin >> choose;

        switch (choose)
        {
        case 1: {
            int l = 0, k = 0;
            cout << "Please enter 'l' value : "; cin >> l;
            cout << "Please enter 'k' value : "; cin >> k;

            double a = methodSolvingTaskOne(l, k);
            double b = methodSolvingTaskTwo(l, k);
            double c = methodSolvingTaskThree(l, k);

            cout << "Your answer is : " << methodSolvingTaskFour(a, b, c) << endl;
        } break;
        case 2: {
            return 0;
        } break;
        default: cout << "Oupss... Entered value is wrong." << endl; break;
        }
    }

    return 0;
}
