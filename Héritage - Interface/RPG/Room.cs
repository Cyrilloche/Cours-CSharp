using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public class Room
    {
        public string? Name { get; set; }
        public static List<Encounter> ListEncounters { get; set; } = new List<Encounter>();
        
    
        public Room()
        {
            AddEncounterToARoom();
        }

        public Encounter AddEncounterToARoom()
        {
            var encounter = SelectARandomObject();
            ListEncounters.Add(encounter);
            return encounter;
        }

        public Encounter SelectARandomObject()
        {
            Random random = new Random();
            int index = random.Next(0,3);
            Encounter? randomObject = null; 

            switch (index)
            {
                case 0:
                    randomObject = new Item();
                    break;
                case 1:
                    randomObject = new Trap();
                    break;
                case 2:
                    randomObject = new Monster(new Characteristics("Monstre", 20,2,1));
                    break;
            }

            return randomObject;

            
        }

    }
}