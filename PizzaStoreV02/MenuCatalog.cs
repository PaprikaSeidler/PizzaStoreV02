using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV02
{
    public class MenuCatalog // TODO Lav CSS
    {

        private List<Pizza> _pizzas = new List<Pizza>();

        public void AddToMenu(Pizza pizza)
        {
            _pizzas.Add(pizza);
        }

        public Pizza NewPizza(Pizza pizza)
        {
            try
            {
                
                //Console.WriteLine("Choose new name:");
                //pizza.Name = Console.ReadLine();
                //Console.WriteLine("Choose new price:");
                //pizza.Price = int.Parse(Console.ReadLine());
                //Console.WriteLine();
                
                if (pizza.Price >= 0)
                    {
                    _pizzas.Add(pizza);
                    Console.WriteLine("Pizza created successfully");
                    return pizza;
                    }
                if (pizza.Price < 0)
                {
                    throw new Exception();
                }
                
            }
            catch (FormatException e) 
            {
                Console.WriteLine(e.Message);                       // TODO "prøv igen"-funktion 
            }                                                       // Ellers virker den
            catch (Exception)
            {
                Console.WriteLine("Price must be a number > 0");
            }
            return null;
        }

                                        // Virker :-)
        public Pizza Delete(int number) 
        {
            try
            {
                bool deletion = false;
                foreach (Pizza p in _pizzas)
                {
                    if (p.MenuNo == number)
                    {
                        _pizzas.Remove(p);
                        Console.WriteLine($"You deleted pizza no. {p.MenuNo}. {p.Name}");
                        
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
                throw new Exception($"No pizza found with menu number {number}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            try
            {
                foreach (Pizza p in _pizzas)
                {
                    if (p.MenuNo == number)
                    {
                        Console.WriteLine($"Name: {p.Name} \nPrice: {p.Price}");
                        return p;
                    }
                }
                throw new Exception($"No pizza found with menu number {number}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }


        public Pizza Update(int number)
        {
            try
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
                        return p;
                        }
                }
                throw new Exception($"No pizza found with menu number {number}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Pizza not updated. {e.Message}");
            }
            return null;    
        }
    }
}
