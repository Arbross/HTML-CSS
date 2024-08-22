#include<iostream>
#include<math.h>

using namespace std;

int main()
{
	try
	{
		while (true)
		{
			int choose = 0;

			cout << "1 - 21-IP" << endl;
			cout << "2 - 22-IP" << endl;
			cout << "3 - 23-IP" << endl;
			cout << "4 - 24-IP" << endl;
			cout << "5 - Exit" << endl;
			cin >> choose;

			switch (choose)
			{
			case 1: {
				cout << "21-IP - 24 students" << endl;
			} break;
			case 2: {
				cout << "22-IP - 29 students" << endl;
			} break;
			case 3: {
				cout << "23-IP - 30 students" << endl;
			} break;
			case 4: {
				cout << "21-IP - 20 students" << endl;
			} break;
			case 5: {
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
