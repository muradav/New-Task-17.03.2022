using Homework.Class._17._03._2022.Models;
using System;

namespace Homework.Class._17._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {


            int quantity = GetInputInt("Please enter how many books you want: ", 1, 100);

            Book[] books = new Book[quantity];
            for (int i = 0; i < quantity; i++)
            {
                Console.Clear();

                int no = GetInputInt("Please enter the No: ", 1, 100);


                string name = GetInputString("Please enter the Name: ", 1, 100);


                string genre = GetInputString("Please enter the Genre: ", 1, 10000);


                double price = GetInputDouble("Please enter the Price: ", 1, 10000);

                                
                int count = GetInputInt("Please enter the Count: ", 1, 100);

                Console.WriteLine("=====================");

                books[i] = new Book(genre, no, name, price)
                {
                    Count = count
                };
                




            }
            Console.Clear();
            


            int input;
            do
            {
                Console.WriteLine("Press 1 for Sort books by price");
                Console.WriteLine("Press 2 for show all books");
                Console.WriteLine("Press 0 for close the program");


                input = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:

                        double minprice = GetInputDouble("Please enter the Min Price: ", 1, 1000);
                        double maxprice = GetInputDouble("Please enter the Max Price: ", 1, 1000);


                        

                        foreach (var item in books)
                        {
                            item.Filter(minprice, maxprice);
                        }
                        break;

                        

                        

                    case 2:


                        Console.WriteLine("List of Books: ");

                        foreach (var item in books)
                        {
                            item.GetInfo();
                            Console.WriteLine("===========");
                        }
                        break;


                    case 0:

                        Console.Clear();
                        break;





                }
            } while (input!=0);
        }
        



        static string GetInputString(string name, int min, int max)
        {
            string input;
            do
            {

                Console.WriteLine(name);
                input = Console.ReadLine();
            } while (input.Length < min || input.Length > max);
            return input;
        }

        static int GetInputInt(string name, int min, int max)
        {
            int input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);
            return input;

        }
        static double GetInputDouble(string name, int min, int max)
        {
            double input;
            do
            {
                Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);
            return input;

        }


    }
}
