using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace LoginSys
{
    public class RentsService
    {
        public static void ShowFree(UserLoginDBEntities entities, string needSquare, string needDuration, ref DataGrid listBox)
        {
            int squareResult;
            DateTime dateResult;
            if (needSquare == null || !int.TryParse(needSquare, out squareResult) || needDuration == null || !DateTime.TryParse(Convert.ToString(needDuration), out dateResult))
            {
                if (needDuration == null || !DateTime.TryParse(Convert.ToString(needDuration), out dateResult))
                {
                    if (needSquare == null || !int.TryParse(needSquare, out squareResult))
                    {
                        MessageBox.Show("It isn't available Int type.");
                    }
                    MessageBox.Show("It isn't available DateTime type.");
                    return;
                }
                MessageBox.Show("It isn't available Int type.");
                return;
            }
            
            List<Room> availableRooms = null;
            foreach (Room item in entities.Rooms)
            {
                if (item.IsTaken == false)
                {
                    if (item.Square == needSquare && item.Duration == DateTime.Parse(needDuration))
                    {
                        availableRooms = new List<Room>();
                        availableRooms.Add(item);
                    }
                }
            }

            if (availableRooms == null)
            {
                MessageBox.Show("It is no available room like that you want.");
            }
            else
            {
                listBox.ItemsSource = availableRooms;
            }
        }

        public static void ShowOwn(UserLoginDBEntities entities, LoginAndRegistrationContext dataContext, ref DataGrid listBox)
        {
            if (dataContext.IsLogin == true)
            {
                List<Room> availableRents = new List<Room>();
                foreach (Rent item in entities.Rents)
                {
                    if (item.UserId == dataContext.user.Id)
                    {
                        if (item.Room.IsTaken == false)
                        {
                            item.Room.IsTaken = true;
                        }
                        availableRents.Add(item.Room);
                    }
                }

                listBox.ItemsSource = availableRents;
                dataContext.entities.SaveChanges();
            }
            else
            {
                MessageBox.Show("You aren't login.");
            }
        }

        public static void DeleteActive(UserLoginDBEntities entities, LoginAndRegistrationContext dataContext, Room selectedRoom, ref DataGrid listBox)
        {
            List<Room> availableRents = new List<Room>();
            foreach (Rent item in entities.Rents)
            {
                if (item.UserId == dataContext.user.Id)
                {
                    if (item.Room.IsTaken == false)
                    {
                        item.Room.IsTaken = true;
                    }
                    availableRents.Add(item.Room);
                }
            }

            foreach (Room item in availableRents)
            {
                if (item == selectedRoom)
                {
                    foreach (Room room_item in entities.Rooms)
                    {
                        if (room_item == item)
                        {
                            room_item.IsTaken = false;
                        }
                    }
                    Rent tmp = item.Rents.Where(x => x.Room == item).First();
                    entities.PastRents.Add(new PastRent() { UserId = tmp.UserId, RoomId = tmp.RoomId, Room = tmp.Room, User = tmp.User });
                    if (tmp.Room.Duration < DateTime.UtcNow)
                    {
                        entities.Rooms.Remove(item);
                        entities.Rents.Remove(tmp);
                    }
                    else
                    {
                        entities.Rents.Remove(tmp);
                    }
                }
            }

            listBox.ItemsSource = null;
            dataContext.entities.SaveChanges();
        }

        public static void ShowPastOwn(UserLoginDBEntities entities, LoginAndRegistrationContext dataContext, ref DataGrid listBox)
        {
            if (dataContext.IsLogin == true)
            {
                List<Room> availableRents = new List<Room>();
                foreach (PastRent item in entities.PastRents)
                {
                    if (item.UserId == dataContext.user.Id)
                    {
                        if (item.Room.IsTaken == false)
                        {
                            item.Room.IsTaken = true;
                        }
                        availableRents.Add(item.Room);
                    }
                }

                listBox.ItemsSource = availableRents;
                dataContext.entities.SaveChanges();
            }
            else
            {
                MessageBox.Show("You aren't login.");
            }
        }

    }
}
