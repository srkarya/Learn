﻿#region Namespace
using System;
#endregion

namespace Algorithms
{
	#region Class Heap Sort

	/// <summary>
	/// Class Heap Sort
	/// </summary>
	public class HeapSortMain
	{
		#region Private constants

		/// <summary>
		/// Constant
		/// </summary>
		private const string zero = "0";

		#endregion

		#region Public methods

		///// <summary>
		///// Beginning of the method starts here
		///// </summary>
		///// <param name="args">Input arguments</param>
		//public static void Main(string[] args)
		//{
		//	HeapSort hs = new HeapSort();
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
		//		hs.Sort(arr);
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

		#endregion
	}

	#endregion
}
