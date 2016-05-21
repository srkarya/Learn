namespace Algorithms.Search
{
    public class SelectionSort
    {
        public int[] Sort(int[] arr) {
            var n = arr.Length;
            for (var i = 0; i < n - 1; i++) {
                var mid_idx = i;
                for (var j = i + 1; j < n; j++) {
                    if (arr[j] < arr[mid_idx]) {
                        mid_idx = j;
                    }
                }

                var x = arr[mid_idx];
                arr[mid_idx]= arr[i];
                arr[i] = x;
            }
            return arr;
        }
    }
}
