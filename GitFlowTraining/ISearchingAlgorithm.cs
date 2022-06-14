using System;

namespace GitFlowTraining
{
    public interface ISearchingAlgorithm
    {
        T findElement<T>(T[] arr, T element) where T : IComparable<T>;

        uint IterationCountForLastExecution();
    }
}
