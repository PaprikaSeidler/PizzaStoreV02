using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStoreV02
{
    public class Pizza
    {         
         private static int _menuNo = 1;
         public static void ResetMenuNo()       
         { 
             _menuNo = 0; 
         }

         public Pizza(string name, int price)
         {
             Name = name;
             Price = price;
             MenuNo = _menuNo;
             MenuNr();
         }

        public Pizza() 
        {
            MenuNo = _menuNo;
            MenuNr();
        }

        public string Name { get; set; }

        public int Price { get; set; }

        public int MenuNo { get; set; }

        public static int MenuNr()
        {
            _menuNo++;
            return _menuNo;
        }

        public override string ToString()
        {
            return $"No.: {MenuNo}. {Name}, {Price} kr.";
        }

    }
}
