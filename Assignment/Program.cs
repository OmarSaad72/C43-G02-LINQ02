using System.Diagnostics;
using static Assignment.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Assignment.Order;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int result = (from a in Arr 
            //              where a > 5
            //              select a).ElementAtOrDefault(3);
            //Console.WriteLine(result);
            #endregion

            #region Aggregate Operators
            //Q1- Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(p => p % 2 == 1).Count();
            //Console.WriteLine(result);

            //Q2- Return a list of customers and how many orders each has:
            //var result = CustomerList.Select(c => new
            //{
            //    Customer_ID = c.CustomerID,
            //    Customer_Name = c.CustomerName,
            //    OrdersCount = c?.Orders?.Count()
            //});
            //var result = from c in CustomerList //****************//
            //             from o in c.Orders.Count().ToString()
            //             select new
            //             {
            //                 c.CustomerID,
            //                 c.CustomerName,
            //                 OrdersCount = o.ToString(),
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q3- Return a list of categories and how many products each has:
            //var result = ProductList.Select(p => new
            //{
            //    CategoryName = p.Category,
            //    CountOfProduct = p?.ProductName?.Count()
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q4- Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Sum());
            //Console.WriteLine(Arr.Count());

            /*Q5- Get the total number of characters of all words in dictionary_english.txt
            (Read dictionary_english.txt into Array of String First).*/
            //string[] dictionary_english = File.ReadAllLines("dictionary_english.txt");
            //var result = dictionary_english.Sum(p=>p.Length);
            //Console.WriteLine(result);

            /*Q6- Get the length of the shortest word in dictionary_english.txt
            (Read dictionary_english.txt into Array of String First).*/
            //string[] dictionary_english = File.ReadAllLines("dictionary_english.txt");
            //var result = dictionary_english.MinBy(p => p.Length);
            //var result1 = dictionary_english.Min(p => p.Length);
            //Console.WriteLine(result);
            //Console.WriteLine(result1);

            /*Q7- Get the length of the longest word in dictionary_english.txt 
            (Read dictionary_english.txt into Array of String First).*/
            //string[] dictionary_english = File.ReadAllLines("dictionary_english.txt");
            //var result = dictionary_english.MaxBy(p => p.Length);
            //var result1 = dictionary_english.Max(p => p.Length);
            //Console.WriteLine(result);
            //Console.WriteLine(result1);

            /*Q8- Get the average length of the words in dictionary_english.txt 
             (Read dictionary_english.txt into Array of String First).*/
            //string[] dictionary_english = File.ReadAllLines("dictionary_english.txt");
            //var result = dictionary_english.Average(p => p.Length);
            //Console.WriteLine(result);

            //Q9- Get the total units in stock for each product category.  ####
            //var result = ProductList.Sum(p => p.UnitsInStock);
            //var result = ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    Category = c.Key,
            //    TotalInStouck = c.Sum(p => p.UnitsInStock)
            //});
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //Q10 - Get the cheapest price among each category's products ####
            //var result = ProductList.GroupBy(p => new  /***********/
            //{
            //    category = p.Category,
            //    CheapestPrice = p.UnitPrice
            //}).Min();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //var result = ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    c.Key,
            //    price = c.Min(p => p.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q11- Get the products with the cheapest price in each category(Use Let)  #####
            //Q12- Get the most expensive price among each category's products.  ####
            //var result = ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    c.Key,
            //    price = c.Max(p => p.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Q13- Get the products with the most expensive price in each category.  ####
            //Q14- Get the average price of each category's products.  ####
            var result = ProductList.GroupBy(p => p.Category).Select(c => new
            {
                c.Key,
                price = c.Average(p => p.UnitPrice)
            });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}