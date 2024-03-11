using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public class Characteristics
    {
        public string Name { get; set; }
        
        public int HealthPoints { get; set; }
        
        public int AttackPoints  { get; set; }
        
        public int SpeedPoints { get; set; }

        public Characteristics(string name, int healthPoints, int attackPoints, int speedPoints)
        {
            Name = name;
            HealthPoints = healthPoints;
            AttackPoints = attackPoints;
            SpeedPoints = speedPoints;
        }

    }
}