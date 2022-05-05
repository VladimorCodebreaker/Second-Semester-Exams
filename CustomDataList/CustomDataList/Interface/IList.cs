using System;
using CustomDataList.Object;

namespace CustomDataList.Interface
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

