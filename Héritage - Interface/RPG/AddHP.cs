using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public class AddHP : ITrigerrable
    {
        public void Trigger(Characteristics characteristics)
        {
            int maximumHealthPoints = 100;
            int healPoints = 5;

            int previousHealthPoints = characteristics.HealthPoints;
            int newHealthPoints = previousHealthPoints + healPoints;

            if(newHealthPoints > maximumHealthPoints){
                int realHealPoints = healPoints- (newHealthPoints - maximumHealthPoints);
                System.Console.WriteLine($"Potion de soin utilisé :\n+{realHealPoints} PV\n{previousHealthPoints} => {maximumHealthPoints}\n");
            } else {
                System.Console.WriteLine($"Potion de soin utilisé :\n{previousHealthPoints} => {newHealthPoints}\n");
            }
        }
        
    }
}