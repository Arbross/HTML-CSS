#pragma once
#include <iostream>
#include "FileWork.h"
#include "Translate.h"
#include "CollectionWord.h"
using namespace std;

class FacadeFileBase
{
public:
	void addNewWord(const string& EN, const string& UA);
	void deleteWord(const string& a);
	bool writeToBase();
private:
	FileWork FileSystem;
	Translate TranslateSystem;
	CollectionWord Words;
};

