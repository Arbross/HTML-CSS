#pragma once
#include <iostream>
#include <deque>
using namespace std;

class TreeType
{
public:
	TreeType(const string& name, const string& color)
		: name(name), color(color) {}

	void draw(const int x, const int y)
	{
		cout << "Draw on canvas tree" << name << " and color " << color << " x = " << x << " y = " << y << endl;
	}

	string name;
	string color;

};

class Tree
{
public:
	int x, y;
	TreeType& type;

	Tree(const int& x, const int& y, TreeType& type)
		: x(x), y(y), type(type) {}

	void draw() // canvas
	{
		type.draw(x, y);
	}
};

class TreeFactory
{
public:
	TreeType* getTreeType(const string& name, const string& color)
	{
		auto it = find_if(begin(treeTypes), end(treeTypes), [&](TreeType* t) { return t->name == name and t->color == color; });

		if (it != end(treeTypes))
		{
			return *it;
		}

		auto treeType = new TreeType(name, color);
		treeTypes.push_back(treeType);
		return treeType;
	}
private:
	deque<TreeType*> treeTypes;
};

class Forest
{
	TreeFactory factory;
	deque<Tree*> forest;
public:
	Tree* plantTree(const int& x, const int& y, const string& name, const string& color)
	{
		Tree* tree = new Tree(x, y, *factory.getTreeType(name, color));
		forest.push_back(tree);
		return tree;
	}
	
	void draw()
	{
		for (const auto& t : forest)
		{
			t->draw();
		}
	}
};
