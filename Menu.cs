using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml.Serialization;
using static Space_Game.Enumerations;


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

        public void Options()
        {
            Enumerations.Navigation choice;
            Console.WriteLine("Would you like to Buy, Sell, Travel, Check Inventory, or See Map?");
            Console.WriteLine("Press 1 to Buy");
            Console.WriteLine("Press 2 to Sell");
            Console.WriteLine("Press 3 to Travel");
            Console.WriteLine("Press 4 to Check Inventory");
            Console.WriteLine("Press 5 to See Map");
            Console.WriteLine("Press 6 to End Game");
            choice = (Navigation) (Convert.ToInt32(Console.ReadLine()));

            switch (choice)
            {
                case Navigation.Buy:
                {
                    //planetLocation();
                    break;
                }

                case Navigation.Sell:
                {
                    break;
                }

                case Navigation.Travel:
                {
                    int currentPlanet = CurrentLocation();
                    break;
                }

                case Navigation.Inventory:
                {
                    break;
                }

                case Navigation.Map:
                {
                    break;
                }

                case Navigation.None:
                {
                    break;
                }
            }
        }

        //public int planetLocation()
        //{
        //    Planets 
        //    switch ()
        //    {
        //        case Planets.Binopoly:
        //        {
        //            break;
        //        }

        //        case Planets.BugBay:
        //        {
        //            break;
        //        }

        //        case Planets.HashCity:
        //        {
        //            break;
        //        }

        //        case Planets.HeapStreet:
        //        {
        //            break;
        //        }

        //        case Planets.Typotopia:
        //        {
        //            break;
        //        }
        //    }
        //}

        public int CurrentLocation()
        {
            Console.WriteLine("Which planet would you like to warp to?");
            Console.WriteLine("Press 1 to warp to Binopoly");
            Console.WriteLine("Press 2 to warp to Bug Bay");
            Console.WriteLine("Press 3 to warp to Hash City");
            Console.WriteLine("Press 4 to warp to Heap Street");
            Console.WriteLine("Press 5 to warp to Typotopia");
            Console.WriteLine("Press 6 to End Game");

            int currentLocation = Convert.ToInt32(Console.ReadLine());
            return currentLocation;
        }
    }
}



