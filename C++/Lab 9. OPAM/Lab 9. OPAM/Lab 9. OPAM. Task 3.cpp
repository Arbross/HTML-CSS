#include<iostream>

using namespace std;

int main()
{
    string str = "";
    cout << "Please enter string : ";  cin >> str;

    int count = 0;
    for (int i = 0; i < str.length(); i++)
    {
        count++;
    }

    cout << "String length : " << count << endl;

    return 0;
}
