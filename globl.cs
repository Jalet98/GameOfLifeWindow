using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoLLibrary
{
    public class globl
    {
        public bool[,] field = new bool[1, 1];

        public void emptyfield(int Rows, int Cols)
        {
            field = new bool[Rows, Cols];
        }
        //checks how many neighboring cells are alive
        //my version

        public int checkNeigbours(int row, int column, int Rows, int Cols)
        {
            int i = 0;
            if (row == 0)
            {

                if (column == 0)
                {

                    if (field[row, column + 1])
                        i++;

                    if (field[row + 1, column])
                        i++;

                    if (field[row + 1, column + 1])
                        i++;

                }
                else if (column == Cols - 1)
                {

                    if (field[row, column - 1])
                        i++;

                    if (field[row + 1, column])
                        i++;

                    if (field[row + 1, column - 1])
                        i++;

                }
                else
                {

                    if (field[row, column - 1])
                        i++;

                    if (field[row + 1, column])
                        i++;

                    if (field[row + 1, column - 1])
                        i++;

                    if (field[row + 1, column + 1])
                        i++;

                    if (field[row, column + 1])
                        i++;

                }

            }
            else if (row == Rows - 1)

            {

                if (column == 0)

                {

                    if (field[row, column + 1])
                        i++;

                    if (field[row - 1, column])
                        i++;

                    if (field[row - 1, column + 1])
                        i++;

                }
                else if (column == Cols - 1)

                {

                    if (field[row, column - 1])
                        i++;

                    if (field[row - 1, column])
                        i++;

                    if (field[row - 1, column - 1])
                        i++;

                }
                else

                {

                    if (field[row, column - 1])
                        i++;

                    if (field[row - 1, column])
                        i++;

                    if (field[row - 1, column - 1])
                        i++;

                    if (field[row - 1, column + 1])
                        i++;

                    if (field[row, column + 1])
                        i++;

                }

            }
            else

            {

                if (column == 0)

                {

                    if (field[row - 1, column])
                        i++;

                    if (field[row - 1, column + 1])
                        i++;

                    if (field[row, column + 1])
                        i++;

                    if (field[row + 1, column])
                        i++;

                    if (field[row + 1, column + 1])
                        i++;

                }
                else if (column == Cols - 1)

                {

                    if (field[row - 1, column])
                        i++;

                    if (field[row - 1, column - 1])
                        i++;

                    if (field[row, column - 1])
                        i++;

                    if (field[row + 1, column])
                        i++;

                    if (field[row + 1, column - 1])
                        i++;

                }
                else

                {

                    if (field[row, column - 1])
                        i++;

                    if (field[row - 1, column])
                        i++;

                    if (field[row - 1, column - 1])
                        i++;

                    if (field[row - 1, column + 1])
                        i++;

                    if (field[row, column + 1])
                        i++;

                    if (field[row + 1, column])
                        i++;

                    if (field[row + 1, column - 1])
                        i++;

                    if (field[row + 1, column + 1])
                        i++;

                }

            }

            return i;

        }


        //my exception handling version

        /*
        public int checkNeigbours(int row, int column)
        {
            int i = 0;
            try
            {
                if (field[row, column - 1])
                    i++;
            }
            catch { };

            try
            {
                if (field[row - 1, column])
                    i++;
            }
            catch { };

            try
            {
                if (field[row - 1, column - 1])
                    i++;
            }
            catch { };

            try
            {
                if (field[row - 1, column + 1])
                    i++;
            }
            catch { };

            try
            {
                if (field[row, column + 1])
                    i++;
            }
            catch { };

            try
            {
                if (field[row + 1, column])
                    i++;
            }
            catch { };

            try
            {
                if (field[row + 1, column - 1])
                    i++;
            }
            catch { };

            try
            {
                if (field[row + 1, column + 1])
                    i++;
            }
            catch { }; 



            return i;

        }

        */

        //ChatGPT version
        /*
         
        public int checkNeigbours(int row, int column)
        {
            int i = 0;
            int rowStart = Math.Max(0, row - 1);
            int rowEnd = Math.Min(life.numRows -1, row + 1);
            int colStart = Math.Max(0, column - 1);
            int colEnd = Math.Min(life.numCols, column + 1);

            for (int r = rowStart; r <= rowEnd; r++)
            {
                for (int c = colStart; c <= colEnd; c++)
                {
                    if (r != row || c != column)
                    {
                        if (field[r, c])
                        {
                            i++;
                        }
                    }
                }
           }

           return i;
        }
        */

        //checks if a specific living Cell will be alive in the next Generation
        public bool checkSurvive(int row, int col)
        {
            int liveNeighbours = checkNeigbours(row, col, life.numRows, life.numCols);
            return ((liveNeighbours == 2) || (liveNeighbours == 3));
        }

        //checks if a specific dead Cell will be alive in the next Generation
        public bool checkBorn(int row, int col)
        {
            return (3 == checkNeigbours(row, col, life.numRows, life.numCols));
        }
    }
}
