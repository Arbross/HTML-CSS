#include <iostream>
#include <math.h>

using namespace std;

// Method that solving exercise one
double solveTaskOne(int n)
{
    return ((cbrt(n - 1) * log10(pow(2, n)) - tan((n + 1) / pow(n, 3))) / (acos(0.85) + log10(n))) + 2.75;
}

// Method that solving exercise one
double solveTaskTwo(int x)
{
    return atan((1 / x) / sqrt(1 - ((1 / x) * (1 / x)))) / (-2 * exp(-x));
}

int main()
{
	try
	{
        int choose = 0;

        while (true)
        {
            cout << endl << "1 - excercise 1" << endl;
            cout << "2 - excercise 2" << endl;
            cout << "3 - exit" << endl;
            cin >> choose;

            switch (choose)
            {
            case 1: {
                // Excercise 1

                int n = 0; // Our 'in' value we're enter in
                cout << "Hello! Please enter 'n' value : "; cin >> n; // Entering 'n' variable code 

                cout << "Your 'y' result of task number one is " << solveTaskOne(n) << "." << endl; // Solving example by entered data
            } break;
            case 2: {
                // Excercise 2

                int x = 0; // Our 'in' value we're enter in
                cout << "Please enter 'x' value : "; cin >> x; // Entering 'x' variable code 

                cout << "Your 'x' result of task number two is " << solveTaskTwo(x) << "." << endl; // Solving example by entered data
            } break;
            case 3: {
                return 0;
            } break;
            default: cout << "Oupsss.. Wrong number!" << endl; break;
            }
        }
	}
	catch (const exception& ex)
	{
        cout << ex.what() << endl;
	}
    
    return 0;
}
