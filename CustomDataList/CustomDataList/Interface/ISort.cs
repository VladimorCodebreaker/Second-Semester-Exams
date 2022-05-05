using System;
using static CustomDataList.Implementation.Sort;
using CustomDataList.Object;

namespace CustomDataList.Interface
{
    public interface ISort
    {
        static void BubbleSort(SortDirection sortDirection, Student[] students, int option) => throw new NotImplementedException();

        static T Max<T, U>(IEnumerable<T> source, Func<T, U> field) where U : IComparable<U> => throw new NotImplementedException();

        static T Min<T, U>(IEnumerable<T> source, Func<T, U> field) where U : IComparable<U> => throw new NotImplementedException();
    }
}

