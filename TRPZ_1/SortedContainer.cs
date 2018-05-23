using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_1
{
    public class SortedContainer
    {
        public static int[] SortArray(int[] array)
        {
            int min, x, y = 0;
            for (int i = 0; i < array.Length; i++)
            {
                min = array[i];
                x = i;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (min > array[j + i + 1])
                    {
                        min = array[j + i + 1];
                        x = i + j + 1;
                    }   
                }

                y = array[i];
                array[i] = min;
                array[x] = y;
            }
            return array;
        }
    }
}
