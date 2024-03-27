using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV02
{
    public class UserDialog
    {
        private MenuCatalog _menuCatalog;

        public UserDialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }

        public int UserMenu(List<string> menuList)
        {
            {
                foreach (string choice in menuList)
                {
                    Console.WriteLine(choice);
                }                
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Choose option:");
                string input = Console.ReadLine();

                try
                {
                    int result = int.Parse(input);
                    return result;
                }
                catch 
                {
                    Console.WriteLine("Write a number");
                }
                return -1;
            }
        }

        public void UI()
        {
            Console.WriteLine();
            bool proceed = true;
            List<string> UserMenuList = new List<string>()
            {
                "1. Read menu",
                "2. Update existing Pizza",
                "3. Create new pizza",
                "4. Delete Pizza",
                "5. Search Pizza",
                "6. Exit program"
            };

            while (proceed)
            {
                int userChoice = UserMenu(UserMenuList);

                switch (userChoice)
                {
                    case 1:
                        Console.Clear();              // Virker :-)
                        Console.WriteLine();
                        _menuCatalog.PrintMenu();
                        Console.WriteLine();
                        break;

                    case 2:                         // TODO Lav "tilbage-knap"
                                                    

                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Choose pizza no. to update:");
                            int userInput1 = int.Parse(Console.ReadLine());
                            _menuCatalog.Update(userInput1);                    // Virker :-)
                            _menuCatalog.PrintMenu();
                            Console.WriteLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Pizza not updated.\n {e.Message}");
                        }
                        break;

                    case 3:

                        try
                        {
                            Console.Clear();
                            //Console.WriteLine("To create new pizza press Enter:");  // Virker :-)
                            //Pizza userInput2 =  Pizza.Parse(Console.ReadLine());
                            //_menuCatalog.NewPizza(userInput2);
                            //Console.WriteLine();
                            //_menuCatalog.PrintMenu();                        
                            //Console.WriteLine();
                            Console.WriteLine("Enter the new pizza name:");
                            string pizzaName = Console.ReadLine();
                            Console.WriteLine("Enter the new pizza price:");
                            int pizzaPrice = int.Parse(Console.ReadLine());
                            Pizza newPizza = new Pizza(pizzaName, pizzaPrice);
                            _menuCatalog.NewPizza(newPizza);

                            Console.WriteLine();
                            Console.WriteLine("New menu:");
                            _menuCatalog.PrintMenu();
                            Console.WriteLine();


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Pizza not created.\n {e.Message}");
                        }
                        break;

                    case 4:                                                 // Virker :-)
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Choose pizza to delete:");
                            int userInput3 = int.Parse(Console.ReadLine());
                            _menuCatalog.Delete(userInput3);
                            Console.WriteLine();
                            Console.WriteLine("New menu:");
                            _menuCatalog.PrintMenu();
                            Console.WriteLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Pizza not deleted. \n" +
                                              $"{e.Message}");
                        }
                        break;

                    case 5:                                                 // Virker :-)
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Search for a pizza by menu no.:");
                            int userInput4 = int.Parse(Console.ReadLine());
                            _menuCatalog.Search(userInput4);
                            Console.WriteLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Search error.\n {e.Message}");
                        }

                        break;

                    case 6:
                        proceed = false;                                    // Virker :-)
                        Console.Clear();
                        break;

                    default: 
                        Console.WriteLine("Invalid choice, choose option 1 - 6");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                } 
            }

        }

    }
   
}
