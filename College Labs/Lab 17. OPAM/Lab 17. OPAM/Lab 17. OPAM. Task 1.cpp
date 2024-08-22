#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    // Writing to the file
    ofstream MyFile("filename.txt");

    MyFile << "-5.5,3.2,12.1,-4.3,7.9,14.03,5.5,34,";
    MyFile.close();

    // Have to find
    string myText = "";

    ifstream MyReadFile("filename.txt");

    int counter = 0;
    double sum = 0, max = 0;
    string number = "0";
    getline(MyReadFile, myText);
    for (size_t i = 0; i < myText.length(); i++)
    {
        char symbol = myText[i];

        if (symbol == ',')
        {
            ++counter;

            if (stod(number) >= 0.2 && stod(number) <= 0.9)
            {
                sum += stod(number);
            }

            if (counter % 2 == 0)
            {
                if (max < stod(number))
                {
                    max = stod(number);
                }
            }

            number = "0";
            continue;
        }

        number += symbol;
    }

    cout << "Sum : " << sum << endl;
    cout << "Max : " << max << endl;

    MyReadFile.close();

    return 0;
}
