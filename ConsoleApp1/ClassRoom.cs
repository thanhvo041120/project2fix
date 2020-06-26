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
        public void FuntionCheckInformation()
        {
            var interFace = new InterfaceOfUser();
            interFace.HeaderOfTableOfInformation();
            foreach (Student item in Students)
            {
                item.ReturnInformationOfAStudent();
            }
        }
        public void CalculateAverages()
        {
            foreach (Student item in Students)
            {
                Console.WriteLine("Average Grade is: "+item.CalculateAverageGrade()+"\n");
            }
        }
        public void FindByID()
        {
            var enterInfor = new EnterInformation();
            var InterFace = new InterfaceOfUser();
            string idFind = enterInfor.EnterIdToFind();
            if (InterFace.IsIdExist(idFind,Students) == false) Console.WriteLine("Not Found");
            else
            {
                foreach (Student item in Students)
                    if (item.Id == idFind)
                        item.ReturnInformationOfAStudent();
            }
        }
        
    }
}
