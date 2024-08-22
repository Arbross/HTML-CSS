#include <iostream>
using namespace std;

class Clock24
{
public:
	Clock24(const size_t& hour = 0, const size_t& min = 0)
	{
		setHour(hour);
		setMin(min);
	}

	void setHour(const size_t& hour)
	{
		if (hour <= 23)
		{
			if (hour == 23 && getMin() == 60)
			{
				setHour(0);
				setMin(0);
			}

			this->hour = hour;
		}
		else {
			throw exception("Error of hour range");
		}
	}

	void setMin(const size_t& min)
	{
		if (min <= 60)
		{
			if (hour == 23 && getMin() == 60)
			{
				setHour(0);
				setMin(0);
			}

			this->min = min;
		}
		else {
			throw exception("Error of min range");
		}
	}

	size_t getHour() const
	{
		return hour;
	}

	size_t getMin() const
	{
		return min;
	}

	void tick()
	{
		min += 1;

		if (hour == 23 && getMin() >= 60)
		{
			setHour(0);
			setMin(0);
		}
	}

	void print() const
	{
		cout << "Hour : " << getHour() << "\tMin : " << getMin() << endl;
	}

protected:
	size_t hour;
	size_t min;
};

__interface IClock12
{
	void setHourTwelve(const size_t& hour);
	void setMinTwelve(const size_t& min);
};

class Clock : public IClock12, public Clock24
{
	void setHourTwelve(const size_t& hour) override
	{
		if (hour <= 23)
		{
			if (hour == 23 && getMin() == 60)
			{
				setHour(0);
				setMin(0);
			}

			this->hour = hour;
		}
		else {
			throw exception("Error of hour range");
		}
	}

	void setMinTwelve(const size_t& min)
	{
		if (min <= 60)
		{
			if (hour == 23 && getMin() == 60)
			{
				setHour(0);
				setMin(0);
			}

			this->min = min;
		}
		else {
			throw exception("Error of min range");
		}
	}

	/*void setHourTwelve(const size_t& hour) override
	{
		setHour(hour);
	}

	void setMinTwelve(const size_t& min) override
	{
		setMin(min);
	}*/
};
