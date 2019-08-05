using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Space_Game.Enumerations;

namespace Space_Game
{
    public class Player
    {
        public Player()
        {
            this.CurrentLocation = Planets.Binopoly;
            this.InventoryList = new List<Inventory>();
            Inventory fuel = new Inventory { Quantity = 20, InventoryItem = InventoryItems.Fuel};
            Inventory silver = new Inventory { Quantity = 10, InventoryItem = InventoryItems.Silver };
            Inventory iron = new Inventory { Quantity = 5, InventoryItem = InventoryItems.Iron };
            this.InventoryList.Add(fuel);
            this.InventoryList.Add(silver);
            this.InventoryList.Add(iron);
        }
        //public void StartInv()
        //{
        //    var inv = new Inventory();
        //    inv.fuel = 20;
        //    inv.silver = 10;
        //    inv.iron = 5;
        //    Console.WriteLine("You have in your inventory:");
        //    Console.WriteLine($"Silver - {inv.silver}");
        //    Console.WriteLine($"Fuel - {inv.fuel}");
        //    Console.WriteLine($"Iron - {inv.iron}");
        //}
        public Planets CurrentLocation { get; set; }
        public List<Inventory> InventoryList { get; set; }

    }
}