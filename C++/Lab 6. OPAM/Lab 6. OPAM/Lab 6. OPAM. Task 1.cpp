#include<iostream>
#include<math.h>

using namespace std;

int main()
{
    // Type 'a'

	double x = 23, y = 0;
	do
	{
		if (0.1 <= x <= 1.5)
		{
			y = (3 * x + 1) / atan(x);
			break;
		}

		x += 0.2;
	} while (true);

	cout << "Your 'y' value : " << y << endl;

	 // Type 'b'

	int n = 0;
	double y1 = 0, x1 = 34;
	do
	{
		if (n == 5)
		{
			break;
		}

		if (x1 >= 0.4)
		{
			y1 = (3 * x1 + 1) / atan(x1);
			break;
		}

		x1 += 0.1;
		++n;
	} while (true);

	cout << "Your 'y' value : " << y1 << endl;

    return 0;
}
