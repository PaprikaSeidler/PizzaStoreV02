using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreV02
{
    public class Customer
    {
        //private  string _phoneNo;
        private static int _Id = 1;
       // private static readonly Random random = new Random();

        public Customer(string name, string address, string phoneNo) 
        { 
            Name = name;
            Address = address;
            PhoneNo = phoneNo;
            id = _Id;
            Id();
        }

        public Customer() 
        { 
        
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int id { get; set; }
        public string PhoneNo { get; set; }

        public static int Id() 
        {
            _Id++;
            return _Id; 
        }

        //private static string RandomPhoneNo()
        //{
        //    string PhoneNo = string.Format("{0:00000000}", random.Next(10000000, 99999999));
        //    return PhoneNo;
        //}

        public override string ToString()
        { 
            return $"Customer ID: {id} \n" +
                   $"Name: {Name} \n" +
                   $"Address: {Address} \n" +
                   $"Phone number: +45 {PhoneNo}\n" +
                   $"  ";
        }
        public static Customer Parse(string input)
        {
            return new Customer();
        }
    }
}
