#include<iostream>
#include <string>

using namespace std;

// Task 2

string Concat(string s1, string s2)
{
	if (s1 == "" || s2 == "") {
		return "";
	}

	return s1 + s2;
}

int main()
{
	int countOfWords = 0;
	string str = "";

	getline(cin, str);

	char currentSymbol = '1', prevSymbol = '1';
	for (size_t i = 0; i < str.length(); i++)
	{
		prevSymbol = currentSymbol;
		currentSymbol = str[i];

		if (prevSymbol != ' ' && currentSymbol == ' ')
		{
			countOfWords++;
		}
	}

	if (currentSymbol != ' ')
	{
		countOfWords++;
	}

	cout << "Count of words in your string: " << countOfWords << endl;

	// Task 2

	cout << Concat("Hello ", "World!") << endl;

	return 0;
}