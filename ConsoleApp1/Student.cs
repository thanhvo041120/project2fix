using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2fix
{
    class Student
    {
        public string Name;
        public string Id;
        public List<float> Grades = new List<float>();
        public float CalculateAverageGrade()
        {
            float averageGrade;
            float sum=0;
            foreach(float item in Grades)
            {
                sum = sum + item;
            }
            averageGrade = sum / Grades.Count;
            return averageGrade;
        }
        public void CollectionInformation(List<Student>Students)
        {
            var enterInformation = new EnterInformation();
            Name = enterInformation.GetName();
            Id = enterInformation.GetId(Students);
            Grades = enterInformation.GetGrade();
        }
        public void ReturnInformationOfAStudent()
        {
            Console.Write("|{0,-10}|{1,-10}", Name, Id);
            foreach (float grade in Grades)
            {
                Console.Write("|Grade: {0,-10}", grade);
            }
            Console.Write("\n");            
        }
    }
}
