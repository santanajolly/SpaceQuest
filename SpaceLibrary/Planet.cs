using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static SpaceLibrary.Enumerations;
using SpaceLibrary;


namespace SpaceLibrary
{
    public class Planet
    {
        
        private Player player;

        public Planets CurrentLocation { get; set; }
        public List<Inventory> InventoryList { get; set; }

        public Planet()
        {
            this.CurrentLocation = Planets.Binopoly;
        }

        public Planet(Planets currentLocation)
        {
            this.CurrentLocation = CurrentLocation;
        }

        public void Buy(Player player)
        {
            var menu = new Menu();
            Enumerations.InventoryItems buyoption;
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("Press 1 to buy Silver");
            Console.WriteLine("Press 2 to buy Iron");
            Console.WriteLine("Press 3 to buy Coal");
            Console.WriteLine("Press 4 to buy Gold");
            Console.WriteLine("Press 5 to buy Steel");
            Console.WriteLine("Press 6 to buy Diamond");
            Console.WriteLine("Press 7 to buy Fuel");

            buyoption = (InventoryItems) (int.Parse(Console.ReadLine()));
            switch (buyoption)
            {
                case InventoryItems.Silver when CurrentLocation == Planets.Binopoly || CurrentLocation == Planets.BugBay ||
                                                this.CurrentLocation == Planets.HeapStreet:
                    Console.WriteLine($"You have just bought {buyoption} on {CurrentLocation}");
                    break;
                case InventoryItems.Silver:
                    Console.WriteLine($"We do not sell {buyoption} on {CurrentLocation}");
                    menu.Options(player);
                    break;
                case InventoryItems.Iron when CurrentLocation == Planets.BugBay || CurrentLocation == Planets.HeapStreet:
                    Console.WriteLine($"You have just bought {buyoption} on {CurrentLocation}");
                    break;
                case InventoryItems.Iron:
                    Console.WriteLine($"We do not sell {buyoption} on {CurrentLocation}");
                    menu.Options(player);
                    break;
                case InventoryItems.Coal when CurrentLocation == Planets.HashCity:
                    Console.WriteLine($"You have just bought {buyoption} on {CurrentLocation}");
                    break;
                case InventoryItems.Coal:
                    Console.WriteLine($"We do not sell {buyoption} on {CurrentLocation}");
                    menu.Options(player);
                    break;
                case InventoryItems.Gold when CurrentLocation == Planets.Binopoly:
                    Console.WriteLine($"You have just bought {buyoption} on {CurrentLocation}");
                    break;
                case InventoryItems.Gold:
                    Console.WriteLine($"We do not sell {buyoption} on {CurrentLocation}");
                    menu.Options(player);
                    break;
                case InventoryItems.Steel when CurrentLocation == Planets.Typotopia:
                    Console.WriteLine($"You have just bought {buyoption} on {CurrentLocation}");
                    break;
                case InventoryItems.Steel:
                    Console.WriteLine($"We do not sell {buyoption} on {CurrentLocation}");
                    menu.Options(player);
                    break;
                case InventoryItems.Diamond when CurrentLocation == Planets.Typotopia:
                    Console.WriteLine($"You have just bought {buyoption} on {CurrentLocation}");
                    break;
                case InventoryItems.Diamond:
                    Console.WriteLine($"We do not sell {buyoption} on {CurrentLocation}");
                    menu.Options(player);
                    break;
                case InventoryItems.Fuel:
                {
                    player.InventoryList.FirstOrDefault(x => x.InventoryItem == InventoryItems.Fuel).Quantity+=6;
                    if (CurrentLocation == Planets.HashCity)
                    {
                        Console.WriteLine($"You have just bought {buyoption} on {CurrentLocation}");
                        //also a change 
                    }
                    else
                    {
                        Console.WriteLine($"We do not sell {buyoption} on {CurrentLocation}");
                        menu.Options(player);
                    }

                    break;
                    //this is a change
                }
            }



















            //    public Inventory Buy(InventoryItems item)
            //    {
            //        switch (this.CurrentLocation)
            //        {
            //            case InventoryItems.Coal:
            //                if(item == InventoryItems.Silver)
            //                {
            //                    return new Inventory { InventoryItem = InventoryItems.Silver, Price = 500, Quantity = 10 };
            //                }
            //                return new Inventory { InventoryItem = InventoryItems.Iron, Price = 500, Quantity = 10 };
            //            case Planets.HashCity:
            //                return new Inventory { InventoryItem = InventoryItems.Silver, Price = 100, Quantity = 50 };
            //            case Planets.HeapStreet:
            //                if (item == InventoryItems.Coal)
            //                {
            //                    return new Inventory { InventoryItem = InventoryItems.Coal, Price = 500, Quantity = 10 };
            //                }
            //                return new Inventory { InventoryItem = InventoryItems.Iron, Price = 100, Quantity = 50 };
            //            case Planets.Typotopia:
            //                if (item == InventoryItems.Diamond)
            //                {
            //                    return new Inventory { InventoryItem = InventoryItems.Diamond, Price = 500, Quantity = 10 };
            //                }
            //                return new Inventory { InventoryItem = InventoryItems.Steel, Price = 100, Quantity = 50 };
            //            default:
            //                return new Inventory { InventoryItem = InventoryItems.Coal, Price = 100, Quantity = 50 };
            //        }
            //    }
            //    public Inventory Sell(InventoryItems item)
            //    {
            //        switch (this.CurrentLocation)
            //        {
            //            case Planets.BugBay:
            //                if (item == InventoryItems.Iron)
            //                {
            //                    return new Inventory { InventoryItem = InventoryItems.Iron, Price = 500, Quantity = 10 };
            //                }
            //                return new Inventory { InventoryItem = InventoryItems.Coal, Price = 500, Quantity = 10 };
            //            case Planets.HashCity:
            //                if (item == InventoryItems.Diamond)
            //                {
            //                    return new Inventory { InventoryItem = InventoryItems.Diamond, Price = 500, Quantity = 10 };

            //                }
            //                return new Inventory { InventoryItem = InventoryItems.Iron, Price = 100, Quantity = 50 };
            //            case Planets.HeapStreet:
            //                if (item == InventoryItems.Fuel)
            //                {
            //                    return new Inventory { InventoryItem = InventoryItems.Fuel, Price = 500, Quantity = 10 };
            //                }
            //                return new Inventory { InventoryItem = InventoryItems.Steel, Price = 100, Quantity = 50 };
            //            case Planets.Typotopia:
            //                return new Inventory { InventoryItem = InventoryItems.Silver, Price = 100, Quantity = 50 };
            //            default:
            //                return new Inventory { InventoryItem = InventoryItems.Coal, Price = 100, Quantity = 50 };
            //        }
            //    }
        }
    }
}
