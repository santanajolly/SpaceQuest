using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpaceLibrary.Enumerations;

namespace SpaceLibrary
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
        
        
        public Planets CurrentLocation { get; set; }
        public List<Inventory> InventoryList { get; set; }

    }
}