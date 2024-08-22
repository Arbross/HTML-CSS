#include <iostream>
#include <map>
using namespace std;

enum class States { CLOSED, OPENED };

typedef string LOGIN;
typedef string PASSWORD;

__interface IDoor
{
    void close();
    void open();
};

class Door : public IDoor
{
public:
    Door(const bool& state = false)
        : state(state) {}

    void open() override
    {
        cout << "Open door." << endl;
        state = true;
    }

    void close() override
    {
        cout << "Close door." << endl;
        state = false;
    }

    bool getStatus() const
    {
        return state;
    }

    void showStatus() const
    {
        cout << "Status : " << boolalpha << state << endl;
    }
private:
    bool state;
};

class SecureProxy
{
public:
    SecureProxy(LOGIN login, PASSWORD password)
    {
        door = new Door();
        users.emplace(login, password);
    }

    SecureProxy(Door* door_)
    {
        door_ = door;
    }

    void open(LOGIN login, PASSWORD psw)
    {
        if (getAuthorisation(login, psw))
        {
            door->open();
        }
    }

    void close()
    {
        door->close();
    }

    bool getAuthorisation(LOGIN login, PASSWORD psw)
    {
        for (const auto& elem : users)
        {
            if (elem.first == login and elem.second == psw)
            {
                cout << "Succsessfuly autorisation!" << endl;
                return true;
            }
        }

        return false;
    }

    ~SecureProxy()
    {
        door = nullptr;
        delete[] door;
    }
private:
    Door* door;
    map<LOGIN, PASSWORD> users;
};

int main()
{
    
    return 0;
}
