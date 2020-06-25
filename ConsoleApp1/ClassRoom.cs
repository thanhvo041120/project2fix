using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace assignment2fix
{
    class ClassRoom
    {
        public List<Student> Students = new List<Student>();
        public int NumberOfStudent
        {
            get
            {
                return Students.Count;
            }
        }
        public void EnterInformationAddToList()
        {
            var enterInformation = new EnterInformation();
            Student student = new Student();
            student.Name = enterInformation.GetName();
            student.Id = enterInformation.GetId();
            student.Grades = enterInformation.GetGrade();
            Students.Add(student);
        }
        public void EnterInformationOfGroup()
        {
            var enterInformation = new EnterInformation();
            int numberOfStudent = enterInformation.EnterNumberOfStudent();
            for (var i = 0; i < numberOfStudent; i++)
                EnterInformationAddToList();
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
                        InterFace.ShowInformation(item.Name, item.Id, item.Grades);
            }
        }
        
    }
}
