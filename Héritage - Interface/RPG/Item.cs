using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public class Item : Encounter
    {
        public int HealPoints { get; set; }
        public Item()
        {
            Random random = new Random();
            HealPoints = random.Next(1,6);
        }


        public override void Meet(Aventurer aventurer)
        {
            AddHP HpAdder = new AddHP();
            HpAdder.Trigger(aventurer.characteristics);
        }
        
        
    }

}