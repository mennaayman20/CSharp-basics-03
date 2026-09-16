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







        }
    }
}
