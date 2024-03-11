using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public class RemoveHP : ITrigerrable
    {
        public void Trigger(Characteristics characteristics)
        {
            int damagePoints = 5;

            int previousHealthPoints = characteristics.HealthPoints;
            int newHealthPoints = previousHealthPoints - damagePoints;

            if (newHealthPoints <= 0)
            {
                System.Console.WriteLine("Oh non, vous êtes mort.. !");
            } else
            {
                System.Console.WriteLine($"Dégâts subis ! \n{previousHealthPoints} => {newHealthPoints}\n");
            }
            
        }
    }
}