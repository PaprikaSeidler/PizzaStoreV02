using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV02
{
    public class MenuCatalog
    {

        private List<Pizza> _pizzas = new List<Pizza>();

        public void Create(Pizza pizza)
        {
            _pizzas.Add(pizza);
        }

        public Pizza NewPizza()
        {
            Pizza pizza = new Pizza()
            {
                Name = Console.ReadLine(),
                Price = int.Parse(Console.ReadLine())
            };
            //Console.WriteLine("Choose new name:");
            //pizza.Name = Console.ReadLine();
            //Console.WriteLine("Choose new price:");
            //pizza.Price = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            _pizzas.Add(pizza);

            return pizza;

        }

        public Pizza Delete(int number)
        {
            bool deletion = false;
            foreach (Pizza p in _pizzas)
            {
                if (p.MenuNo == number)
                {
                    _pizzas.Remove(p);
                    Console.WriteLine($"You deleted pizza no. {p.MenuNo}. {p.Name}");
                    deletion = true;
                    break;
                }
            }

            if (deletion)
            {
                Pizza.ResetMenuNo();
                foreach (Pizza p in _pizzas)
                {
                    p.MenuNo = Pizza.MenuNr();
                }
            }
            return null;
        }




        public void PrintMenu()
        {
            foreach (Pizza p in _pizzas)
            {
                Console.WriteLine($"{p}");
            }
        }

        public Pizza Search(int number)
        {
            foreach (Pizza p in _pizzas)
            {
                if (p.MenuNo == number)
                {
                    Console.WriteLine($"Name: {p.Name} \nPrice: {p.Price}");
                    return p;
                }
            }
            return null;

            //if (!found)
            //{
            //NotFoundException ex = new NotFoundException();
            //throw ex;
            //Console.WriteLine("Not found");
            //}

            
        }

        public Pizza Update(int number)
        {
            foreach (Pizza p in _pizzas)
            {
                if (p.MenuNo == number)
                {
                    Console.WriteLine("Choose new name:");
                    p.Name = Console.ReadLine();
                    Console.WriteLine("Choose new price:");
                    p.Price = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            return p;
            }

            return null;    
        }

    }
}
