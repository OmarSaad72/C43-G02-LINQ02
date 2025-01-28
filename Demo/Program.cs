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
        }
    }
}
