using System;

namespace GTaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TileGrid tileGrid = new TileGrid(5);

            //GameMenu.ShowGameModes();
            //GameMenu.SetCurrentGameMode();

            tileGrid.ShowGrid();

            

            Box box = new Box();
            box.SetBoxInTail(1, 2, 2, tileGrid);
            tileGrid.ShowGrid();













            Console.ReadKey();
        }
    }
}
