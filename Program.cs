using SpaceLibrary;

namespace Space_Game
{
    class Program
    {
        public static void Main(string[] args)
        {

            var player = new Player();
            var menu = new Menu();
            menu.Start();
            menu.Options(player);
        }
    }

}