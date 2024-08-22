#include <iostream>
#include <string>

using namespace std;

// CryptInfo class
// Working with data
// Variables : message, key

struct CryptInfo
{
    string message;
    unsigned long key;
};

// Crypt class
// Encrypt method of XOR
// Decrypt method of XOR

struct Crypt
{
    static string Encrypt(CryptInfo cryptInfo)
    {
        string result = "";
        for (int i = 0; i < cryptInfo.message.length(); i++)
        {
            result += (char)(cryptInfo.message[i] ^ cryptInfo.key);
        }

        return result;
    }

    static string Decrypt(CryptInfo cryptInfo)
    {
        string result = "";
        for (int i = 0; i < cryptInfo.message.length(); i++)
        {
            result += (char)(cryptInfo.message[i] ^ cryptInfo.key);
        }

        return result;
    }
};

// Main method
// Testing crypt methods

int main()
{
    int choose = 0;

    cout << "1 - Encrypt" << endl;
    cout << "2 - Decrypt" << endl;
    cout << "3 - Exit" << endl;
    cin >> choose;

    switch (choose)
    {
    case 1: {
        string message = "";
        unsigned long key = 0;

        cout << "Enter message : "; cin >> message;
        cout << "Enter key : "; cin >> key;

        CryptInfo info;
        info.key = key;
        info.message = message;

        cout << Crypt::Encrypt(info) << endl;
    } break;
    case 2: {
        string message = "";
        unsigned long key = 0;

        cout << "Enter message : "; cin >> message;
        cout << "Enter key : "; cin >> key;

        CryptInfo info;
        info.key = key;
        info.message = message;

        cout << Crypt::Decrypt(info);
    } break;
    case 3: {
        return 0;
    } break;
    default: {
        cout << "Ouppsss... Error code..." << endl;
    } break;
    }

    return 0;
}
