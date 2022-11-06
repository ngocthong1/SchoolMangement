using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Room 
    {
        public int id { get; set; }
        public Room(int idRoom)
        {
            this.id = idRoom;
        }
        public Room()
        {
        }
        public void display()
        {
            Console.WriteLine("id Room: " + this.id);
        }
        public Room createRoom()
        {
            Room room = new Room();
            Console.WriteLine("Please enter idRoom");
            room.id = int.Parse(Console.ReadLine());

            return room;
        }
        public Room updateIdRoom(Room room)    
        {
            Console.WriteLine("Please enter your new idRoom");
            room.id = int.Parse(Console.ReadLine());
            return room;
        }
    }
}
