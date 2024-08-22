#include <iostream>
#include "LogMsg.h"
using namespace std;

int main()
{
	
	LogMsg& log = LogMsg::getInstance("text.dat");

	log.write("Loaded recipes 7");
	log.write("Loaded recipes 8");
	log.write("Loaded recipes 9");
	log.write("Loaded recipes 10");
	log.write("Loaded recipes 11");
	log.write("Loaded recipes 12");
	log.write("Loaded recipes 13");
	log.write("Loaded recipes 14");
	log.read();

	
	


}
