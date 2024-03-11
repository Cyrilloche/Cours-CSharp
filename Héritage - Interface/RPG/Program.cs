using System;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aventurer cyril = new Aventurer(new Characteristics("Cyril", 100, 15, 10));
            Monster monstre = new Monster(new Characteristics("Tintin", 20, 5, 2));

            Dungeon dungeon = new Dungeon("Donjon de l'enfer", 20, cyril);
            dungeon.AddRooms();
            System.Console.WriteLine(cyril);
            dungeon.BrowseDungeon();



            System.Console.WriteLine();


            System.Console.WriteLine(cyril);

            Console.ReadLine();
        }

    }
}