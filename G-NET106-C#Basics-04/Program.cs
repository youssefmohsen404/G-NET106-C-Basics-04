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
    }
}
