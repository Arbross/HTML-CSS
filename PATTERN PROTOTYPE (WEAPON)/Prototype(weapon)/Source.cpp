#include <iostream>
#include "Weapon.h"
using namespace std;

int main()
{
	//Weapon* pistol = new Pistol(8); // 8, 1
	//Weapon* clone = pistol->clone();
	//cout << "Adress : " << pistol << "\t" << clone << endl; // DIFFERENT

	WeaponStock stock;
	stock.addWeapon(100, new Pistol(8));
	stock.addWeapon(200, new Minigun(350));

	Weapon* w = stock.getWeapon(100);
	cout << "Check adress : " << w << "\t" << stock.getWeapon(100);

	while (w->isPossibleShoot())
	{
		w->shoot();
	}

	return 0;
}