#include<iostream>
#include<string>

using namespace std;

int main()
{
    string S = "qfwtypewm", X = "";

	// Task 1

	int firstIndex = 0;
	for (int i = 0; i < S.length(); i++)
	{
		if (S[firstIndex] == 't' && S[(firstIndex + 1)] == 'y' && S[(firstIndex + 2)] == 'p' && S[firstIndex + 3] == 'e')
		{
			S = S.erase(firstIndex, 4);
			break;
		}

		if (S[i] == 't')
		{
			firstIndex = i;
		}
	}

	cout << "Task 1. Result : " << S << endl;

	// Task 2

	S.insert(S.find('w') + 1, "hile");

	cout << "Task 2. Result : " << S << endl;

	// Task 3

	for (int i = 4; i < 7; i++)
	{
		X += S[i];
	}

	cout << "Task 3. Result : " << X << endl;

	// Task 4

	for (int i = 0; i < S.length(); i++)
	{
		if (S[i] == 'm' || S[i] == 'f')
		{
			S.erase(i, i);
		}
	}

	cout << "Task 4. Result : " << S << endl;

    return 0;
}
