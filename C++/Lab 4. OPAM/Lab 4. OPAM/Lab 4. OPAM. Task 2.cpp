#include <iostream>
#include <math.h>

using namespace std;

const double PI = 3.14;
const double e = 3.14;

double methodSolvingTaskOne()
{
    int x = 0;
    cout << "Enter x value : "; cin >> x;

    if (x < -1)
    {
        return acos((PI - x) / 2);
    }
    else if (abs(x) < 1) 
    {
        return pow(e, pow(-x, 2));
    }
    else if (x > 1) 
    {
        return PI * pow(log10(x), 2);
    }
    else if (abs(x) == 1)
    {
        return pow(10, -3);
    }

    return NAN;
}

int main()
{
    try
    {
        while (true)
        {
            int choose = 0;
            cout << "1 - task 1" << endl;
            cout << "2 - exit" << endl;
            cin >> choose;

            switch (choose)
            {
            case 1: {
                cout << "y" << " = " << methodSolvingTaskOne() << endl;
            } break;
            case 2: {
                return 0;
            } break;
            default: cout << "Oupss... Entered value is wrong." << endl; break;
            }
        }
    }
    catch (const exception& ex)
    {
        cout << ex.what() << endl;
    }

    return 0;
}
