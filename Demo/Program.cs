using Assignment;
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
            Dictionary<long, string> products = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID, p => p.ProductName);
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
