using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV02
{
    public class MenuCatalog
    {

        private List<Pizza> _pizzas = new List<Pizza>();

        public void AddToMenu(Pizza pizza)
        {
            _pizzas.Add(pizza);
        }

        public Pizza NewPizza(Pizza pizza) 
        {
           bool creation = false;
            if (pizza.Price >= 0)
            { 
                _pizzas.Add(pizza);
                creation = true;     
                
                if (creation)
                {
                    Pizza.ResetMenuNo();
                    foreach (Pizza pi in _pizzas)
                    {
                        pi.MenuNo = Pizza.MenuNr();
                    }
                return pizza; 
                }

            if (pizza.Price < 0)
                {
                    throw new FormatException("Pizza not created. \nPrice must be a positive number.");
                }
            }
            return null;
        }


        public Pizza Delete(int number) 
        {
            bool deletion = false;
            foreach (Pizza p in _pizzas)
            {
                if (p.MenuNo == number)
                {
                    _pizzas.Remove(p);

                    deletion = true;

                    if (deletion)
                    {
                        Pizza.ResetMenuNo();
                        foreach (Pizza pi in _pizzas)
                        {
                            pi.MenuNo = Pizza.MenuNr();
                        }
                    }
                    return p;
                }   
            }
            if (!deletion)
                { 
                    throw new FormatException($"No pizza found with menu number {number}");
                }
            return null;
        }


        public void PrintMenu() 
        {
            foreach (Pizza p in _pizzas)
            {
                Console.WriteLine(p);
            }
        }

        public Pizza Search(int number) 
        {
            foreach (Pizza p in _pizzas)
            {
                if (p.MenuNo == number)
                {
                    return p;
                }
            }
            throw new FormatException($"Search error - could not find pizza number {number}");
        }


        public Pizza Update(int number) 
        {
            foreach (Pizza p in _pizzas)
            {
                if (p.MenuNo == number)
                {
                    return p;
                }
            }
            throw new FormatException($"No pizza found with menu number {number}");
        }
    }
}
