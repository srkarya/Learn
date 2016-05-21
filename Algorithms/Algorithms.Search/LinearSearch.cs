namespace Algorithms.Search
{
    #region Class Linear Search

    /// <summary>
    /// Class Linear Search
    /// </summary>
    public class LinearSearch
    {
        #region Search

        /// <summary>
        /// A linear search method to return index.
        /// </summary>
        /// <param name="arr">An input array</param>
        /// <param name="x">Search Item</param>
        /// <returns>An integer index value.</returns>
        public int Search(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        #endregion
    }

    #endregion
}
