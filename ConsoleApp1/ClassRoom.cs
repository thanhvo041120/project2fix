using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace assignment2fix
{
    class ClassRoom
    {
        public List<Student> Students = new List<Student>();
        public int NumberOfStudentActual;
        //Case 1: Enter a group
        public int GetInformationOfGroup()
        {
            var enterInformation = new EnterInformation();
            int numberOfStudent = enterInformation.EnterNumberOfStudent();
            NumberOfStudentActual = numberOfStudent + Students.Count;
            for (var i = Students.Count; i < NumberOfStudentActual; i++)
            {
                Console.Clear();
                GetInformationASingleStudent();
            }
            return NumberOfStudentActual;
        }
        //Case 2: Enter a student
        public void GetInformationASingleStudent()
        {
            var student = new Student();
            student.CollectionInformation();
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
            if (InterFace.IsIdExist(idFind,Students) == true) Console.WriteLine("Not Found");
            else
            {
                InterFace.HeaderOfTableOfInformation();
                foreach (Student item in Students)
                    if (item.Id == idFind)
                        item.ReturnInformationOfAStudent();
            }
        }
        
    }
}
