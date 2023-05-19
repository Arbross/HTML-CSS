//#include <iostream>
//#include <math.h>
//
//using namespace std;
//
//const double e = 2.71828;
//const double pi = 3.14;
//
//// Method by solving task one
//double solvingTaskOne(double z)
//{
//    return pow(e, -3.5 * abs(z)) * log10(pow(z, 4));
//}
//
//// Method by solving task two
//double solvingTaskTwo(double x)
//{
//	return pow(sqrt(pow((x + 6.1), 3)), 5);
//}
//
//// Method by solving task three
//double solvingTaskThree(double a)
//{
//	return 21.4 * pow((a  - 0.5), 2) - cos(pi / a);
//}
//
//
//int main()
//{
//	try
//	{
//		while (true)
//		{
//			int choose = 0;
//
//			cout << "1 - task one" << endl;
//			cout << "2 - task two" << endl;
//			cout << "3 - task three" << endl;
//			cout << "4 - exit" << endl;
//			cin >> choose;
//
//			switch (choose)
//			{
//			case 1: {
//				// Task 1
//
//				int z = 0;
//				cout << "Please enter 'z' parameter : " << endl; cin >> z;
//				cout << "Your answer by 'g' parameter is : " << solvingTaskOne(z) << endl;
//			} break;
//			case 2: {
//				// Task 2
//
//				int x = 0;
//				cout << "Please enter 'x' parameter : " << endl; cin >> x;
//				cout << "Your answer by 'z' parameter is : " << solvingTaskTwo(x) << endl;
//			} break;
//			case 3: {
//				// Task 3
//
//				int a = 6.42;
//				cout << "Your answer by 'x' parameter is : " << solvingTaskThree(a) << endl;
//			} break;
//			case 4: {
//				return 0;
//			} break;
//			default: cout << "Oupss.. Entered value is wrong." << endl; break;
//			}
//		}
//	}
//	catch (const exception& ex)
//	{
//		cout << ex.what() << endl;
//	}
//
//	return 0;
//}
