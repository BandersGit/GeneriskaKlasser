using System.Collections.Generic;
using System;

namespace GeneriskaKlasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature<string, int> c = new Creature<string, int>(); //Byter man innanför <> byts datatypen
            Creature<int, string> c2 = new Creature<int, string>();

            c.category = "2";
            c.hp = 2;

            c2.category = 2;
            c2.hp = "2";

            Queue<string> orders = new Queue<string>();

            orders.Enqueue("walk");
            orders.Enqueue("stand");
            orders.Enqueue("patrol");

            string order = orders.Dequeue();

            System.Console.WriteLine(order);

            Console.ReadLine();

            
        }
    }
}
