using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV02
{
    public class CustomerAdministrationDialog
    {
        private CustomerCatalog _customerCatalog;

        public CustomerAdministrationDialog (CustomerCatalog customerCatalog)
        {
            _customerCatalog = customerCatalog;
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

        public void CustomerUI()
        {
            Console.WriteLine();
            bool proceed = true;
            List<string> UserMenuList = new List<string>()
            {
                "1. Show current customers",
                "2. Update existing customer",
                "3. Create new customer",
                "4. Delete customer",
                "5. Search customer",
                "6. Back to main menu"
            };

            while (proceed)
            {
                int userChoice = UserMenu(UserMenuList);

                switch (userChoice)
                {
                    case 1: //Virker
                        Console.Clear();
                        Console.WriteLine();
                        _customerCatalog.PrintCustomers();
                        Console.WriteLine();
                        break;

                    case 2:


                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Which customer do you wish to update:"); // TODO Virker ikke
                            Customer userInput1 = Customer.Parse(Console.ReadLine());
                            _customerCatalog.Update(userInput1);
                            _customerCatalog.PrintCustomers();
                            Console.WriteLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Customer not updated.\n {e.Message}");
                        }
                        break;

                    case 3:

                        try
                        {
                            //Console.Clear();
                            //Console.WriteLine("Enter the new customer's name:");
                            //string customerName = Console.ReadLine();
                            //Console.WriteLine("Enter the new customer's address:");
                            //string customerAddress = Console.ReadLine();
                            //Console.WriteLine("Enter the new customer's phone number:");
                            //string customerPhoneNo = Console.ReadLine();
                            //Customer newCustomer = new Customer(customerName, customerAddress, customerPhoneNo);


                            Console.Clear();

                            _customerCatalog.NewCustomer(Customer.Parse(Console.ReadLine()));
                            
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine("Updated customer list:");
                            _customerCatalog.PrintCustomers();
                            Console.WriteLine();


                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Customer not created in the system.\n {e.Message}");
                        }
                        break;

                    case 4:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Choose customer to delete:");
                            Customer userInput3 = Customer.Parse(Console.ReadLine());
                            //_customerCatalog.DeleteCustomer(userInput3);
                            Console.WriteLine();
                            Console.WriteLine("Updated list of customers:");
                            _customerCatalog.PrintCustomers();
                            Console.WriteLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Customer not deleted. \n" +
                                              $"{e.Message}");
                        }
                        break;

                    case 5:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Search for customer:");
                            Customer userInput4 = Customer.Parse(Console.ReadLine());
                            _customerCatalog.Search(userInput4);
                            Console.WriteLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Search error.\n {e.Message}");
                        }

                        break;

                    case 6:
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
