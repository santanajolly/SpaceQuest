using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Player
    {
        public void StartInv()
        {
            var inv = new Inventory();
            inv.fuel = 20;
            inv.silver = 10;
            inv.iron = 5;
            Console.WriteLine("You have in your inventory:");
            Console.WriteLine($"Silver - {inv.silver}");
            Console.WriteLine($"Fuel - {inv.fuel}");
            Console.WriteLine($"Iron - {inv.iron}");
        }

    }
}