using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Class._17._03._2022.Models
{
    class Product
    {
        public int No;
        public string Name;
        public double Price;
        public int Count;

       
        public Product(int no,string name,double price)
        {
            No = no;
            Name = name;
            Price = price;
        }
    }
}
