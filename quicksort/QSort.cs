using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort
{
    class QSort
    {
        
        public void QuickSort(int[] array, int min, int max)
        {
            int pivot = -1;
            if (min < max)
            {
                pivot = GetPartition(array, min, max);
                if (pivot > 1)
                {
                    QuickSort(array, min, pivot -1);
                }

                if (pivot + 1 < max)
                {
                    QuickSort(array, pivot+1, max);
                }
            }
        }

        private void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        

        private int GetPartition(int[] array, int min, int max)
        {
            int pivot = -1;
            pivot = array[min];
            while (true)
            {
                while (array[min] < pivot)
                {
                    min++;
                }

                while (array[max] > pivot)
                {
                    max--;
                }

                if (min < max)
                {
                    Swap(array, min, max);
                }
                else
                {
                    return max;
                }
            }
        }

    }
}
