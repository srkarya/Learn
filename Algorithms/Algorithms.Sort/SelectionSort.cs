namespace Algorithms.Search
{
	#region Class Selection Sort

	/// <summary>
	/// Class Selectio Sort
	/// </summary>
	public class SelectionSort
	{
		#region Public methods

		#region Sort
		/// <summary>
		/// To sort an integer array.
		/// </summary>
		/// <param name="arr">Integer array</param>
		public void Sort(int[] arr)
		{
			var n = arr.Length;
			for (var i = 0; i < n - 1; i++)
			{
				var mid_idx = i;
				for (var j = i + 1; j < n; j++)
				{
					if (arr[j] < arr[mid_idx])
					{
						mid_idx = j;
					}
				}

				var x = arr[mid_idx];
				arr[mid_idx] = arr[i];
				arr[i] = x;
			}
		}

		#endregion

		#endregion
	}

	#endregion
}
