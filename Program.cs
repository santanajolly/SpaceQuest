using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SpaceLibrary;
using static SpaceLibrary.Enumerations;

namespace Space_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var menu = new Menu();
            menu.Start();
            menu.Options(player);
            

            

        }
    }

}