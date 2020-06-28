using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2fix
{
    class Application
    {
        public void Active()
        {
            ClassRoom Classes = new ClassRoom();
            char askToContinue;
            var enterChoice = new EnterInformation();
            var interFace = new InterfaceOfUser();
            int optionItem;
            int isStudentExist;
            string userInput;
            do
            {
                interFace.MainMenu();
                do
                {
                    userInput = enterChoice.EnterUserInput();
                    optionItem = interFace.CheckAndReturn(userInput);
                } while (optionItem == -1);
                switch (optionItem)
                {
                    case 1:
                        Console.Clear();
                        Classes.GetInformationOfGroup();
                        break;
                    case 2:
                        Console.Clear();
                        isStudentExist = interFace.CheckStudentExist(Classes.Students.Count);
                        if (isStudentExist != 0)                       
                        {
                            Classes.FuntionCheckInformation();
                            break;
                        }
                        else
                        break;
                    case 3:
                        Console.Clear();
                        isStudentExist = interFace.CheckStudentExist(Classes.Students.Count);
                        if (isStudentExist == 0) break;
                        else
                            Classes.FindByID();
                        break;
                    case 4:
                        Console.Clear();
                        isStudentExist = interFace.CheckStudentExist(Classes.Students.Count);
                        if (isStudentExist == 0) break;
                        else
                            Classes.FindStudentsHaveHighestAverageGrade();
                        break;
                    case 5:
                        Console.Clear();
                        isStudentExist = interFace.CheckStudentExist(Classes.Students.Count);
                        if (isStudentExist == 0) break;
                        else
                            Classes.FindFailGrade();
                        break;
                    case 6:
                        Console.Clear();
                        Classes.GetInformationASingleStudent();
                        break;
                    case 7:
                        Console.Clear();
                        isStudentExist = interFace.CheckStudentExist(Classes.Students.Count);
                        if (isStudentExist == 0) break;
                        else
                            Classes.CalculateAverages();
                        break;
                    case 8:
                        Console.Clear();
                        isStudentExist = interFace.CheckStudentExist(Classes.Students.Count);
                        if (isStudentExist == 0) break;
                        else
                            Classes.DeleteStudentById();
                        break;
                    case 0: Console.Clear(); Console.Write("DONE"); break;
                    default: Console.Clear(); Console.WriteLine("ERROR"); break;
                }
                askToContinue=interFace.CheckToContinue(optionItem);                
            } while (optionItem != 0&&askToContinue == 'y');
        }
    }
}
