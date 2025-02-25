﻿using System;
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
            Console.Write("Name of student is: ");
            string Name = Console.ReadLine();
            return Name;
        }
        public string GetId(List<Student>students)
        {
            var interFace = new InterfaceOfUser();
            string checkId;
            string ID;
            Console.Write("ID is: ");            
            do
            {
                ID = Console.ReadLine();
                checkId = interFace.CheckEnterId(ID,students);
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
            var interFace = new InterfaceOfUser();
            int NumberOfGrade;
            Console.Write("Enter number of grades (1-->2): ");
            do
            {
                string NumberOfGradeWantToAdd = Console.ReadLine();
                NumberOfGrade = interFace.CheckAndReturn(NumberOfGradeWantToAdd);
            } while (NumberOfGrade == -1);
            return NumberOfGrade;
        }
        public int EnterNumberOfStudent()
        { 
            var interFace = new InterfaceOfUser();
            int Number;
            Console.Write("Enter number of students: ");            
            do
            {
                string NumberOfStudentWantToAdd = Console.ReadLine();
                Number = interFace.CheckAndReturn(NumberOfStudentWantToAdd);
            } while (Number == -1);
            return Number;
        }
        public string EnterIdToFind()
        {
            Console.Write("Enter ID to work: ");
            string IdToFind = Console.ReadLine();
            return IdToFind;
        }
    }
}
