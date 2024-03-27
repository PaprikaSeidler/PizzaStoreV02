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

            UserDialog userDialog = new UserDialog(Menu);
            userDialog.UI();
        }
    }
}
