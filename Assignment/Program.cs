using System.Diagnostics;
using static Assignment.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Assignment.Order;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using System.Xml;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;

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
            //var result = from p in ProductList
            //             let Price = p.UnitPrice
            //             group p by p.Category
            //             into MinPrice
            //             where MinPrice.Min(ProductList.UnitPrice)
            //             select MinPrice;
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
            //var result = from p in ProductList
            //             group p by p.Category
            //             into MaxPrice
            //             select MaxPrice.Max(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}
            //Q14- Get the average price of each category's products.  ####
            //var result = ProductList.GroupBy(p => p.Category).Select(c => new
            //{
            //    c.Key,
            //    price = c.Average(p => p.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Set Operators
            //Q1- Find the unique Category names from Product List
            //var Seq1 = ProductList.Select(P => P.Category).Distinct();
            //var Seq1 = ProductList.Select(P => P.Category);
            //var Seq2 = ProductList.Select(P => P.Category);
            //var result = Seq1.Union(Seq2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /*Q2- Produce a Sequence containing the unique first letter from both
             product and customer names.*/
            //var Seq1 = ProductList.Select(P => P.ProductName[0]);
            //var Seq2 = CustomerList.Select(c => c.CustomerName[0]);
            //var result = Seq1.Union(Seq2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /*Q3- Create one sequence that contains the common first letter from 
             both product and customer names.*/
            //var Seq01 = ProductList.Select(P => P.ProductName[0]);
            //var Seq02 = CustomerList.Select(c => c.CustomerName[0]);
            //var result1 = Seq01.Intersect(Seq02);
            //var result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //var result2 = ProductList.Select(p => p.ProductName[0]).Concat(CustomerList.Select(c => c.CustomerName[0]));
            //result = result.Distinct();
            //foreach (var item in result)
            ////foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}

            /*Q4- Create one sequence that contains the first letters of product 
             names that are not also first letters of customer names.*/
            //var Seq01 = ProductList.Select(P => P.ProductName[0]);
            //var Seq02 = CustomerList.Select(c => c.CustomerName[0]);
            //var result1 = Seq01.Except(Seq02);
            //var result = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            ////result = result.Except();
            //foreach (var item in result)
            ////foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}

            /*Q5- Create one sequence that contains the last Three Characters in each 
             name of all customers and products, including any duplicates*/
            //var Seq01 = ProductList.Select(P => P.ProductName.Substring(P.ProductName.Length - 3));
            //var Seq02 = CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3));
            //var result1 = Seq01.Concat(Seq02);
            //var result = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3))
            //.Concat(CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3)));
            //foreach (var item in result)
            ////foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Partitioning Operators
            //Q1- Get the first 3 orders from customers in Washington
            //var result = CustomerList.Where(c => c.City == "Washington").Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q2- Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList.Where(c => c.City == "Washington").Skip(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /*Q3- Return elements starting from the beginning of the array until
             a number is hit that is less than its position in the array.*/
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Where((n, i) => n < i).Skip(6);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q4- Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Where(n=>n %3==0).Take(4);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Q5- Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Where((n, i) => n < i).Take(6);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Quantifiers
            /*Q1- Determine if any of the words in dictionary_english.txt(Read dictionary
             _english.txt into Array of String First) contain the substring 'ei'.*/
            //string[] dictionary_english = File.ReadAllLines("dictionary_english.txt");
            //string? substring = "ei";
            //var result = dictionary_english.Contains(substring);
            //Console.WriteLine(result);

            /*Q2- Return a grouped a list of products only for categories that have at least one product that is out of stock.*/
            //var result = ProductList.Where(p => p.UnitsInStock == 0).GroupBy(p => p.Category);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}

            /*Q3- Return a grouped a list of products only for categories that have all of their products in stock.*/
            var result = ProductList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category);
            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
            }
            #endregion
        }
    }
}