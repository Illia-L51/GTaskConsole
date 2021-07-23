using System;
using System.Collections.Generic;
using System.Text;

namespace GTaskConsole
{
    class Box
    {
        private int initX;
        private int initY;



        //public Box(int x, int y)
        public Box()
        {

        }

        public void SetBoxInTail(int startY, int startX, int boxSize, TileGrid tileGrid)
        {
            Box box = new Box();

            for (int boxY = 0; boxY < boxSize; boxY++)
            {
                for (int boxX = 0; boxX < boxSize; boxX++)
                {
                    var x = startX + boxX;
                    var y = startY + boxY;
                    if (tileGrid.grid[y, x].isOccupied == false)
                    {
                        tileGrid.grid[y, x].isOccupied = true;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
