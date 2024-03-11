using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public class Dungeon
    {
        public string Name { get; set; }
        public int NumberOfRooms { get; set; }
        public Aventurer Aventurer { get; set; }
        public List<Room> Rooms { get; set; }
        
        public Dungeon(string name, int numberOfRooms, Aventurer aventurer)
        {
            Name = name;
            Aventurer = aventurer;
            NumberOfRooms = numberOfRooms;
            Rooms = new List<Room>();
        }

        public void AddRooms()
        {
            for (int i = 0; i < NumberOfRooms; i++)
            {
                Rooms.Add(new Room());
            }
        }

        public void BrowseDungeon()
        {
            foreach (Encounter encounter in Room.ListEncounters)
            {
                encounter.Meet(Aventurer);
            }
        }
    }
}