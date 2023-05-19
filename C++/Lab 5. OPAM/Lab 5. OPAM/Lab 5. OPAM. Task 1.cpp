#include <iostream>
#include <math.h>

using namespace std;

int main()
{
    int m = 0;
    double a = 0, b = 0;

	cout << "Please enter 'm' value : "; cin >> m;
	cout << "Please enter 'a' value : "; cin >> a;
	cout << "Please enter 'b' value : "; cin >> b;

	int h = round((b - a) / m), j = 1;

	for (int i = a; i < b - 1; i += h)
	{
		cout << j << ". " << (1 / pow(i, 2)) + pow(i, 2) << endl;
		++j;
	}

	return 0;
}
