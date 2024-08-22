#pragma once
#include <iostream>
#include <map>
using namespace std;

class Weapon abstract
{
public:
	Weapon(const size_t& bullets = 0, const size_t& spentBullets = 0)
		: bullets(bullets), spentBullets(spentBullets) {}

	void shoot()
	{
		if (isPossibleShoot())
		{
			cout << "Shot !!! It is Remains " << (bullets -= spentBullets) << "\n";
		}
		
		throw exception("It is too low count of bullets.");
	}

	bool isPossibleShoot()
	{
		return bullets >= spentBullets;
	}

	virtual Weapon* clone() = 0; // prototype
private:
	size_t bullets;
	size_t spentBullets;
};

class Pistol : public Weapon
{
public:
	Pistol(const size_t& bullets = 0)
		: Weapon(bullets, 1) {}

	Weapon* clone() override
	{
		return new Pistol(*this);
	}
};

class Minigun : public Weapon
{
public:
	Minigun(const size_t& bullets = 0)
		: Weapon(bullets, 3) {}

	Weapon* clone() override
	{
		return new Minigun(*this);
	}
};

class WeaponStock
{
public:
	void addWeapon(const size_t id, Weapon* weapon)
	{
		weapons.insert( {id, weapon} );
	}

	Weapon* getWeapon(const size_t& id)
	{
		if (weapons.find(id) != weapons.end())
		{
			return weapons[id]->clone(); // BAD NOT CLONE
		}
		else {
			throw exception("Bad id");
		}
	}
private:
	map<size_t, Weapon*> weapons;
};
