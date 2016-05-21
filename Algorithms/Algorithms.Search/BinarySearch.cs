namespace Algorithms.Search
{
    #region Class BinarySearch

    /// <summary>
    /// Class Binary Search
    /// </summary>
    public class BinarySearch
    {
        #region Recursive Binary Search

        /// <summary>
        /// Recursive Binary Search
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <param name="l">Left index</param>
        /// <param name="r">Right index</param>
        /// <param name="x">Search item</param>
        /// <returns>To search an item in array and return index by recursive approach.</returns>
        public int Recursive(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }

                if (arr[mid] > x)
                {
                    return Recursive(arr, l, mid - 1, x);
                }
                return Recursive(arr, mid + 1, r, x);
            }
            return -1;
        }

        #endregion

        #region Iterative Binary Search

        /// <summary>
        /// Iterative binary search
        /// <param name="arr">Input array</param>
        /// <param name="l">Left index</param>
        /// <param name="r">Right index</param>
        /// <param name="x">Search item</param>
        /// <returns>To search an item in array and return index by iterative approach.</returns>
        public int Iterative(int[] arr, int x)
        {
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (arr[m] == x)
                {
                    return m;
                }

                if (arr[m] < x)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            return -1;
        }

        #endregion
    }
    #endregion
}
