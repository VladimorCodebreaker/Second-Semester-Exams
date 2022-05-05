using System;
using CustomDataList.Object;
using CustomDataList.Interface;

namespace CustomDataList.Implementation
{
    public class List : IList
    {
        public int Length { get; private set; }
        public Student First { get; private set; }
        public Student Last { get; private set; }

        Student[] students;

        public List(int sizeOfArray)
        {
            students = new Student[sizeOfArray];
        }

        List<string> firstName = new List<string>() { "James", "Robert", "Lisa", "Florian", "Paul", "Heinrich", "Jasmin", "Jessicaœ" };
        List<string> lastName = new List<string>() { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Rodriguez" };

        Random random = new Random();

        public void PopulateWithSampleData()
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student()
                {
                    FirstName = firstName[random.Next(0, firstName.Count)],
                    LastName = lastName[random.Next(0, lastName.Count)],
                    StudentNumber = (i + 1).ToString(),
                    AverageScore = (float)random.Next(0, 100)
                };
            }
        }

        public Student[] Add(Student student)
        {
            if (students == null)
            {
                return new Student[] { student };
            }

            Resize(ref students, students.Length + 1);

            students[students.Length - 1] = student;

            return students;
        }

        public void Resize(ref Student[] students, int newSize)
        {
            if (newSize < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (students == null)
            {
                students = new Student[newSize];
            }
            else if (students.Length != newSize)
            {
                Student[] destinationArray = new Student[newSize];
                Copy(students, 0, destinationArray, (students.Length > newSize) ? newSize : students.Length);
                students = destinationArray;
            }
        }

        public void Copy(Student[] sourceArray, int sourceIndex, Student[] destinationArray, int length)
        {
            for (int i = sourceIndex; i < length; i++)
            {
                destinationArray[i] = sourceArray[i];
            }
        }

        public void DisplayList()
        {
            Console.WriteLine("------------- List of Students ------------");

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n");
        }

        public Student GetElement(int index)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (i == index)
                {
                    Console.WriteLine("\n" + students[i] + " | SUCCESSFULLY FOUND | \n");
                    return students[i];
                }
            }
            return null;
        }

        public void RemoveByIndex(int index)
        {
            for (int i = index; i + 1 < students.Length; i++)
            {
                students[i] = students[i + 1];
            }
            students[students.Length - 1] = default;
            Resize(ref students, students.Length - 1);
        }

        public void RemoveFirst()
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                students[i] = students[i + 1];
            }
            students[students.Length - 1] = default;
            Resize(ref students, students.Length - 1);
        }

        public void RemoveLast()
        {
            Resize(ref students, students.Length - 1);
        }

        public void Properties()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students == null)
                {
                    this.Length = 0;
                    throw new Exception("==> No student found! <==");
                }
                else
                {
                    this.Length = students.Length;
                    this.First = students[0];
                    this.Last = students[students.Length - 1];
                }
            }
            Console.WriteLine($"Length of list: {Length}\nFirst student: {First}\nLast student: {Last}");
        }

        public void GetMaxElement()
        {
            Console.WriteLine("\n MAX:" + Sort.Max(students, y => y.AverageScore) + "\n");
        }

        public void GetMinElement()
        {
            Console.WriteLine("\n MIN: " + Sort.Min(students, y => y.AverageScore) + "\n");
        }

        public void SortElements()
        {
            Console.WriteLine("Sort by: \n" +
                "-------- ASCENDING --------- \n" +
                "1. First name \n" +
                "2. Last name \n" +
                "3. Average score \n" +
                "\n" +
                "-------- DESCENDING --------- \n" +
                "4. First name \n" +
                "5. Last name \n" +
                "6. Average score \n");

            var userInput = int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1:
                    Sort.BubbleSort(Sort.SortDirection.Ascending, students, 1);
                    Console.WriteLine("\n MAX:" + Sort.Max(students, y => y.FirstName) + "\n");
                    Console.WriteLine("\n MIN: " + Sort.Min(students, y => y.FirstName) + "\n");
                    break;
                case 2:
                    Sort.BubbleSort(Sort.SortDirection.Ascending, students, 2);
                    Console.WriteLine("\n MAX:" + Sort.Max(students, y => y.LastName) + "\n");
                    Console.WriteLine("\n MIN: " + Sort.Min(students, y => y.LastName) + "\n");
                    break;
                case 3:
                    Sort.BubbleSort(Sort.SortDirection.Ascending, students, 3);
                    Console.WriteLine("\n MAX:" + Sort.Max(students, y => y.AverageScore) + "\n");
                    Console.WriteLine("\n MIN: " + Sort.Min(students, y => y.AverageScore) + "\n");
                    break;
                case 4:
                    Sort.BubbleSort(Sort.SortDirection.Descending, students, 4);
                    Console.WriteLine("\n MAX:" + Sort.Max(students, y => y.FirstName) + "\n");
                    Console.WriteLine("\n MIN: " + Sort.Min(students, y => y.FirstName) + "\n");
                    break;
                case 5:
                    Sort.BubbleSort(Sort.SortDirection.Descending, students, 5);
                    Console.WriteLine("\n MAX:" + Sort.Max(students, y => y.LastName) + "\n");
                    Console.WriteLine("\n MIN: " + Sort.Min(students, y => y.LastName) + "\n");
                    break;
                case 6:
                    Sort.BubbleSort(Sort.SortDirection.Descending, students, 6);
                    Console.WriteLine("\n MAX:" + Sort.Max(students, y => y.AverageScore) + "\n");
                    Console.WriteLine("\n MIN: " + Sort.Min(students, y => y.AverageScore) + "\n");
                    break;
                default:
                    Console.Clear();
                    SortElements();
                    break;
            }
        }
    }
}
