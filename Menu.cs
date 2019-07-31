using System;
using System.Threading;

namespace Space_Game
{
    class Menu
    {
        public void Start()
        {
            Console.WriteLine(@"
                 ____ ____ ____ ____ ____ _________ ____ ____ ____ _________ ____ ____ ____ ____ 
                ||Q |||u |||e |||s |||t |||       |||f |||o |||r |||       |||H |||o |||m |||e ||
                ||__|||__|||__|||__|||__|||_______|||__|||__|||__|||_______|||__|||__|||__|||__||
                |/__\|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/__\|
                                                                                                                                                                      


                                    ");
            Thread.Sleep(3000);
            Console.WriteLine("You have warped too far from home. You need to earn enough coins to get Home!");
            Thread.Sleep(5000);
            Console.Clear();

        }

        public void End()
        {
            Console.WriteLine("Game Over");
            Console.ReadLine();
        }

        public void Win()
        {
            Console.WriteLine("You have made it home");

            //home
        }

        public void Game()
        {
            //TODO
        }

        public void Options()
        {
            Console.WriteLine("Would you like to Buy, Sell, Travel, Check Inventory, or See Map?");
            Console.WriteLine("Select 1 to Buy");

            //link to inventory
            Console.WriteLine("Select 2 to Sell");
            //link to inventory
            Console.WriteLine("Select 3 to Travel");
            //options to Planets
            //if statements for travel 
            //if fuel < 2 cannot travel 
            Console.WriteLine("Select 4 to Check Inventory");
            //link to inventory
            Console.WriteLine("Select 5 to See Map");
            //im going to make map 

            string option = Console.ReadLine();
            //switch methods 
        

    }
}
}



