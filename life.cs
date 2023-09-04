using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoLLibrary
{
    public static class life
    {
        public static bool running = false;
        public static int delay = 0;
        public static int numRows;
        public static int numCols;
        //current field
        public static globl reality = new();
        //field at start of Generation
        public static globl oldWorld = new();
        //checks the neighboring cells in OldWorld to change the state in reality

        public static void initiateField(int Rows, int Cols)
        {
            numRows = Rows;
            numCols = Cols;
            reality.emptyfield(Rows, Cols);
            oldWorld.emptyfield(Rows, Cols);

        }
        public static void cellLife(int row, int col)
        {
            bool livin = false;
            if (oldWorld.field[row, col])
            {
                livin = oldWorld.checkSurvive(row, col);
            }
            else
            {
                livin = oldWorld.checkBorn(row, col);
            }
            reality.field[row, col] = livin;
        }
        //changes the field to the next Generation
        public static void pass()
        {
            oldWorld.field = (bool[,])(reality.field.Clone());
            //for (int r = 0; r < 10; r++)
            //{
            //    for (int c = 0; c < 10; c++)
            //    {
            //        oldWorld.field[r,c] = reality.field[r,c];
            //    }
            //}
            for (int r = 0; r < numRows; r++)
            {
                for (int c = 0; c < numCols; c++)
                {
                    cellLife(r, c);
                }
            }
        }
        //prints the field
        //my version:

        public static void print()
        {
            string lin = "";
            for (int i = 0; i < numCols + 2; i++)
            {
                lin += ".";
            }
            Console.WriteLine(lin);
            for (int n = 0; n < numRows; n++)
            {
                string linux = "";
                linux += ".";
                for (int f = 0; f < numCols; f++)
                {
                    linux += Convert.ToString(Convert.ToInt16(life.reality.field[n, f]));
                }
                linux += ".";
                Console.WriteLine(linux);
            }
            Console.WriteLine(lin);
        }

        //optimized by ChatGPT:
        /*
        public static void print()
        {
            int width = numCols+2;
            int height = numRows;

            string line = new string('.', width);
            Console.WriteLine(line);

            for (int n = 0; n < height; n++)
            {
                StringBuilder rowBuilder = new StringBuilder(".");
                for (int f = 0; f < width - 2; f++)
                {
                    rowBuilder.Append(Convert.ToString(Convert.ToInt16(life.reality.field[n, f])));
                }
                rowBuilder.Append(".");
                Console.WriteLine(rowBuilder.ToString());
            }

            Console.WriteLine(line);
        }
        */
    }
}
