using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class WorkWith2DArrays
    {
        public int[,] A { set; get; }

        public WorkWith2DArrays(int[,] array)
        {
            A = array;
        }

        public string AmountOfEven(int[,] arr)
        {
            int upEven = 0, downEven = 0;

            for (int row = 0; row <= arr.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= arr.GetUpperBound(1); col++)
                {
                    if (row < col && (arr[row, col] % 2) == 0) upEven++;
                    else if (row > col && (arr[row, col] % 2) == 0) downEven++;
                }
            }
            return upEven > downEven ? "up" : (upEven == downEven ? "equal" : "down");
        }
    }
}
