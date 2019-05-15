using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            QSort qSort = new QSort();
            int[] array = new[] {123, 1, 3, 4, 12};
            int[] arrayNew = new[] { 123, 1, 3, 4, 12, 1,334};
            qSort.QuickSort(array, 0, array.Length-1);
            foreach (var i in array)
            {
                Console.Write(i.ToString()+" ");
            }

            Console.ReadKey();

            Array.Sort(arrayNew); 

            foreach (var i in arrayNew)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();
        }
    }
}
