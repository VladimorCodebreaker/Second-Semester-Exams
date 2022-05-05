using System;
using System.Collections.Generic;
using CustomDataList.Implementation;
using CustomDataList.Object;

namespace CustomDataList
{
    public class Menu
    {
        public static void Run()
        {
            Console.WriteLine("=> Enter a number of students... <=");
            bool userSize = int.TryParse(Console.ReadLine(), out int size);

            List list = new List(size);

            list.PopulateWithSampleData();

            while (true)
            {
                Console.WriteLine("-------------- Menu ------------------- \n" +
                    "====>  Choose an option...\n" +
                    "0. EXIT \n" +
                    "1. Display List \n" +
                    "2. Add \n" +
                    "3. Get Element \n" +
                    "4. Remove Element By Index \n" +
                    "5. Remove First element \n" +
                    "6. Remove Last element \n" +
                    "7. Properties \n" +
                    "8. Sort \n" +
                    "9.  Get Max Element (Student with best score!) \n" +
                    "10. Get Min Element (Student with lowest score!) \n");

                bool userChoice = int.TryParse(Console.ReadLine(), out int choice);

                if (choice == 0)
                {
                    break;
                }

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        list.DisplayList();
                        break;
                    case 2:
                        var student = CreateStudent();
                        list.Add(student);
                        break;
                    case 3:
                        var indexForGettingAnElement = GetIndex();
                        list.GetElement(indexForGettingAnElement);
                        break;
                    case 4:
                        var indexForRemovingAnElement = GetIndex();
                        list.RemoveByIndex(indexForRemovingAnElement);
                        break;
                    case 5:
                        list.RemoveFirst();
                        break;
                    case 6:
                        list.RemoveLast();
                        break;
                    case 7:
                        list.Properties();
                        break;
                    case 8:
                        list.SortElements();
                        list.DisplayList();
                        break;
                    case 9:
                        list.GetMaxElement();
                        break;
                    case 10:
                        list.GetMinElement();
                        break;
                    default:
                        throw new IndexOutOfRangeException("Error. Please choose between 0 - 10");
                }

            }
            Console.WriteLine("Thank you for visiting. I hope to get a high mark!! :)");
            Console.ReadKey();
        }

        public static Student CreateStudent()
        {
            Console.WriteLine("Create Student - Form");

            Student student = new Student();

            Console.WriteLine("First name: ");
            student.FirstName = Console.ReadLine();

            Console.WriteLine("Last name:");
            student.LastName = Console.ReadLine();

            Console.WriteLine("Student number: ");
            student.StudentNumber = Console.ReadLine();

            Console.WriteLine("Average score: ");
            student.AverageScore = float.Parse(Console.ReadLine());

            return student;
        }

        public static int GetIndex()
        {
            Console.WriteLine("Enter an index: ");
            bool userIndex = int.TryParse(Console.ReadLine(), out int index);

            return index;
        }
    }
}

