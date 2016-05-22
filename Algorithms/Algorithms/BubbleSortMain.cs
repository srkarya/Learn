#region Namespace
using Algorithms.Sort;
using System;
#endregion

namespace Algorithms
{
	#region Class Bubble Sort

	/// <summary>
	/// Class Bubblee Sort
	/// </summary>
	public class BubbleSortMain
	{
		#region Private constants

		/// <summary>
		/// Constant
		/// </summary>
		private const string zero = "0";

		#endregion

		#region Public methods

		///// <summary>
		///// Method execution starts here.
		///// </summary>
		///// <param name="args">Input arguments</param>
		//public static void Main(string[] args)
		//{
		//	BubbleSort bubblleSort = new BubbleSort();
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

		//	if (arr.Length > 0)
		//	{
		//		//bubblleSort.Sort(arr);
		//		bubblleSort.OptimizedSort(arr);
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
		/// To print an array.
		/// </summary>
		/// <param name="arr">Integer array</param>
		private static void Print(int[] arr)
		{
			for (var i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}

		#endregion
	}

	#endregion
}
