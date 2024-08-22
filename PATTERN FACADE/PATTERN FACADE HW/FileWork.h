#pragma once
#include <iostream>
#include "CollectionWord.h"
using namespace std;

class FileWork
{
public:
	CollectionWord load(const string& fileName);
	bool write(const string& fileName, const CollectionWord* words);
};

