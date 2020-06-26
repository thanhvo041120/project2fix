using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace assignment2fix
{
    class ClassRoom
    {
        public List<Student> Students = new List<Student>();
        public int NumberOfStudentActual;
        //Case 1: Enter a group
        public void GetInformationOfGroup()
        {
            var enterInformation = new EnterInformation();
            int numberOfStudent = enterInformation.EnterNumberOfStudent();
            NumberOfStudentActual = numberOfStudent + Students.Count;
            for (var i = Students.Count; i < NumberOfStudentActual; i++)
            {
                Console.Clear();
                GetInformationASingleStudent();
            }
        }
        //Case 6: Enter a student
        public void GetInformationASingleStudent()
        {
            var student = new Student();
            student.CollectionInformation(Students);
            Students.Add(student);
        }
        //case 2: Check
        public void FuntionCheckInformation()
        {
            var interFace = new InterfaceOfUser();
            interFace.HeaderOfTableOfInformation();
            foreach (Student item in Students)
            {
                item.ReturnInformationOfAStudent();
            }
        }
        //case 7: Calculate Averages
        public void CalculateAverages()
        {
            var interFace = new InterfaceOfUser();
            foreach (Student item in Students)
            {
                interFace.HeaderOfTableOfInformation();
                item.ReturnInformationOfAStudent();
                Console.WriteLine("Average Grade is: "+item.CalculateAverageGrade()+"\n");
            }
        }
        //case 3: Find student
        public void FindByID()
        {
            var enterInfor = new EnterInformation();
            var InterFace = new InterfaceOfUser();
            string idFind = enterInfor.EnterIdToFind();
            Console.Clear();
            if (InterFace.IsIdExist(idFind,Students) == true) Console.WriteLine("Not Found");
            else
            {
                InterFace.HeaderOfTableOfInformation();
                foreach (Student item in Students)
                    if (item.Id == idFind)
                        item.ReturnInformationOfAStudent();
            }
        }
        //case 4: Find Student has highest grade
        public void FindStudentsHaveHighestAverageGrade()
        {
            float highestGrade;
            var interFace = new InterfaceOfUser();
            List<float> AverageGradeTemp = new List<float>();
            foreach (Student item in Students)
            {
                AverageGradeTemp.Add(item.CalculateAverageGrade());
            }
            AverageGradeTemp.Sort();
            highestGrade = AverageGradeTemp[AverageGradeTemp.Count - 1];
            foreach (Student item in Students)
            {
                if (highestGrade == item.CalculateAverageGrade())
                {
                    Console.WriteLine("Average Grade is: " + highestGrade);
                    interFace.HeaderOfTableOfInformation();
                    item.ReturnInformationOfAStudent();
                }
            }
        }
        public void FindFailGrade()
        {
            var interFace = new InterfaceOfUser();
            interFace.HeaderOfTableOfInformation();
            foreach (Student item in Students)
            {
                float AverageGrade = item.CalculateAverageGrade();
                if (AverageGrade < 5)
                {
                     item.ReturnInformationOfAStudent();
                     Console.WriteLine("Average grade is: " + AverageGrade);                    
                }
            }
        }
        public void DeleteStudentById()
        {
            var EnterID = new EnterInformation();
            var InterFace = new InterfaceOfUser();
            string IdToDelete = EnterID.EnterIdToFind();
            foreach(Student student in Students)
            {
                if (InterFace.IsIdExist(IdToDelete, Students) == true)
                    Console.WriteLine("Student does not exist");
                else
                {
                    Students.RemoveAll(s => s.Id == IdToDelete);
                    Console.WriteLine("Deleted");
                    break;
                }
            }
        }
    }
}
