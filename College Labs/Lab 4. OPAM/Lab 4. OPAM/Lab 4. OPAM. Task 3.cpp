#include <iostream>
#include <math.h>

using namespace std;

double methodSolvingParallelTask(double r1, double r2)
{
	return (1 / r1) + (1 / r2);
}

double methodSolvingConsistentTask(double r1, double r2)
{
	return r1 + r2;
}

int main()
{
	try
	{
		while (true)
		{
			int choose = 0;

			cout << "1 - Parallel" << endl;
			cout << "2 - Consistent" << endl;
			cout << "3 - Exit" << endl;
			cin >> choose;

			switch (choose)
			{
			case 1: {
				double R1 = 0, R2 = 0;

				cout << "Please enter R1 : "; cin >> R1;
				cout << "Please enter R2 : "; cin >> R2;

				cout << "Getted value 1/R : " << methodSolvingParallelTask(R1, R2) << endl;
			} break;
			case 2: {
				double R1 = 0, R2 = 0;

				cout << "Please enter R1 : "; cin >> R1;
				cout << "Please enter R2 : "; cin >> R2;

				cout << "Getted value R : " << methodSolvingConsistentTask(R1, R2) << endl;
			} break;
			case 3: {
				return 0;
			} break;
			default:
				break;
			}
		}
	}
	catch (const exception& ex)
	{
		cout << ex.what() << endl;
	}

	return 0;
}
