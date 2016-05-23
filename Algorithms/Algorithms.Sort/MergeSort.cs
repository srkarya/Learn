namespace Algorithms.Sort
{
	#region Class Merge Sort

	/// <summary>
	/// Class Merge Sort
	/// </summary>
	public class MergeSort
	{
		#region Public methods

		/// <summary>
		/// To sort an integer array
		/// </summary>
		/// <param name="arr">Integer array</param>
		/// <param name="l">Left index</param>
		/// <param name="r">Right index</param>
		public void Sort(int[] arr, int l, int r)
		{
			if (l < r)
			{
				var m = (l + r) / 2;
				Sort(arr, l, m);
				Sort(arr, m + 1, r);
				Merge(arr, l, r, m);
			}
		}

		#endregion

		#region Private methods

		/// <summary>
		/// To merge an sorted array
		/// </summary>
		/// <param name="arr">Integer array</param>
		/// <param name="l">Left index</param>
		/// <param name="r">Right index</param>
		/// <param name="m">Middle index</param>
		private void Merge(int[] arr, int l, int r, int m)
		{
			// Find sizes of two subarrays to be merged
			int n1 = m - l + 1;
			int n2 = r - m;

			/* Create temp arrays */
			var left = new int[n1];
			var right = new int[n2];

			/*Copy data to temp arrays*/
			for (var x = 0; x < n1; ++x)
			{
				left[x] = arr[l + x];
			}
			for (var y = 0; y < n2; ++y)
			{
				right[y] = arr[m + 1 + y];
			}

			/* Merge the temp arrays */

			// Initial indexes of first and second subarrays
			int i = 0, j = 0;

			// Initial index of merged subarry array
			int k = l;
			while (i < n1 && j < n2)
			{
				if (left[i] <= right[j])
				{
					arr[k] = left[i];
					i++;
				}
				else
				{
					arr[k] = right[j];
					j++;
				}
				k++;
			}

			/* Copy remaining elements of L[] if any */
			while (i < n1)
			{
				arr[k] = left[i];
				i++;
				k++;
			}

			/* Copy remaining elements of R[] if any */
			while (j < n2)
			{
				arr[k] = right[j];
				j++;
				k++;
			}
		}

		#endregion
	}

	#endregion
}
