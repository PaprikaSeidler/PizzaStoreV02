using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV02
{
    public class CustomerCatalog
    {
        private List<Customer> _customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void PrintCustomers()
        {
            foreach (Customer c in _customers)
            {
                Console.WriteLine(c);
            }
        }

        public Customer NewCustomer(Customer customer)
        {

                //Console.WriteLine("Enter the new customer's name:");
                //string customerName = Console.ReadLine();
                //Console.WriteLine("Enter the new customer's address:");
                //string customerAddress = Console.ReadLine();
                //Console.WriteLine("Enter the new customer's phone number:");
                //string customerPhoneNo = Console.ReadLine();
                //Customer newCustomer = new Customer(customerName, customerAddress, customerPhoneNo);
                AddCustomer(customer);
                return customer;
            
            throw new FormatException("Customer name and address must be filled");
 
        }

        public void DeleteCustomer(string Name) //TODO virker ikke....
        {
            try
            {
                foreach (Customer c in _customers)
                {
                    if (c.Name == Name)
                    {
                        _customers.Remove(c);
                        Console.WriteLine($"Customer {c.Name} was deleted");
                    }
                }
                //Måske throw new??
            }
            catch (Exception) 
            { 
                Console.WriteLine($"The given name of customer does not excist");
            }
        }

        public Customer Update(Customer customer) // TODO virker ikke
        {
            try
            {
                foreach(Customer c in _customers)
                {
                    if (c.Name == customer.Name)
                    {
                        Console.WriteLine("Update name:");
                        c.Name = Console.ReadLine();
                        Console.WriteLine("Update address:");
                        c.Address = (Console.ReadLine());
                        Console.WriteLine();
                        return c;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Customer not updated");
            }
            return null;
        }

        public Customer Search(Customer customer)
        {
            try
            {
                foreach (Customer c in _customers)
                {
                    if (c.Name == customer.Name) 
                    { 
                        return c; 
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Customer not found");
            }
            return null;
        }
        
    }
}
