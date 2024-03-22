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

            Menu.Create(p1);
            Menu.Create(p2);
            Menu.Create(p3);



            Console.WriteLine($"The menu: \n");
            Menu.PrintMenu();
            Console.WriteLine();

            ////Menu.Update();
            //Menu.PrintMenu();

            //Console.WriteLine("Search for a pizza by menu no.:");
            //int userInput = int.Parse(Console.ReadLine());
            //Menu.Search(userInput);
            //Console.WriteLine();

            //Console.WriteLine("Choose pizza to delete:");
            //int userInput2 = int.Parse(Console.ReadLine());
            //Menu.Delete(userInput2);

            //Console.WriteLine();
            //Menu.PrintMenu();
            //Console.WriteLine();

            //Console.WriteLine("Choose pizza no. to update:");
            //int userInput3 = int.Parse(Console.ReadLine());
            //Menu.Update(userInput3);

            //Menu.PrintMenu();

            Console.WriteLine("Create new pizza:");
            //var userInput4 = var.Parse(Console.ReadLine());
            Menu.NewPizza();
            Menu.PrintMenu();

        }
    }
}
