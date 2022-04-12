using System;

namespace CustomDataList
{
    public interface IList
    {
        void PopulateWithSampleData();

        Student[] Add(Student student);

        Student GetElement(int index);

        void RemoveFirst();

        void RemoveLast();

        void DisplayList();

        void Properties();
    }
}

