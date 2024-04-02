using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PizzaStoreV02
{
    public class PizzaAdministationDialog
    {
        private MenuCatalog _menuCatalog;


        public PizzaAdministationDialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }


        public int UserMenu(List<string> menuList)
        {Console.Clear();
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

        public void PizzaUI()
        {
            

            bool proceed = true;
            List<string> UserMenuList = new List<string>()
            {
                "1. Read menu",
                "2. Update existing Pizza",
                "3. Create new pizza",
                "4. Delete Pizza",
                "5. Search Pizza",
                "6. Back to main menu"
            };

            while (proceed)
            {
                int userChoice = UserMenu(UserMenuList);

                switch (userChoice)
                {
                    case 1: //Print menu
                        Console.Clear();              
                        Console.WriteLine();
                        _menuCatalog.PrintMenu();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        break;

                    case 2: //Update                         
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Choose pizza no. to update:");
                            int userInput1 = int.Parse(Console.ReadLine());
                            Pizza p = _menuCatalog.Update(userInput1);

                            Console.WriteLine("Choose new name:");
                            p.Name = Console.ReadLine();
                            Console.WriteLine("Choose new price:");
                            p.Price = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            _menuCatalog.PrintMenu();
                            Console.WriteLine();
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        break;

                    case 3: //New pizza

                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Enter the new pizza name:");
                            string pizzaName = Console.ReadLine();
                            Console.WriteLine("Enter the new pizza price:");
                            int pizzaPrice = int.Parse(Console.ReadLine());
                            Pizza newPizza = new Pizza(pizzaName, pizzaPrice);
                            Pizza p = _menuCatalog.NewPizza(newPizza);
                            Console.WriteLine("Pizza created successfully");

                            Console.WriteLine();
                            Console.WriteLine("New menu:");
                            _menuCatalog.PrintMenu();
                            Console.WriteLine();
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        break;

                    case 4: //Delete                                        
                            
                        try
                        {
                            Console.Clear();
                            _menuCatalog.PrintMenu();
                            Console.WriteLine();

                            Console.WriteLine("Choose pizza to delete:");
                            int userInput3 = int.Parse(Console.ReadLine());
                            Pizza p = _menuCatalog.Delete(userInput3);
                            Console.WriteLine($"You deleted pizza no. {p.MenuNo}. {p.Name}");
                            
                            Console.WriteLine();
                            Console.WriteLine("New menu:");
                            _menuCatalog.PrintMenu();
                            Console.WriteLine();
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }    

                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        break;

                    case 5: //Search                                                
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Search for a pizza by menu no.:");
                            int userInput4 = int.Parse(Console.ReadLine());
                            Pizza p =_menuCatalog.Search(userInput4);
                            Console.WriteLine($"Name: {p.Name} \nPrice: {p.Price}");
                            Console.WriteLine();
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to menu.");
                        Console.ReadKey();
                        break;

                    case 6: //Back
                        proceed = false;                                    
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
