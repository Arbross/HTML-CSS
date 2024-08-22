#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include "Msg.h"
using namespace std;

class LogMsg
{
public:
	LogMsg(const LogMsg& other) = delete;
	LogMsg& operator =(const LogMsg&) = delete;

	static LogMsg&  getInstance(const string& fileName = "test.dat")
	{
		static LogMsg s(fileName);
		return s;
	}

	void write(const string& message);
	void read();
private:
	LogMsg(const string& fileName = "test.dat")
		: fileName(fileName) {}

	vector<Msg> vec;
	string fileName;
};

inline void LogMsg::write(const string& message)
{
	const string info = "[INFO] : ";

	vec.push_back(Msg(info + message));
	fstream file(fileName, ios_base::binary | ios_base::trunc | ios_base::out);

	for (const auto& elem : vec)
	{
		file.write((char*)&elem, sizeof(elem));
	}
	file.close();
}

inline void LogMsg::read()
{
	Msg msg;
	ifstream in(fileName, ios_base::binary);
	if (!in)
	{
		throw exception("Error opening file for read");
	}

	in.read(reinterpret_cast<char*>(&msg), sizeof(Msg));
	while (!in.eof())
	{
		msg.print();
		in.read(reinterpret_cast<char*>(&msg), sizeof(Msg));
	}
	in.close();
}
