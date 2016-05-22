#region Namespace
using Algorithms.Search;
using System;
#endregion

namespace Algorithms
{
	#region Class Selection Sort

	/// <summary>
	/// Class Selection Sort
	/// </summary>
	public class SelectionSortMain
	{
		#region Private constants

		/// <summary>
		/// Constant
		/// </summary>
		private const string zero = "0";

		#endregion

		#region Public methods

		//public static void Main(string[] args)
		//{
		//	SelectionSort ss = new SelectionSort();
		//	Console.WriteLine("Ënter array size");
		//	var inputSize = Console.ReadLine().Trim();
		//	var size = Convert.ToInt32(string.IsNullOrEmpty(inputSize) ? zero : inputSize);
		//	var arr = new int[size];
		//	Console.WriteLine("Enter array item/element(s)");

		//	for (var i = 0; i < size; i++)
		//	{
		//		var userInput = Console.ReadLine().Trim();
		//		arr[i] = Convert.ToInt32(string.IsNullOrEmpty(userInput) ? zero : userInput);
		//	}

		//	if (arr.Any())
		//	{
		//		ss.Sort(arr);
		//		Console.WriteLine("Sorted array:");
		//		Print(arr);
		//		Console.Read();
		//	}
		//	else
		//	{
		//		Console.WriteLine("Press any key to exit.");
		//		Console.Read();
		//	}
		//}

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

	#endregion
}
