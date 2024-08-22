#pragma once
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

class FileSystem abstract
{
public:
	virtual size_t getSize() const = 0;
	virtual string getName() const
	{
		return name;
	}

	virtual void setName(const string& name)
	{
		this->name = name;
	}

	virtual void printInfo() const
	{
		cout << "Name : " << getName() << endl;
	}
protected:
	string name;
};

class File : public FileSystem
{
public:
	File(const string& name = "Noname", const size_t& size = 0)
		: size(size)
	{
		setName(name);
	}

	size_t getSize() const override
	{
		return size;
	}

	void printInfo() const override
	{
		cout << "Name  : " << getName() << endl;
		cout << "Size : " << getSize() << endl;
	}
private:
	size_t size;
};

class Folder : public FileSystem
{
public:
	Folder(const string& sname = "No system name")
		: sname(sname) {}

	void addItem(FileSystem* item)
	{
		dbase.push_back(item);
		countAllSize();
	}

	string getName() const override
	{
		return name;
	}

	size_t getSize() const override
	{
		return size;
	}

	void printInfo() const override
	{
		cout << "File System name : " << sname << endl;

		for (const auto& elem : dbase)
		{
			elem->printInfo();
		}
	}

private:
	string sname;
	size_t size;

	vector<FileSystem*> dbase;

	void countAllSize()
	{
		size_t tmp = 0;
		for (const auto& elem : dbase)
		{
			tmp += elem->getSize();
		}

		size = tmp;
	}
};