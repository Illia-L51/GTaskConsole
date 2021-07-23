using System.Collections;
using System.Collections.Generic;


namespace GTaskConsole
{
    public class Tile
    {
        private int xCoord;
        private int yCoord;

        public bool isOccupied = false;

        public Tile(int y, int x)
        {
            xCoord = x;
            yCoord = y;
        }
    }
}
