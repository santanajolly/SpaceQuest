using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class Binopoly
    {
        public void Planet()
        {
            var Men = new Menu();
            Console.WriteLine("You have warped to Binopoly!");
            //TODO: Tell user what this Planet() sells and buys

            //TODO: and then give menu
            //TODO call menu 
            Console.WriteLine("");
            var inv = new Inventory();
            inv.coal = 5;


        }

        public void Sell()
        {
            Console.WriteLine("We buy:");
            Console.WriteLine("Silver - 100");
            Console.WriteLine("Gold - 500");
        }

        public void Buy()
        {
            Console.WriteLine("We sell:");
            Console.WriteLine("Coal - 100");
            Console.WriteLine("Diamond - 500");
        }
    }
}