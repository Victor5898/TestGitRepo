using System;

namespace GitFlowTraining
{
    public class LinearSearchingAlgorithm : ISearchingAlgorithm
    {

        private uint counter = 0;

        public T findElement<T>(T[] arr, T element) where T : IComparable<T>
        {
            counter = 0;

            foreach (var arrElement in arr)
            {
                counter++;

                if (arrElement.Equals(element))
                {
                    return arrElement;
                }
            }

            return default(T);
        }

        public uint IterationCountForLastExecution()
        {
            return counter;
        }
    }
}
