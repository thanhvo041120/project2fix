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
        public int NumberOfStudent
        {
            get
            {
                return Students.Count;
            }
        }        
        public int EnterInformationOfGroup()
        {
            var enterInformation = new EnterInformation();
            int numberOfStudent = enterInformation.EnterNumberOfStudent();
            NumberOfStudentActual = numberOfStudent + NumberOfStudent;
            for (var i = NumberOfStudent; i < numberOfStudent; i++)
            {
                EnterInformationASingleStudent();
            }
            return NumberOfStudentActual;
        }
        public int EnterInformationASingleStudent()
        {
            var student = new Student();
            student.CollectionInformation();
            Students.Add(student);
            return this.Students.Count;
        }
        public void FuntionCheckInformation()
        {
            var interFace = new InterfaceOfUser();
            interFace.HeaderOfTableOfInformation();
            foreach (Student item in Students)
            {
                item.returnInformationOfAStudent();
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
            if (InterFace.IsIdExist(idFind) == false) Console.WriteLine("Not Found");
            else
            {
                foreach (Student item in Students)
                    if (item.Id == idFind)
                        item.returnInformationOfAStudent();
            }
        }
        
    }
}
