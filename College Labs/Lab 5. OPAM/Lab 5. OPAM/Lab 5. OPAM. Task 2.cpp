#include<iostream>
#include<math.h>

using namespace std;

int main()
{
	double w = 0;
	int v = 0;
	cout << "Please enter 'v' value : " << endl; cin >> v;

	while (true)
	{
		if (0 <= v <= 0.5)
		{
			w = pow(v, 2) + pow(v, 1 / 3);
			break;
		}
		else if (0.5 < v <= 8)
		{
			w = log10(v + sin(v));
			break;
		}
		else {
			w = NAN;
			break;
		}
		
		v += 0.5;
	}

	cout << "Your 'w' parameter result : " << w << endl;

	return 0;
}