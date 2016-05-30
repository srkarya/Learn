namespace Algorithms.Sort
{
	#region Class Radix Sort

	/// <summary>
	/// Class Radix Sort
	/// </summary>
	public class RadixSort
	{
		#region Public methods

		/// <summary>
		/// To sort an integer array
		/// </summary>
		/// <param name="arr">Integer array</param>
		public void Sort(int[] arr)
		{
			var n = arr.Length;
			if (n > 0)
			{
				var m = GetMax(arr, n);

				for (var exp = 1; m / exp > 0; exp *= 10)
				{
					CountSort(arr, n, exp);
				}
			}
		}

		#endregion

		#region Private methods

		/// <summary>
		/// To get the max integer item from an array
		/// </summary>
		/// <param name="arr">Integer array</param>
		/// <param name="n">Number of elements</param>
		/// <returns>Integer</returns>
		private int GetMax(int[] arr, int n)
		{
			var max = arr[0];
			for (var i = 1; i < n; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
			}
			return max;
		}

		/// <summary>
		/// To sort an integer by counting
		/// </summary>
		/// <param name="arr">Integer array</param>
		/// <param name="n">Number of elements</param>
		/// <param name="exp">Base value</param>
		private void CountSort(int[] arr, int n, int exp)
		{
			var output = new int[n];
			var count = new int[10];

			for (var i = 0; i < n; i++)
			{
				count[(arr[i] / exp) % 10]++;
			}

			for (var i = 1; i < 10; i++)
			{
				count[i] += count[i - 1];
			}

			for (var i = n - 1; i >= 0; i--)
			{
				output[count[(arr[i] / exp) % 10] - 1] = arr[i];
				count[(arr[i] / exp) % 10]--;
			}

			for (var i = 0; i < n; i++)
			{
				arr[i] = output[i];
			}
		}

		#endregion
	}

	#endregion
}
