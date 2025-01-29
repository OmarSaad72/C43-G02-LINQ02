using System.Diagnostics;
using static Assignment.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region Element Operators
            //Q1- Get first Product out of Stock:
            //var result = ProductList.Where(p => p.UnitsInStock == 0).FirstOrDefault();
            //Console.WriteLine(result);

            /*Q2- Return the first product whose Price > 1000, unless there is no
            match, in which case null is returned: */
            //var result = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
            //Console.WriteLine(result?.ProductName ?? "Not Found!");

            //Q3- Retrieve the second number greater than 5:
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int result = (from a in Arr 
                          where a > 5
                          select a).ElementAtOrDefault(3);
            Console.WriteLine(result);
            #endregion
        }
    }
}
