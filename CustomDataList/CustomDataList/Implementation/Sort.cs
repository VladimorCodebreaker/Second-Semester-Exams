using System;
using CustomDataList.Interface;
using CustomDataList.Object;

namespace CustomDataList.Implementation
{
    public class Sort : ISort
    {
        public enum SortDirection { Ascending, Descending }

        public static T Max<T, U>(IEnumerable<T> source, Func<T, U> field) where U : IComparable<U>
        {
            if (source == null) throw new ArgumentNullException("source");
            bool first = true;
            T maxObj = default(T);
            U maxKey = default(U);
            foreach (var item in source)
            {
                if (first)
                {
                    maxObj = item;
                    maxKey = field(maxObj);
                    first = false;
                }
                else
                {
                    U currentKey = field(item);
                    if (currentKey.CompareTo(maxKey) > 0)
                    {
                        maxKey = currentKey;
                        maxObj = item;
                    }
                }
            }
            if (first) throw new InvalidOperationException("Sequence is empty.");
            return maxObj;
        }

        public static T Min<T, U>(IEnumerable<T> source, Func<T, U> field) where U : IComparable<U>
        {
            if (source == null) throw new ArgumentNullException("source");
            bool first = true;
            T minObj = default(T);
            U minKey = default(U);
            foreach (var item in source)
            {
                if (first)
                {
                    minObj = item;
                    minKey = field(minObj);
                    first = false;
                }
                else
                {
                    U currentKey = field(item);
                    if (currentKey.CompareTo(minKey) < 0)
                    {
                        minKey = currentKey;
                        minObj = item;
                    }
                }
            }
            if (first) throw new InvalidOperationException("Sequence is empty.");
            return minObj;
        }

        public static void BubbleSort(SortDirection sortDirection, Student[] students, int option)
        {
            if (sortDirection == SortDirection.Ascending)
            {
                for (int j = 0; j <= students.Length - 2; j++)
                {
                    for (int i = 0; i <= students.Length - 2; i++)
                    {
                        if (option == 1)
                        {
                            if (students[i].FirstName.CompareTo(students[i + 1].FirstName) > 0)
                            {
                                var temp = students[i + 1];
                                students[i + 1] = students[i];
                                students[i] = temp;
                            }
                        }
                        else if (option == 2)
                        {
                            if (students[i].LastName.CompareTo(students[i + 1].LastName) > 0)
                            {
                                var temp = students[i + 1];
                                students[i + 1] = students[i];
                                students[i] = temp;
                            }
                        }
                        else if (option == 3)
                        {
                            if (students[i].AverageScore.CompareTo(students[i + 1].AverageScore) > 0)
                            {
                                var temp = students[i + 1];
                                students[i + 1] = students[i];
                                students[i] = temp;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            else if (sortDirection == SortDirection.Descending)
            {
                for (int j = 0; j <= students.Length - 2; j++)
                {
                    for (int i = 0; i <= students.Length - 2; i++)
                    {
                        if (option == 4)
                        {
                            if (students[i].FirstName.CompareTo(students[i + 1].FirstName) < 0)
                            {
                                var temp = students[i + 1];
                                students[i + 1] = students[i];
                                students[i] = temp;
                            }
                        }
                        else if (option == 5)
                        {
                            if (students[i].LastName.CompareTo(students[i + 1].LastName) < 0)
                            {
                                var temp = students[i + 1];
                                students[i + 1] = students[i];
                                students[i] = temp;
                            }
                        }
                        else if (option == 6)
                        {
                            if (students[i].AverageScore.CompareTo(students[i + 1].AverageScore) < 0)
                            {
                                var temp = students[i + 1];
                                students[i + 1] = students[i];
                                students[i] = temp;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}

