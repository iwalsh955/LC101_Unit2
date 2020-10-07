using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_4._8
{
    class menu
    {
        private List<MenuItem> menuItems = new List<MenuItem>();
        private bool newItem;
        private DateTime lastUpdated;
        public menu()
        {
            newItem = true;
            menuItems.Add(new MenuItem("spare ribs", 10.99, "ribs", "main course"));
            menuItems.Add(new MenuItem("chicken soup", 5000.25, "warm soup", "appetizer"));
            menuItems.Add(new MenuItem("chocolate cake", 0.99, "cold cake", "dessert"));
            lastUpdated = DateTime.Now;
        }
        public void output()
        {
            foreach (MenuItem item in menuItems)
            {
                if (newItem && item.Name == menuItems[menuItems.Count-1].Name)
                {
                    Console.Write("NEW!!!!!!   \n");
                    newItem = false;
                }
                Console.Write("Name: " + item.Name + "\nPrice: $" + item.Price + "\nDescriprion: "
                        + item.Desc + "\nCategory: " + item.Category + "\n\n\n");
            }
            Console.WriteLine("last updated: " + lastUpdated + "\n");
        }
        public void addItem(string name, double price, string desc, string category)
        {
            menuItems.Add(new MenuItem(name, price, desc, category));
            newItem = true;
            lastUpdated = DateTime.Now;
        }
    }
}
