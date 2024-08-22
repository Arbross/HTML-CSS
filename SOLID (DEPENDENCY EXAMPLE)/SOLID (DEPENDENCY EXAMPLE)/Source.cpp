#include <iostream>
#include <vector>
using namespace std;

struct NameOfACar
{
	NameOfACar(const string& name)
		: name(name) {}

	string getName() const
	{
		return name;
	}

	void setName(const string& _name) const
	{
		const_cast<string&>(name) = _name;
	}

	void print() const
	{
		cout << "Name : " << name << endl;
	}
private:
	string name;
};

__interface IVehicle
{
	virtual void takeVehicle(const string& vehicle, const size_t index) const;
};

// LOW
class Car : public IVehicle
{
public:
	void add(const string& name)
	{
		if (!empty(name))
		{
			vec.push_back(NameOfACar(name));
		}
		else {
			throw exception("Bad or no value (Empty).");
		}
	}

	void erase(const size_t& number)
	{
		vec.erase(vec.begin() + number, vec.begin() + number);
	}

	virtual void takeVehicle(const string& vehicle, const size_t index) const override
	{
		size_t i = 0;
		for (const auto& elem : vec)
		{
			if (i == index)
			{
				elem.setName(vehicle);
			}
			++i;
		}
	}
private:
	vector<NameOfACar> vec;
};

// HIGH
class Motobike
{
public:
	Motobike(IVehicle& vehicle)
	{
		// cout << "F" << vehicle.takeVehicle("Vehicle", 5) << endl;
	}
};

