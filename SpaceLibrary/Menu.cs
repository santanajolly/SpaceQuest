using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using static SpaceLibrary.Enumerations;
using System.Linq;


namespace SpaceLibrary
{
    public class Menu
    {
        public void Start()
        {
            Console.WriteLine(@"
                 ____ ____ ____ ____ ____ _________ ____ ____ ____ _________ ____ ____ ____ ____ 
                ||Q |||u |||e |||s |||t |||       |||f |||o |||r |||       |||H |||o |||m |||e ||
                ||__|||__|||__|||__|||__|||_______|||__|||__|||__|||_______|||__|||__|||__|||__||
                |/__\|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/__\|
                                    ");
            //Thread.Sleep(3000);
            Console.WriteLine("You have warped too far from home. You need to earn enough coins to get Home!");
            //Thread.Sleep(5000);
            Console.Clear();
        }

        public void Options(Player player)
        {
            var menu = new Menu();
            var planet = new Planet(player.CurrentLocation);
           
           
            Enumerations.Navigation choice;
            Console.WriteLine("Would you like to Buy, Sell, Travel, or Check Inventory?");
            Console.WriteLine("Press 1 to Buy");
            Console.WriteLine("Press 2 to Sell");
            Console.WriteLine("Press 3 to Travel");
            Console.WriteLine("Press 4 to Check Inventory");
            Console.WriteLine("Press 5 to End Game");
            choice = (Navigation) (Convert.ToInt32(Console.ReadLine()));
            switch (choice)
            {
                case Navigation.Buy:
                {

                    planet.Buy(player);
                    break;
                }
                case Navigation.Sell:
                {
                    break;
                }
                case Navigation.Travel:
                {
                    CurrentLocation(player);
                    //InventoryItems.Fuel -= 2;
                   
                    break;
                }
                case Navigation.Inventory:
                {
                    //TODO
                    
                    break;
                }

                case Navigation.EndGame:
                {
                    Console.WriteLine("Are you sure you want to quit?");
                    Console.WriteLine("Type Y for yes and N for no");
                    string answer = Console.ReadLine();
                    if (answer.ToUpper() == "Y")
                    {
                        break;
                    }
                    else if (answer.ToUpper() == "N")
                    {
                        menu.Options(player);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid response. Try again.");
                        break;
                    }
                }

                case Navigation.None:
                {
                    break;
                }
            }
        }
        public Enumerations.Planets CurrentLocation(Player player)
        {
            var menu = new Menu();
           
            Console.Clear();
            Console.WriteLine("Which planet would you like to warp to?");
            Console.WriteLine("Press 1 to warp to Binopoly");
            Console.WriteLine("Press 2 to warp to Bug Bay");
            Console.WriteLine("Press 3 to warp to Hash City");
            Console.WriteLine("Press 4 to warp to Heap Street");
            Console.WriteLine("Press 5 to warp to Typotopia");
            Console.WriteLine("Press 6 to go back to the menu");
            Console.WriteLine("Press 7 to End Game");

            Planets currentLocation = (Planets)(Convert.ToInt32(Console.ReadLine()));
            player.CurrentLocation = currentLocation;
            var fuel = player.InventoryList.FirstOrDefault(x => x.InventoryItem == InventoryItems.Fuel);
            switch (currentLocation)
            {
                case Planets.Binopoly:
                {
                   
                    Console.WriteLine($"You have warped to {currentLocation}!");
                    Console.WriteLine("We Sell:");
                    Console.WriteLine("Coal - 50 coins ");
                    Console.WriteLine("We Buy:");
                    Console.WriteLine("Gold - 100");
                    Console.WriteLine("Silver - 100");
                    if (fuel != null)
                    {
                        Console.WriteLine($"You fuel is {fuel.Quantity}");
                    }
                    //else end game 
                    menu.Options(player);
                    return currentLocation;
                    }
                case Planets.BugBay:
                {
                    Console.WriteLine($"You have warped to {currentLocation}!");
                    Console.WriteLine("We Sell:");
                    Console.WriteLine("Iron - 50 coins ");
                    Console.WriteLine("Coal - 100 coins ");
                    Console.WriteLine("We Buy:");
                    Console.WriteLine("Silver - 100");
                    Console.WriteLine("Iron - 100");
                    Console.WriteLine($"You fuel is {InventoryItems.Fuel}");
                    menu.Options(player);
                    return currentLocation;
                        //make case statements. give user number options for what they want to buy
                    }
                case Planets.HashCity:
                {
                    Console.WriteLine($"You have warped to {currentLocation}!");
                    Console.WriteLine("We Sell:");
                    Console.WriteLine("Diamonds - 100 coins ");
                    Console.WriteLine("Iron - 100 coins ");
                    Console.WriteLine("We Buy:");
                    Console.WriteLine("Silver - 100");
                    Console.WriteLine($"You fuel is {InventoryItems.Fuel}");
                    menu.Options(player);
                    return currentLocation;
                    }
                case Planets.HeapStreet:
                {
                    Console.WriteLine($"You have warped to {currentLocation}!");
                    Console.WriteLine("We Sell:");
                    Console.WriteLine("Steel - 100 coins ");
                    Console.WriteLine("Fuel - 100 coins ");
                    Console.WriteLine("We Buy:");
                    Console.WriteLine("Coal - 100");
                    Console.WriteLine("Iron - 100");
                    Console.WriteLine($"You fuel is {InventoryItems.Fuel}");
                    menu.Options(player);
                    return currentLocation;
                    }

                case Planets.Typotopia:
                {
                    Console.WriteLine($"You have warped to {currentLocation}!");
                    Console.WriteLine("We Sell:");
                    Console.WriteLine("Steel - 100 coins ");
                    Console.WriteLine("Fuel - 100 coins ");
                    Console.WriteLine("We Buy:");
                    Console.WriteLine("Coal - 100");
                    Console.WriteLine("Iron - 100");
                    menu.Options(player);
                    return currentLocation;
                    }

                case Planets.Menu:
                {
                    Console.Clear();
                    menu.Options(player);
                    break;
                }

                case Planets.EndGame:
                {
                    Console.WriteLine("Are you sure you want to quit?");
                    Console.WriteLine("Type Y for yes and N for no");
                    string answer = Console.ReadLine();
                    if (answer.ToUpper() == "Y")
                    {
                        break;
                    }
                    else if (answer.ToUpper() == "N")
                    {
                        menu.Options(player);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid response. Try again.");
                        CurrentLocation(player);
                        break;
                    }
                }
                default:
                {
                    Console.WriteLine("Invalid response. Try again.");
                    CurrentLocation(player);
                    break;
                }

            }
            return currentLocation;
        }
    }
}



