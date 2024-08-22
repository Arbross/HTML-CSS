#pragma once
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

__interface IShip
{
	void print() const;
};

class Ship : public IShip
{
public:
	Ship(const string& name = "Noname", const size_t& speed = 0)
		: name(name), speed(speed) {}

	void print() const override
	{
		cout << "Name : " << name << ",\tSpeed : " << speed << endl;
	}
private:
	string name;
	size_t speed;
};

class Fleet : public IShip
{
public:
	Fleet(const size_t id, IShip* item)
		: id(id) 
	{
		add(item);
	}

	void add(IShip* item)
	{
		if (item != nullptr)
		{
			children.push_back(item);
		}
	}

	void remove(IShip* item)
	{
		auto it = find(begin(children), end(children), item);

		if (it != end(children))
		{
			delete* it;
			children.erase(it);
		}
	}

	void print() const override
	{
		cout << "FLEET # " << id << endl;
		for (const auto& elem : children)
		{
			elem->print();
		}
	}

	~Fleet()
	{

	}
private:
	size_t id;
	vector<IShip*> children;
};

