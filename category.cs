using System;
using System.Collections.Generic;
using System.Collections; 

namespace Category
{
    class Category
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public double price { get; set; } 
        public void SayHello()
        {
            Console.WriteLine("Hello World");
        }
    }
}