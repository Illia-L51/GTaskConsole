using System;
using System.Collections;
using System.Collections.Generic;


namespace GTaskConsole
{
    public class TileGrid
    {
        private int Size { get; set; }
        // private int SizeX { get; set; }
        //  private int SizeY { get; set; }

        public Tile[,] grid;

        public TileGrid(int size)
        {
            Size = size;
            CreateGrid(Size);
        }

        private void CreateGrid(int size)
        {
            grid = new Tile[size, size];
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    grid[y, x] = new Tile(y, x);
                    //Console.WriteLine($"Tile created with coords: x={x}, y={y}");
                }
            }
            //Console.WriteLine($"___________________");
        }

        public void ShowGrid()
        {
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    if (grid[y, x].isOccupied == false)
                    {
                        //Console.Write($"| - |");
                        Console.Write($"x:{x} y:{y}" + "| - |");
                    }

                    if (grid[y, x].isOccupied == true)
                    {
                        //Console.Write($"| O |");
                        Console.Write($"x:{x} y:{y}" + "| O |");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("__________________________________");
        }

        public void ClickOnTile()
        {

        }
    }
}