using Algorithms.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SelectionSortMain
    {
        private const string zero = "0";
        public static void Main(string[] args)
        {
            SelectionSort ss = new SelectionSort();
            Console.WriteLine("Ënter array size");
            var inputSize = Console.ReadLine().Trim();
            var size = Convert.ToInt32(string.IsNullOrEmpty(inputSize) ? zero : inputSize);
            var arr = new int[size];
            Console.WriteLine("Enter array item/element(s)");

            for (var i = 0; i < size; i++)
            {
                var userInput = Console.ReadLine().Trim();
                arr[i] = Convert.ToInt32(string.IsNullOrEmpty(userInput) ? zero : userInput);
            }

            if (arr.Length > 0)
            {
                ss.Sort(arr);
                Console.WriteLine("Sorted array:");
                Print(arr);
                Console.Read();
            }
            else
            {
                Console.WriteLine("Press any key to exit.");
                Console.Read();
            }
        }

        private static void Print(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
