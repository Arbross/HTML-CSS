#include<iostream>
#include<string>
#include <locale>;
#include "windows.h";

using namespace std;

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    string str = "";
    cout << "Please enter string : ";  cin >> str;

    string tmp = "";
    for (int i = 0; i < str.length(); i++)
    {
        if (str[i] >= char(128) && str[i] <= char(252))
        {
            continue;
        }

        tmp += str[i];
    }

    cout << "Result : " << tmp << endl;

    return 0;
}
