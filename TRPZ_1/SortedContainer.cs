using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_1
{
    public class SortedContainer
    {
        public static int[] ShakerSort(int[] arr)
        {
            int temp;
            int left = 0;
            int right = arr.Length - 1;
            do
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }
                }
                left++;
            } while (left < right);
            return arr;
        }
    }
}
