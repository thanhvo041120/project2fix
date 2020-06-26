using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Linq;
using System.Xml.Serialization;

namespace assignment2fix
{
    class InterfaceOfUser
    {
        public void MainMenu()
        {
            int i;
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
            Console.Write("\n*8:Delete a student by ID              *");
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
                Console.Write("Enter again: ");
                return 0;
            }
        }
        public void HeaderOfTableOfInformation()
        {
            Console.WriteLine("---------------Show information of Students---------------");
            Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}", "Name", "ID", "Grades");
        }        
        public char CheckToContinue(int optionItem)
        {
            char choiceToContinue = 'y';
            if (optionItem != 0)
            {
                Console.Write("Finish this function\nDo you want to continue?[y/n]");
                choiceToContinue = char.Parse(Console.ReadLine());
                if (choiceToContinue =='n')
                {
                    Console.Clear();
                    Console.Write("DONE");
                    return choiceToContinue;
                }
                else
                {
                    Console.Clear();
                    return choiceToContinue;
                }
            }
            return choiceToContinue;
        }        
        public bool IsIdExist(string id,List<Student> students)
        {
            var student =students.SingleOrDefault(s => string.Compare(s.Id,id)==0);
            if (student == null) return true;
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
        public int CheckStudentExist(int isStudentExist)
        {
            if (isStudentExist == 0)
            {
                Console.WriteLine("Don't have student");
                return 0;
            }
            else return isStudentExist;
        }
        public string CheckEnterId (string id, List<Student>students)
        {
            if (id.Length > 9 || id.Length < 5)
            {
                Console.Write("Enter ID again:");
                return "Error";
            }
            else if (IsIdExist(id, students) == false)
            {
                Console.WriteLine("ID existed");
                Console.Write("Enter ID again: ");
                return "Existed";
            }
            else return id;
        }
    }
}
