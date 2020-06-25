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
            return averageGrade = sum / Grades.Count;
        }
    }
}
