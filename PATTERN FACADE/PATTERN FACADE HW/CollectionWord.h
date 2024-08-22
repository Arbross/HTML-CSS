#pragma once
#include <iostream>
#include <list>
#include "Word.h"
using namespace std;

class CollectionWord
{
public:
	void addWord(Word w)
	{
		words.push_back(w);
	}

	string getWord(const string& s) const
	{
		// return find();
	}

	void deleteWord(const string& s)
	{
		words.erase(find(words.begin(), words.end(), s));
	}
private:
	list<Word> words;
};

