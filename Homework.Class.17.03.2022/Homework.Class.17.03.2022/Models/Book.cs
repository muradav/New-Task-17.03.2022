using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Class._17._03._2022.Models
{
    class Book:Product
    {
        public string Genre;

        public Book(string genre, int no, string name,double price):base(no,name,price)
        {
            Genre = genre;
        }

        public void GetInfo()
        {
            Console.WriteLine($"No: {No} \n" +
                $"Name: {Name} \n" +
                $"Genre: {Genre} \n" +
                $"Price: {Price} \n" +
                $"Count: {Count}");
        }

        public void Filter(double minprice, double maxprice)
        {
            if (Price >= minprice && Price <= maxprice)
            {
                GetInfo();
            }
        }
    }
}
