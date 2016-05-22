using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sort;

namespace Algorithms
{
	public class MergeSortMain
	{
		#region Private constants

		/// <summary>
		/// Constant
		/// </summary>
		private const string zero = "0";

		#endregion

		#region Public methods

		public static void Main(string[] args)
		{
			MergeSort ms = new MergeSort();
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

			if (arr.Any())
			{
				ms.Sort(arr, 0, size - 1);
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

		#endregion

		#region Private methods

		/// <summary>
		/// Print
		/// </summary>
		/// <param name="arr">Ineger array</param>
		private static void Print(int[] arr)
		{
			for (var i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}

	#endregion
}
