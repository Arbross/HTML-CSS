#include<iostream>
#include<math.h>

using namespace std;

int main()
{
	int result = 1;
	for (size_t i = 10; i <= 20; i++)
	{
		result *= (i / 10);
	}

	cout << "Your 'result' parameter : " << result << endl;

	return 0;
}
