using System;

namespace GitFlowTraining
{
    public class BinarySearchingAlgorithm : ISearchingAlgorithm
    {
        private uint iterationsCount;

        /**
         * arr must be sorted ASC
         * */
        public T findElement<T>(T[] arr, T element) where T : IComparable<T>
        {
            iterationsCount = 0;
            return BinarySearch(arr, 0, arr.Length - 1, element);
        }

        public uint IterationCountForLastExecution()
        {
            return iterationsCount;
        }

        private T BinarySearch<T>(T[] arr, int l, int r, T e) where T : IComparable<T>
        {
            iterationsCount++;
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid].Equals(e))
                {
                    return arr[mid];
                }

                if (arr[mid].CompareTo(e) == 1)
                {
                    return BinarySearch(arr, l, mid - 1, e);
                }
                else
                {
                    return BinarySearch(arr, mid + 1, r, e);
                }
            }

            return default(T);
        }
    }
}
