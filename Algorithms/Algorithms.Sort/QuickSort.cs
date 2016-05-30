namespace Algorithms.Sort
{
	#region Class Quick Sort

	/// <summary>
	/// Class Quick Sort
	/// </summary>
	public class QuickSort
	{
		#region Public methods

		/// <summary>
		/// To sort an integer array
		/// </summary>
		/// <param name="arr">Integer array</param>
		/// <param name="low">Index</param>
		/// <param name="high">Index</param>
		public void Sort(int[] arr, int low, int high)
		{
			if (low < high)
			{
				var pivot = Partition(arr, low, high);
				Sort(arr, low, pivot - 1);
				Sort(arr, pivot + 1, high);
			}
		}

		#endregion

		#region Private methods

		/// <summary>
		/// To find the index of the pivot element
		/// after placing it at correct position in an array.
		/// </summary>
		/// <param name="arr">Integer array</param>
		/// <param name="low">Index</param>
		/// <param name="high">Index</param>
		/// <returns>Index</returns>
		private int Partition(int[] arr, int low, int high)
		{
			var pivot = arr[high];
			var i = low - 1;
			for (var j = low; j <= high - 1; j++)
			{
				if (arr[j] <= pivot)
				{
					i++;

					var swap = arr[i];
					arr[i] = arr[j];
					arr[j] = swap;
				}
			}
			var temp = arr[i + 1];
			arr[i + 1] = arr[high];
			arr[high] = temp;

			return i + 1;
		}

		#endregion
	}

	#endregion
}
