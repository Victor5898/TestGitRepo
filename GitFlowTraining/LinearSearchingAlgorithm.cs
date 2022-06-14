using System;

namespace GitFlowTraining
{
    public class LinearSearchingAlgorithm : ISearchingAlgorithm
    {

        public T findElement<T>(T[] arr, T element) where T : IComparable<T>
        {
            foreach (var arrElement in arr)
            {
                if (arrElement.Equals(element))
                {
                    return arrElement;
                }
            }

            return default(T);
        }

    }
}
