using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV02
{
    //public class MainMenuManager
    //{
    //    private UserDialog _userDialog;

    //    public MainMenuManager(UserDialog userDialog)
    //    {
    //        _userDialog = userDialog;
    //    }

    //    public int UserMenu(List<string> menuList)
    //    {
    //        {
    //            foreach (string choice in menuList)
    //            {
    //                Console.WriteLine(choice);
    //            }
    //            Console.WriteLine("----------------------------------");
    //            Console.WriteLine("Choose option:");
    //            string input = Console.ReadLine();

    //            try
    //            {
    //                int result = int.Parse(input);
    //                return result;
    //            }
    //            catch
    //            {
    //                Console.WriteLine("Write a number");
    //            }
    //            return -1;
    //        }
    //    }
    //    public void MainMenu() 
    //    {
    //        bool proceed = true;
    //        List<string> MainMenuList = new List<string>() 
    //            { 
    //                "1. Pizza administration",
    //                "2. Customer administration",
    //                "3. Order administration",
    //                "4. Quit"
    //            };

    //        while (proceed)
    //        {
    //            int UserChoice = UserMenu(MainMenuList);

    //            switch (UserChoice)
    //            {
    //                case 1:
    //                    _userDialog.UI();
    //                    break;

    //                case 2:
    //                    Console.WriteLine();
    //                    break;

    //                case 3:
    //                    Console.WriteLine();
    //                    break;

    //                case 4:
    //                    proceed = false;
    //                    Console.Clear();
    //                    break;

    //                default:
    //                    Console.WriteLine("Invalid choice, choose option 1 - 4");
    //                    Console.WriteLine("Press any key to continue");
    //                    Console.ReadKey();
    //                    break;

    //            }

    //        }
    //    }

    //}
}
