namespace Algorithms.Sort
{
	#region Class Bubble Sort

	/// <summary>
	/// Class Bubble Sort
	/// </summary>
	public class BubbleSort
	{
		#region Public methods

		#region Sort

		/// <summary>
		/// To sort an integer array.
		/// </summary>
		/// <param name="arr">Integer array</param>
		/// <returns></returns>
		public void Sort(int[] arr)
		{
			int n = arr.Length;
			for (var i = 0; i < n - 1; i++)
			{
				for (var j = 0; j < n - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						var temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
		}

		#endregion

		#region OptimizedSort

		/// <summary>
		/// To sort an integer array.
		/// </summary>
		/// <param name="arr">Integer array</param>
		public void OptimizedSort(int[] arr)
		{
			int n = arr.Length;
			bool hasSwapped = false;
			for (var i = 0; i < n - 1; i++)
			{
				hasSwapped = false;
				for (var j = 0; j < n - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						//Swap(arr, j, j + 1);
						Swap(ref arr[j], ref arr[j + 1]);
						hasSwapped = true;
					}
				}
				if (!hasSwapped)
				{
					break;
				}
			}
		}

		#endregion

		#endregion

		#region Private methods

		#region Swap

		/// <summary>
		/// Swap by index
		/// </summary>
		/// <param name="arr">Iteger array</param>
		/// <param name="x">Integer index</param>
		/// <param name="y">Integer index</param>
		private void Swap(int[] arr, int x, int y)
		{
			var temp = arr[x];
			arr[x] = arr[y];
			arr[y] = temp;
		}

		/// <summary>
		/// Swap by pointer
		/// </summary>
		/// <param name="x">Reference of integer</param>
		/// <param name="y">Reference of integer</param>
		private void Swap(ref int x, ref int y)
		{
			var temp = x;
			x = y;
			y = temp;
		}

		#endregion

		#endregion
	}

	#endregion
}
