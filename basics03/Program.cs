using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace basics03
{
    internal class Program
    {

        #region Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main.
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        #endregion


        #region Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        #endregion


        #region Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
        
        static void AddBonusPages(int pages)
        {
            pages += 50;
            
          
        }

        #endregion


        #region Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect tosee, and why? 

        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        #endregion


        #region Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5 ?
       
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
        #endregion


        #region Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward.
        static void ReplaceArray(ref double[] Prices)
        {
            // Replaces the original array reference entirely with a new array
            Prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion


        #region Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it1and print the price if foundWrite a method PrintBookInfo(string title, int pages = 300) where pages is optional.Callit once with only a title, and once passing both a title and pages.
        static bool TryGetPrice(string title, out double pricee)
        {
            if(title== "Clean Code")
            {
                pricee = 25.5;
                return true;
            }
            pricee = 0.0;
            return false;
        }

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }

        #endregion



        static void Main(string[] args)
        {
            #region Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).
            
            double[] array1 = [25.5, 40.0, 33.75];
            Console.WriteLine(array1[1]);

            #endregion


            #region Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            int[,] shelfCopies = {{3, 5}, {1, 4}};
            Console.WriteLine(shelfCopies[1, 0]);

            #endregion


            #region call the PrintWelcomeMessage method from Main to display the welcome message.
            PrintWelcomeMessage();
            #endregion


            #region call the PrintBookTitle method from Main with the argument "Clean Code" to display the book title.
            PrintBookTitle("Clean Code");
            #endregion


            #region call the AddBonusPages method from Main with the argument 400 to add bonus pages and print the result. What do you expect to see, and why?
            // print 400 because the method does not modify the original variable, it only modifies a copy of it.
            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);
            #endregion


            #region call the ApplyDiscount method from Main with the argument double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to see, and why?
            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]);
            #endregion


            #region call the AddBonusPagesByRef method from Main with the argument 400 to add bonus pages and print the result. How is the result different from question 5?
            // print 450 because the method modifies the original variable by using the ref keyword, which allows the method to access and modify the original variable.
            int pages2 = 400;
            AddBonusPagesByRef(ref pages2);
            Console.WriteLine(pages2);
            #endregion


            #region call 
            double[] Prices = { 1.99, 2.99, 3.99, 4.99 };

            // Call the method using the ref keyword
            ReplaceArray(ref Prices);

            // Print the length of the new array
            Console.WriteLine($"prices.Length: {Prices.Length}");
            #endregion


            #region 
            if (TryGetPrice("Clean Code", out double price))
            {
                Console.WriteLine($"Price found: ${price}");
            }
            else
            {
                Console.WriteLine("Price not found.");
            }

            Console.WriteLine();

            PrintBookInfo("The Pragmatic Programmer");               
            PrintBookInfo("Design Patterns", 416);
            #endregion


            #region 
            PrintBookInfo(pages: 416, title: "The Pragmatic Programmer");
            #endregion











        }
    }
}
