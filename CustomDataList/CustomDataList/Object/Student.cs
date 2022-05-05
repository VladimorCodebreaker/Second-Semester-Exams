using System;

namespace CustomDataList.Object
{
    public class Student
    {
        private string firstName;

        private string lastName;

        private string studentNumber;

        private float averageScore;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.lastName = value;
            }
        }

        public string StudentNumber
        {
            get { return this.StudentNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.studentNumber = value;
            }
        }

        public float AverageScore
        {
            get { return this.averageScore; }
            set { this.averageScore = value; }
        }

        public override string ToString()
        {
            return $"First name: {firstName}, Last name: {lastName}, Student number: {studentNumber}, Average score: {averageScore}";
        }
    }
}

