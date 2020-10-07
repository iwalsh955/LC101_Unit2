using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_4._8
{
    class menu
    {
        private List<MenuItem> menuItems = new List<MenuItem>();
        private DateTime lastUpdated;
        public void output()
        {
            foreach (MenuItem item in menuItems)
            {
                if (item.IsNew)
                {
                    Console.Write("NEW!!!!!!   \n");
                }
                Console.Write("Name: " + item.Name + "\nPrice: $" + item.Price + "\nDescriprion: "
                        + item.Desc + "\nCategory: " + item.Category + "\n\n\n");
            }
            Console.WriteLine("last updated: " + lastUpdated + "\n");
        }
        public void addItem(string name, double price, string desc, string category)
        {
            menuItems.Add(new MenuItem(name, price, desc, category));
            lastUpdated = DateTime.Now;
            menuItems[menuItems.Count - 1].IsNew = true;
            if(menuItems.Count>1)
                menuItems[menuItems.Count - 2].IsNew = false;
        }
    }
}
