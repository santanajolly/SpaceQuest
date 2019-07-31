using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game
{
    class BugBay
    {
        public void Planet()
        {
            Console.WriteLine("You have warped to Bug Bay!");
        }

        public void Sell()
        {
            Console.WriteLine("We buy:");
            Console.WriteLine("Iron - 100");
            Console.WriteLine("Silver - 500");
        }

        public void Buy()
        {
            Console.WriteLine("We sell:");
            Console.WriteLine("Coal - 100");
            Console.WriteLine("Diamond - 500");
        }
    }
}