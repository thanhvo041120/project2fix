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
                } while (optionItem == 0);
                switch (optionItem)
                {
                    case 1:
                        Console.Clear();
                        Classes.EnterInformationOfGroup();
                        Console.Clear();
                        interFace.HeaderOfTableOfInformation();
                        foreach (Student item in Classes.Students)
                            interFace.ShowInformation(item.Name,item.Id,item.Grades);
                        break;
                    case 2:
                        Console.Clear();
                        isStudentExist = interFace.checkStudentExist();
                        if (isStudentExist == 0) break;
                        else 
                        {
                            interFace.HeaderOfTableOfInformation();
                            foreach (Student item in Classes.Students)
                                interFace.ShowInformation(item.Name,item.Id,item.Grades);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        isStudentExist = interFace.checkStudentExist();
                        if (isStudentExist == 0) break;
                        else
                            Classes.FindByID();
                        break;
                    case 4:
                 
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        Classes.EnterInformationAddToList();
                        break;
                    case 7:
                        
                        break;
                    case 0: Console.Clear(); Console.Write("DONE"); break;
                    default: Console.Clear(); Console.Write("ERROR"); break;
                }
                interFace.CheckToContinue(optionItem);
                Console.Clear();
            } while (optionItem != 0);
        }
    }
}
