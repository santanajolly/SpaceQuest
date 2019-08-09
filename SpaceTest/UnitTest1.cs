using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceLibrary;
using static SpaceLibrary.Enumerations;
using System.Linq;

namespace SpaceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlayerPlanet()
        {
            Player player = new Player();
            Assert.AreEqual(Planets.Binopoly, player.CurrentLocation);

        }
        [TestMethod]
        public void TestPlayerInventoryList()
        {
            //Player player = new Player();
            //Inventory iron = new Inventory { Quantity = 5, InventoryItem = InventoryItems.Iron };
            //var i = player.InventoryList.FirstOrDefault(x => x.InventoryItem == InventoryItems.Iron);
            //Assert.AreSame(iron,i);

        }
    }
}
