using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Array2DUtils
    {
        public int[,] Arr { get; set; }

        public Array2DUtils(int[,] matrix)
        {
            Arr = matrix;
        }

        // Пример функции, преобразующей исходный массив и возвращающей результат
        // Данная функция увеличивает значения всех элемнетов на единицу
        public int[,] IncreaseElementsValue()
        {
            int rowsCount = Arr.GetLength(0);
            int columnsCount = Arr.GetLength(1);

            // Создаём новый массив, в который и будем записывать новые значения,
            // чтобы исходный менять не приходилось.
            int[,] newArr = new int[rowsCount, columnsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    newArr[i, j] = Arr[i, j] + 1;
                }
            }

            return newArr;
        }

        // Пример функции, которая каким-то образом анализирует исходный массив
        // и возвращает результат. Содержимое массива не изменяется
        // Данная функция вовзращает наименьшее значение в массиве
        public int GetMinElement()
        {
            // Предполагается, что массив не пуст
            int minElement = Arr[0, 0];

            int rowsCount = Arr.GetLength(0);
            int columnsCount = Arr.GetLength(1);

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    if (Arr[i, j] < minElement)
                    {
                        minElement = Arr[i, j];
                    }
                }
            }

            return minElement;
        }
    }
}
