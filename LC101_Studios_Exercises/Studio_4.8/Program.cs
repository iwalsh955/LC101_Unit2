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
            theMenu.output();
            theMenu.addItem("Pep Pizzaaaaa", 420.99, "pizza bro", "main course");
            theMenu.output();

        }
    }
}
