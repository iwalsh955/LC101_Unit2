using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Studio_4._8
{
    
    class Program
    {
        static void Main(string[] args)
        {
            menu theMenu = new menu();
            theMenu.addItem("Pep Pizzaaaaa", 420.99, "pizza bro", "main course");
            theMenu.output();
            theMenu.addItem("Cheese Pizzaaaaa", 420.99, "pizza bro", "main course");
            theMenu.output();
            theMenu.addItem("Cheese Pizzaaaaa11111", 420.99, "pizza bro", "main course");
            theMenu.addItem("Cheese Pizzaaaaa22222", 420.99, "pizza bro", "main course");
            theMenu.addItem("Cheese Pizzaaaaa33333", 420.99, "pizza bro", "main course");
            theMenu.output();


        }
    }
}
