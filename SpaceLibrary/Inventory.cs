using static SpaceLibrary.Enumerations;

namespace SpaceLibrary
{
    public class Inventory
    {
        public InventoryItems InventoryItem { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}