using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsAndDataStructures.S01E03
{
    internal class QuickSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] array)
        {
            Sort(array, 0, array.Length-1);
        }
        static void Sort(T[] array, int left, int right)
        {
            
            //if (left == right) return;

            //int pivot = new Random().Next(left, right);

            //for(int i= left, j=right; i<=j;)
            //{
            //    while (array[left].CompareTo(array[pivot]) < 0)
            //    {
            //        i++;
            //    }
            //    while (array[right].CompareTo(array[pivot]) >= 0)
            //    {
            //        j--;
            //    }
            //    if (i <= j)
            //    {
            //        T temp = array[i];
            //        array[i] = array[j];
            //        array[j] = temp;
            //        i++;
            //        j--;
            //    }
            //}
            //Sort(array, left, pivot);
            //Sort(array, pivot + 1, right);
        }

        
    }
}
