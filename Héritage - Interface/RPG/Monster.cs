using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public class Monster : Encounter
    {
        public Characteristics characteristics { get; set; }
        public Monster(Characteristics _characteristics)
        {
            this.characteristics = _characteristics;
        }

        public override string ToString()
        {
            return "Monstre :" + characteristics.Name
                    + "\nPoints de vie :" + characteristics.HealthPoints
                    + "\nPoints d'attaques :" + characteristics.AttackPoints
                    + "\nVitesse :" + characteristics.SpeedPoints
                    + "\n";
        }

        public override void Meet(Aventurer aventurer)
        {
            System.Console.WriteLine("Un monstre apparait !\nLe combat à mort commence !");

            while (aventurer.characteristics.HealthPoints > 0 && this.characteristics.HealthPoints > 0)
            {
                this.characteristics.HealthPoints -= aventurer.characteristics.AttackPoints;
                aventurer.characteristics.HealthPoints -= this.characteristics.AttackPoints;
            }

            if (aventurer.characteristics.HealthPoints > 0)
            {
                System.Console.WriteLine($"Vous l'avez échappé belles, il vous reste {aventurer.characteristics.HealthPoints} PV\n");
            }
            else
            {
                System.Console.WriteLine("Dommage, vous êtes mort...\n");
            }

        }
    }
}