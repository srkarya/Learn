namespace Algorithms.Sort
{
	#region Public methods

	/// <summary>
	/// Class Insertion Sort
	/// </summary>
	public class InsertionSort
	{
		#region Sort

		/// <summary>
		/// To sort integer array
		/// </summary>
		/// <param name="arr">Integer array</param>
		public void Sort(int[] arr)
		{
			int n = arr.Length;
			for (var i = 1; i < n; ++i)
			{
				var j = i - 1;
				var key = arr[i];
				while (j >= 0 && arr[j] > key)
				{
					arr[j + 1] = arr[j];
					j = j - 1;
				}
				arr[j + 1] = key;
			}
		}

		#endregion
	}

	#endregion
}
