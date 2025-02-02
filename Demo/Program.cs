using Assignment;
using System.Text.RegularExpressions;
using static Assignment.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Anomynous Type
            ////Employee employee = new Employee() { Id = 3, Name = "Omar", Salary = 30000 };
            //var employee = new { Id = 3, Name = "Omar", Salary = 30000 }; //Anomynous Object, Have Only "Get" don't have Set{Read Only}
            //Console.WriteLine(employee.GetType().Name);
            //Console.WriteLine(employee);
            ////employee.Name = "Ali"; //Invalid Don't have Setter
            //var employee2 = new { Id = 2, Name = "Mai", Salary = 20000, Age = 20 }; //Anomynous Object, Have Only "Get" don't have Set{Read Only} 
            //Console.WriteLine(employee2.GetType().Name);
            //Console.WriteLine(employee2);
            #endregion
            #region Extension Method
            //int x = 12345;
            //int y = x.Reverse();
            //Console.WriteLine(y);
            #endregion
            #region Element Operator
            //var result = ProductList.First();
            //Console.WriteLine(result);
            //var result = ProductList.Last();
            //Console.WriteLine(result);
            //ProductList = new List<Product>();
            //var result = ProductList.FirstOrDefault(new Product { ProductName ="Chai"});
            //Console.WriteLine(result?.ProductName ?? "Not Found");
            //var result = ProductList.LastOrDefault();
            //Console.WriteLine(result?.ProductName??"Not Found");

            ////var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            ////Console.WriteLine(result?.ProductName);
            //var result = ProductList.LastOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(result?.ProductName); 
            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 1000);
            //Console.WriteLine(result?.ProductName);
            //var result = ProductList.LastOrDefault(p => p.UnitsInStock == 1000);
            //Console.WriteLine(result?.ProductName??"Not Found");
            //var result = ProductList.ElementAtOrDefault(1000);
            //Console.WriteLine(result?.ProductName??"Not Found");
            //var discount= new List<Product>();
            //var result = discount.SingleOrDefault(); // Handled if empty
            ////var result = ProductList.SingleOrDefault();
            //Console.WriteLine(result?.ProductName??"No Data");
            //var discount = new List<Product>();
            //var result = discount.SingleOrDefault(); // Handled if empty
            ////var result = ProductList.SingleOrDefault(p => p.UnitPrice > 20);
            //Console.WriteLine(result?.ProductName ?? "No Data");
            #endregion
            #region Aggregate Operators
            //var result = ProductList.Count;
            //Console.WriteLine(result);
            //var result = ProductList.Sum(p => p.UnitPrice);
            //Console.WriteLine(result);
            //var result = ProductList.Average(p => p.UnitPrice);
            //Console.WriteLine(result);
            //var result = ProductList.Min(p => p.UnitPrice);
            //Console.WriteLine(result);
            //var result1 = ProductList.MinBy(p => p.UnitPrice);
            //Console.WriteLine(result1);
            //string[] Names = { "Omar", "Saad", "Sayed", "Ahmed" };
            //string FullName = Names.Aggregate((str01, str02) => $"{str01}{str02}");
            //Console.WriteLine(FullName);
            #endregion
            #region Casting Operators
            //List<Product> list = ProductList.Where(p => p.UnitsInStock == 0).ToList();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Product[] products = ProductList.Where(p => p.UnitsInStock == 0).ToArray();
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            //Dictionary<long, Product> products = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            //Dictionary<long, string> products = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID, p => p.ProductName);
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Generation Operators(Differed Execution)
            //Range:
            //var result = Enumerable.Range(0, 100).Where(p => p % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Repeat:
            //var result = Enumerable.Repeat(new Product() { Category="Meat"}, 10);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Empty:
            //var result = Enumerable.Empty<Product>();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Set Operators
            //var Seq01 = Enumerable.Range(0, 100);
            //var Seq02 = Enumerable.Range(50, 100);
            //var result= Seq01.Union(Seq02);
            //var result= Seq01.Concat(Seq02);
            //var result= Seq01.Intersect(Seq02);
            //var result= Seq01.Except(Seq02);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Quantifier Operators
            /*Return Bolean Value*/
            //Any:
            //Console.WriteLine(ProductList.Any());
            //Console.WriteLine(ProductList.Any(p => p.UnitsInStock == 0));
            ////All:
            //Console.WriteLine(ProductList.All(p => p.UnitsInStock > 0));
            ////Contains:
            //Console.WriteLine(ProductList.Contains(ProductList[0]));
            //SequanceEqual:
            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(50, 100);
            //Console.WriteLine(seq01.SequenceEqual(seq02));
            #endregion
            #region Transformation{Zipping} Operators
            //List<string> Words = new List<string>() { "ten", "twenty", "Thirty", "Fourty" };
            //int[] Num = { 10, 20, 30, 40, 50, 60 };
            ////var result= Num.Zip(Words); //First Overload
            ////var result = Num.Zip(Words, (Num, Words) => $"{Num}= {Words}"); //Third Overload
            //var result = Num.Zip(Words, [1, 2, 3]); //Second Overload

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion
            #region Grouping Operators
            //Ex01:
            //var result = ProductList.GroupBy(p => p.Category);
            //result = from p in ProductList
            //         group p by p.Category;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}:");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}
            //Ex02:
            //var result = ProductList.Where(p => p.UnitsInStock > 0)
            //.GroupBy(p => p.Category)
            //.Where(ProductGroup => ProductGroup.Count() > 10).Select(ProductGroup new
            //{
            //    category = ProductGroup.Key,
            //    count = ProductGroup.Count()
            //});
            //var result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //           into ProductGroup
            //             where ProductGroup.Count() > 10
            //             select new
            //             {
            //                 category = ProductGroup.Key,
            //                 count = ProductGroup.Count()
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Partition Operators
            //Take:
            //var result = ProductList.Where(p => p.UnitsInStock > 0).Take(3);
            //TakeLast:
            //var result = ProductList.Where(p => p.UnitsInStock > 0).TakeLast(3);
            //Skip:
            //var result = ProductList.Where(p => p.UnitsInStock > 0).Skip(3);
            //SkipLast:
            //var result = ProductList.Where(p => p.UnitsInStock > 0).SkipLast(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] Num = { 5, 4, 1, 3, 9, 8 };
            //TakeWhile:
            //var result = Num.TakeWhile((Num, Index) => Num > Index);
            //SkipWhile:
            //var result = Num.SkipWhile((Num, Index) => Num > Index);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Let & Into
            //var Names = new List<string>() { "Omar", "Ahmed", "Rana", "Mai", "Mohammed" };
            //var result = from n in Names
            //             //select Regex.Replace(n, "aeiouAEIOU", string.Empty)
            //             let NoVowelName= Regex.Replace(n, "[aeiouAEIOU]", string.Empty)
            //             //into: restart this query
            //             //into NoVowelName
            //             where NoVowelName.Length > 3
            //             select NoVowelName;
            //var result = Names.Select(n => Regex.Replace(n, "[aeiouAEIOU]", string.Empty)).Where(n => n.Length > 3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
