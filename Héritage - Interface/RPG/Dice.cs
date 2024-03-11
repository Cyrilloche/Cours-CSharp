using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public abstract class Dice
    {
        public int Result { get; set; }
        
        public Dice()
        {
            Result = ThrowDice();
        }
        
        public static int ThrowDice()
        {
            Random rand = new Random();
            int result = rand.Next(1,7);
            System.Console.WriteLine($"Résultat du lancé : {result}");
            return result;
        }

        public static int ThrowDice(int numberOdDice)
        {
            int total = 0;
            for (int i = 0; i < numberOdDice; i++)
            {
                total += ThrowDice();
            }
            System.Console.WriteLine($"Total des lancés : {total}");
            return total;
        }

    }
}