namespace Algorithms.Sort
{
	#region Class Heap Sort

	/// <summary>
	/// Class Heap Sort
	/// </summary>
	public class HeapSort
	{
		#region Public methods

		/// <summary>
		/// To sort an integer array
		/// </summary>
		/// <param name="arr">Integer array</param>
		public void Sort(int[] arr)
		{
			var n = arr.Length;
			for (var i = n / 2 - 1; i >= 0; i--)
			{
				Heapify(arr, n, i);
			}

			for (var i = n - 1; i >= 0; i--)
			{
				var swap = arr[0];
				arr[0] = arr[i];
				arr[i] = swap;
				Heapify(arr, i, 0);
			}
		}

		#endregion

		#region Private methods

		/// <summary>
		/// To heapify an integer array
		/// </summary>
		/// <param name="arr">Integer array</param>
		/// <param name="n">No of elements</param>
		/// <param name="i">index</param>
		private void Heapify(int[] arr, int n, int i)
		{
			var largest = i;
			var l = 2 * i + 1;
			var r = 2 * i + 2;

			if (l < n && arr[l] > arr[largest])
			{
				largest = l;
			}

			if (r < n && arr[r] > arr[largest])
			{
				largest = r;
			}

			if (largest != i)
			{
				var swap = arr[i];
				arr[i] = arr[largest];
				arr[largest] = swap;
				Heapify(arr, n, largest);
			}
		}

		#endregion
	}

	#endregion
}
