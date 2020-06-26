using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Linq;

namespace assignment2fix
{
    class InterfaceOfUser
    {
        public void MainMenu()
        {
            int i;
            Console.WriteLine("\n");
            for (i = 1; i <= 40; i++) Console.Write("*");
            Console.Write("\n*         Student of a class           *\n");
            for (i = 1; i <= 40; i++) Console.Write("*");
            Console.Write("\n*\t  Please select the task       *");
            Console.Write("\n*1:Enter a group and show information  *");
            Console.Write("\n*2:Show information                    *");
            Console.Write("\n*3:Search student by ID                *");
            Console.Write("\n*4:Find students has highest grade     *");
            Console.Write("\n*5:Find students has fail grade        *");
            Console.Write("\n*6:Enter single student information    *");
            Console.Write("\n*7:Calculate average grade of student  *");
            Console.Write("\n*0:Exit                                *\n");
            for (i = 1; i <= 40; i++) Console.Write("*");
            Console.Write("\nEnter your choice: ");
        }
        public int CheckAndReturn(string Variable)
        {
            int resultOfChecking;
            bool isInputValid;
            isInputValid = int.TryParse(Variable, out resultOfChecking);
            if (isInputValid == true)
                return resultOfChecking;
            else
            {
                Console.WriteLine("Enter again: ");
                return 0;
            }
        }
        public void HeaderOfTableOfInformation()
        {
            Console.WriteLine("---------------Show information of Students---------------");
            Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}", "Name", "ID", "Grades");
        }
        public string ChangeToString(string name, string id, List<float> Grades)
        {
            var enterInformation = new EnterInformation();
            StringBuilder stringOfGrades = new StringBuilder();
            string stringOfNameAndId = string.Concat(name, id);
            foreach (float grade in Grades)
            {
                stringOfGrades.Append(grade);
            }
            stringOfGrades.ToString();
            string result = string.Concat(stringOfNameAndId, stringOfGrades);
            return result;
        }
        public void CheckToContinue(int optionItem)
        {
            if (optionItem != 0)
            {
                Console.WriteLine("\nDo you want to continue?[y/n]");
                char choiceToContinue = char.Parse(Console.ReadLine());
                if (choiceToContinue != 'y')
                {
                    Console.Clear();
                    Console.Write("DONE");                    
                }                
            }
        }        
        public bool IsIdExist(string id)
        {
            ClassRoom classRoom = new ClassRoom();
            var student=classRoom.Students.SingleOrDefault(s => s.Id == id);
            if (student != null) return true;
            else return false;
        }
        public int CheckNumberOfGrade(int numberOfGrades)
        {
            if (numberOfGrades > 2)
            {
                Console.WriteLine("Enter again");
                return 0;
            }
            else return numberOfGrades;
        }
        public int checkStudentExist()
        {
            ClassRoom Classes = new ClassRoom();
            int isStudentExist = Classes.NumberOfStudent;
            if (isStudentExist == 0)
            {
                Console.Write("Don't have student");
                return 0;
            }
            else return isStudentExist;
        }
        public string CheckEnterId (string id)
        {
            if (id.Length > 9 || id.Length < 5)
            {
                Console.Write("Enter again:");
                return "Error";
            }
            else
            {
                if (IsIdExist(id) == true)
                {
                    Console.WriteLine("Id existed");
                    Console.Write("Enter again:");
                    return "true";
                }
                else return id;
            }
        }
    }
}
