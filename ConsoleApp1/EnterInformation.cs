using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2fix
{
    class EnterInformation
    {
        public string EnterUserInput()
        {
            string inputOfUser = Console.ReadLine();
            return inputOfUser;
        }
        public string GetName()
        {
            var student = new Student();
            Console.Write("Name of student is: ");
            string Name = Console.ReadLine();
            return Name;
        }
        public string GetId()
        {
            var interFace = new InterfaceOfUser();
            string checkId;
            string ID;
            Console.Write("ID is: ");            
            do
            {
                ID = Console.ReadLine();
                checkId = interFace.CheckEnterId(ID);
            } while (checkId != ID);
            return ID;
        }
        public List<float> GetGrade()
        {
            var interFace = new InterfaceOfUser();
            int numberOfGrades;
            do
            {
                numberOfGrades = interFace.CheckNumberOfGrade(EnterNumberOfGrades());
            } while (numberOfGrades == 0);
            List<float> Grades = new List<float>();
            for (var i = 0; i < numberOfGrades; i++)
            {
                Console.Write("Grade " + (i + 1) + ": ");
                float grade = float.Parse(Console.ReadLine());
                Grades.Add(grade);
            }
            return Grades;
        }
        public int EnterNumberOfGrades()
        {
            Console.Write("Enter number of grades (1-->2): ");
            int NumberOfGrade = int.Parse(Console.ReadLine());
            return NumberOfGrade;
        }
        public int EnterNumberOfStudent()
        {
            Console.Write("\nEnter number of students: ");
            int NumberOfStudentWantToAdd = int.Parse(Console.ReadLine());
            return NumberOfStudentWantToAdd;
        }
        public string EnterIdToFind()
        {
            string IdToFind = Console.ReadLine();
            return IdToFind;
        }
    }
}
