using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV02
{
    public class StoreController
    {
        public void start() 
        {
            MenuCatalog Menu = new MenuCatalog();

            Pizza p1 = new Pizza("Calzone", 65);
            Pizza p2 = new Pizza("Magarita", 60);
            Pizza p3 = new Pizza("Ufo", 80);

            Menu.AddToMenu(p1);
            Menu.AddToMenu(p2);
            Menu.AddToMenu(p3);

            PizzaAdministationDialog PizzaAdmin = new PizzaAdministationDialog(Menu);
            
            bool proceed = true;
            List<string> MainMenuList = new List<string>()
                {
                    "1. Pizza administration",
                    "2. Customer administration",
                    "3. Order administration",
                    "4. Quit"
                };

            while (proceed)
                {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                foreach (string choice in MainMenuList)
                {
                    Console.WriteLine(choice);
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Choose option:");
                int input = int.Parse(Console.ReadLine());

                try
                {
                    switch (input)
                    {
                        case 1:
                            PizzaAdmin.PizzaUI();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("To be implemented");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to return.");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("To be implemented");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to return.");
                            Console.ReadKey();
                            break;

                        case 4:
                            proceed = false;
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Invalid choice, choose option 1 - 4");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }            
        }
    }
}
