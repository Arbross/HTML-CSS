#include<iostream>
#include<string>

using namespace std;

int main()
{
    string str = "fdgdfg Agdfgdf dfgdfg Agdfgdfg Afgdfg dfgdfgfd Asdfsfdfs fdsfdsfds";

	cout << str << endl;

	int count = 0;
	string tmp = "";
	for (int i = 0; i < str.length(); i++)
	{
		if ((str[i] == ' ' || i == str.length() - 1) && tmp[0] == 'A')
		{
			count++;
			tmp = "";
			continue;
		}
		else if (str[i] == ' ' || i == str.length() - 1)
		{
			tmp = "";
			continue;
		}

		tmp += str[i];
	}

	cout << "Count of Words : " << count << endl;

    return 0;
}
