#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	// Task 1

	ofstream MyFile("filename.txt");

	MyFile << "Solomon Fir 06.11.2022 00011,";
	MyFile << "Solomon Sec 06.11.2022 00000,";
	MyFile << "Solomon Thi 06.11.2022 11111,";
	MyFile << "Solomon Fou 06.11.2022 00000,";

	MyFile.close();

	// Task 2

	ofstream MyFileResult("filenameResult.txt");

	string myText;

	ifstream MyReadFile("filename.txt");

	string text = "";
	int space_counter = 0, troubles_count = 0;
	getline(MyReadFile, myText);
	for (size_t i = 0; i < myText.length(); i++)	
	{
		char symbol = myText[i];

		if (troubles_count == 5)
		{
			MyFileResult << text + "\n";
		}

		if (symbol == '0' && space_counter == 3)
		{
			troubles_count++;
		}

		if (symbol == ' ')
		{
			space_counter++;
		}

		if (symbol == ',')
		{
			space_counter = 0;
			troubles_count = 0;
			text = "";
			continue;
		}

		if (space_counter <= 1)
		{
			text += symbol;
		}
	}

	MyReadFile.close();

	MyFile.close();

	return 0;
}
