using AlgoritmsAndDataStructures.S01E01;
using AlgoritmsAndDataStructures.S01E03;

namespace AlgoritmsAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[] { 1, 7, 2, 9, 124, 83, 123, 0, 9, 8, 0, 0, 11, 51, 21, 10 };
            char[] chars = new char[] { 'a', 'h', 'q', 't', 'v', 'k', 'a', 'c', 'A', 'f', 'X', 'T', 'b', 'c', 'g' };
            QuickSort<int>.Sort(numbers);
            QuickSort<char>.Sort(chars);

            Console.WriteLine(String.Join(',',numbers));
            Console.WriteLine(String.Join(',', chars));
            Console.ReadLine();
        }
    }
}