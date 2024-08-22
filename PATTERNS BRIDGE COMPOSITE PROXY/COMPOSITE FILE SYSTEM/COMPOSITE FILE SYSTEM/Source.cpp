#include <iostream>
#include "FS.h"
using namespace std;

int main()
{
	FileSystem* fileZ = new File("z.doc", 12000);
	FileSystem* fileW = new File("w.doc", 23000);
	Folder* folderA = new Folder("A");
	Folder* folderB = new Folder("B");
	folderB->addItem(fileW);
	folderA->addItem(fileZ);
	folderA->addItem(folderB);
	cout << fileZ->getSize() << endl;
	cout << folderA->getSize() << endl; // 12000 + 23000 = 35000

	return 0;
}