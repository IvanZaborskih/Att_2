using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Matrix
    {
        public int[,] inMatrix { get; set; }
        public Matrix(int[,] matrix)
        {
            this.inMatrix = matrix;
        }

        public int[,] Sdvig(int n)
        {
            int maxColumn = inMatrix.GetLength(1);
            int maxRow = inMatrix.GetLength(0);
            int[,] newMatrix = new int[maxRow, maxColumn];

            for (int c = 0; c < maxColumn; c++)
            {
                for (int r = 0; r < maxRow; r++)
                {
                    int newColumn;
                    int newRow;
                    if ((c - n) >= 0)
                    {
                        newColumn = c - n;
                    }
                    else
                    {
                        newColumn = maxColumn + (c - n);
                    }

                    if ((r + n) < maxRow)
                    {
                        newRow = r + n;
                    }
                    else
                    {
                        newRow = (r + n) - maxRow;
                    }
                    newMatrix[newRow, newColumn] = inMatrix[r, c];
                }
            }
            return newMatrix;
        }
    }
}

