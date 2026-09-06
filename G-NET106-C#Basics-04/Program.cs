using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET106_C_Basics_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print 
            /*the second price(index 1).*/

            /*double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);*/
            #endregion
            #region Question 2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and 
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            /* int[,] shelfCopies = new int[2, 2]
             {
                 {3,5 },
                 {1,4 }
             };
             Console.WriteLine(shelfCopies[1,0]);*/
            #endregion
            #region Question 3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints 
            //"Welcome to the Library!".Call it from Main.

            // PrintWelcomeMessage();

            #endregion
            #region Question4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with 
            //"Clean Code".

            //PrintBookTitle("First page");
            #endregion
            #region Question 5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable 
            //int pages = 400; and print pages afterward. What do you expect to see, and why?

            /*  int pages = 400;
              AddBounsPages(pages);
              Console.WriteLine(pages);*/

            //pages value  won't change cause thhe parameters are passing by value with a value type so it takes a copy from the variable
            // so pages will stay equals 400
            #endregion
            #region Question 6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it 
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why?


            /*double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine("prices outside = "+prices[0]);
*/
            //prices gonna be 20.5 cause the parameters are passing by value on a reference type so it's gonna change inside and outside the function 

            #endregion
            #region Question 7 
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. 
            //Call it and print pages afterward. How is the result different from question 5 ?

            /*  int pages = 400;
              AddBounsPages(ref pages);
              Console.WriteLine("pages outside the function ="+pages);*/

            //it changes in the value inside and outside the function cause the parameters are passing by reference on a value type
            // so it takes the original value not a copy as passing parameters by value
            #endregion
            #region Question 8
            //Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a 
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward.

            /*double[] prices = { 25.5, 40.0 };
            ReplaceArray(ref prices);
            Console.WriteLine(prices.Length);*/

            #endregion
            #region Question 9 
            //Write a method bool TryGetPrice(string title, out double price) that returns true and sets 
            //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it 1 and print the price if found


            /*string title = "Clean Code";
            Console.WriteLine(TryGetPrice(title, out double price));*/

            #endregion
            #region Question 10
            //Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call 
            //it once with only a title, and once passing both a title and pages.
            
            /*PrintBookInfo(title: "action");
            PrintBookInfo(title: "action", pages:400);*/

            #endregion
        }
        /*  static void PrintWelcomeMessage()
          {
              Console.WriteLine("Welcome to the Library!");
          }*/
        /*  static void PrintBookTitle(string title) {
              Console.WriteLine("Book title:"+ title);
          }*/
        /*  static void AddBounsPages(int pages) {
              pages += 50;
          }*/
        /*static void ApplyDiscount(double[] prices) {
            prices[0] -= 5;
            Console.WriteLine("prices inside the function ="+ prices[0]);
             
            
        }*/
       /* static void AddBounsPages(ref int pages)
        {
            pages += 50;
            Console.WriteLine("pages inside the function = " + pages);
        }*/
       /*static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }*/
     /*  static bool TryGetPrice(string title , out double price)
        {
            if(title == "Clean Code")
            {
                price = 25;
                Console.WriteLine(price);
                return true;
            }
            price = 0;
            Console.WriteLine(price);
            return false;
        }*/
    /* static void PrintBookInfo(string title , int pages =300)
        {
            Console.WriteLine(title + pages);
        }*/
    }
}
