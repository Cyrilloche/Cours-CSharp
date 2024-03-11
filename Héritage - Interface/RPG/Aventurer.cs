using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public class Aventurer
    {
        public Characteristics characteristics { get; set; }
        public Aventurer(Characteristics _characteristics)
        {
            this.characteristics = _characteristics;
        }

        public override string ToString()
        {
            return "Nom du personnage :" + characteristics.Name
                    +"\nPoints de vie :" + characteristics.HealthPoints
                    +"\nPoints d'attaques :" + characteristics.AttackPoints
                    +"\nVitesse :" + characteristics.SpeedPoints
                    +"\n";
        }


    }
}