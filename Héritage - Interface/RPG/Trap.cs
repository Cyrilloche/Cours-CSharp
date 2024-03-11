using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public class Trap : Encounter
    {
        public int DamagePoints { get; set; }
        
        public Trap()
        {
            Random damagePoints = new Random();
            DamagePoints = damagePoints.Next(1,6);
        }

        public override void Meet(Aventurer aventurer)
        {
            System.Console.WriteLine("Vous êtes tombés dans un piège !");
           RemoveHP HPRemover = new RemoveHP();
            HPRemover.Trigger(aventurer.characteristics);
            
        }


    }
}