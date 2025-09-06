using Microsoft.VisualBasic;
using Session_01.Data;
using static Session_01.ListGenerator;

namespace Session_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------- Vedio 01 --------------------------------------
            #region Implicitly Type Local Varibale [var, Dynamic]

            #region Var
            //string Data = "Ahmed";

            //var Data = "Ahmed"; // Implicitly Typed
            //                    // Complier will Detect Datatype Of Varriable at Compilition Time
            //                    // Based on its intial Value

            ////var x = null; // Invalid

            //var Data; // Invalid

            //Data = null;

            //Data = "Mostafa";

            ////Data = 10; // Invalid

            #endregion

            #region Dynamic
            //dynamic Data = "Ali";
            //                // CLR will Dectect Datatype Of Varriable At RunTime
            //                // Based on it is Last Assign Value

            //dynamic X;

            //dynamic Y = null;

            //Data = 10;
            //Data = true;

            //foreach (var item in collection)
            //for (var i = 0;i < args.Length;i++) 

            #endregion

            //var x = null;
            //dynamic x = null;

            //Console.WriteLine(x);

            #endregion

            //-------------------------------------- Vedio 02 --------------------------------------
            #region Exctention Methods
            //int X = 12345;
            ////X.
            ////int Y = IntExtention.Reverse(X);
            //int Y = X.Reverse();

            //Console.WriteLine(Y);

            //long Z = 123469789156;

            //long A = Z.Reverse();

            //Console.WriteLine(A);

            #endregion

            //-------------------------------------- Vedio 03 --------------------------------------
            #region Anonymous Type
            //Employee employee = new Employee() { Id = 10, Name = "Mona", Salary = 8000 };

            //object Emp01 = new { Id = 10, Name = "Mona", Salary = 8000 };
            //Console.WriteLine(Emp01.Salary);

            //int X = 5;

            //Console.WriteLine(X.GetType().Name);

            //var Emp03 = new { Id = 10, Name = "Mona", Salary = 8000 };

            ////Console.WriteLine(Emp03.GetType().Name);// <>f__AnonymousType0`3
            ////Console.WriteLine(Emp03.Salary);

            //var Emp04 = new { Id = Emp03.Id, Name = Emp03.Name, Salary = 5000 }; // C# 09
            //var Emp05 = Emp03 with { Salary = 2000 }; // C# 10

            ////Console.WriteLine($"Emp 03 = {Emp03}");
            ////Console.WriteLine($"Emp 04 = {Emp04}");
            ////Console.WriteLine($"Emp 05 = {Emp05}");
            ////Console.WriteLine($"Emp 03 = {Emp03.GetType().Name}");// <>f__AnonymousType0`3
            ////Console.WriteLine($"Emp 04 = {Emp04.GetType().Name}");// <>f__AnonymousType0`3
            ////Console.WriteLine($"Emp 05 = {Emp05.GetType().Name}");// <>f__AnonymousType0`3

            //// The Same Anonymous Type as long as:
            //// 1. Same Properties Name [Case Senstive]
            //// 2. Same Properties Order

            //var Emp06 = new { id = 10, Name = "Mona", Salary = 8000 };
            //var Emp07 = new { Name = "Mona", id = 10, Salary = 8000 };
            //Console.WriteLine($"Emp 06 = {Emp06.GetType().Name}");// <>f__AnonymousType1`3
            //Console.WriteLine($"Emp 07 = {Emp07.GetType().Name}");// <>f__AnonymousType2`3

            #endregion

            //-------------------------------------- Vedio 04 --------------------------------------
            #region What is LINQ
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> OddNumbers = Numbers.Where(Num => Num % 2 == 1).ToList();

            //foreach (int num in OddNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            //-------------------------------------- Vedio 05 --------------------------------------
            #region Linq Syntax [Fluent Syntax - Query Syntax]
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region Fluent Syntax
            //1. Fluent Syntax

            //1.1 Call "LINQ Operators" as Static Method
            //List<int> OddNumbers = Enumerable.Where(Numbers, Num => Num % 2 == 1).ToList();

            // 1.2 Call "LINQ Operators" As Extension Method [Recommended]
            //List<int> OddNumbers = Numbers.Where(Num => Num % 2 == 1).ToList();

            //foreach (int num in OddNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region Query Syntax - Like SQL Server style
            ////2. Query Syntax - Like SQL Server style

            ////Select *
            ////From Numbers N
            ////Where N % 2 == 1

            //var OddNumbers = from N in Numbers
            //                 where N % 2 == 1
            //                 select N;

            //// Must Be Begin With Keyword 'From'
            //// Must be End With Select Or Groupby

            //foreach (int num in OddNumbers)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #endregion

            //-------------------------------------- Vedio 06 --------------------------------------
            #region LINQ Execution Ways

            #region Deferred Execution [Latest Version of Data]
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(Num => Num % 2 == 1);

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (int num in OddNumbers) // 1 3 5 7 9 11 13 15
            //{
            //    Console.Write($"{num} ");
            //}

            #endregion

            #region Immediate Execution
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(Num => Num % 2 == 1).ToList();

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (int num in OddNumbers) // 1 3 5 7 9
            //{
            //    Console.Write($"{num} ");
            //}

            #endregion

            #endregion

            //-------------------------------------- Vedio 07 --------------------------------------
            #region Data Setup
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);

            #endregion

            //-------------------------------------- Vedio 08 --------------------------------------    
            #region Filtration [Restrication] Operators - Where

            #region Get Elements Out Of Stock
            //// 1. Fluent Syntax
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //// 2. Query Syntax

            ////Select *
            ////From ProductList P
            ////Where P.UnitsInStock == 0

            //Result = from P in ProductList
            //         where P.UnitsInStock == 0
            //         select P;

            #endregion

            #region Get Elements In Stock And In Category Of Meat/Poultry

            //// 1. Fluent Syntax
            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            //// 2. Query Syntax

            //Result = from P in ProductList
            //         where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //         select P;

            #endregion

            #region Get First 10 Products That Are Out Of Stock
            //// Fluent Syntax Only
            //// Indexed Where
            //var Result = ProductList.Where((P, I) => I < 10 && P.UnitsInStock == 0);

            #endregion

            #endregion

            //-------------------------------------- Vedio 09 --------------------------------------
            #region Transformation [Projection] Operators [Select , Select Many]

            #region Select Product Name
            //// 1. Fluent Syntax
            //var Result = ProductList.Select(p => p.ProductID);

            //// 2. Query Syntax
            //Result = from P in ProductList
            //         select P.ProductID;

            #endregion

            #region Select Customer Name
            //// 1. Fluent Syntax
            //var Result = CustomerList.Select(c => c.CustomerName);

            //// 2. Query Syntax
            //Result = from C in CustomerList
            //         select C.CustomerName;

            #endregion

            #region Select Customer Orders
            //// 1. Fluent Syntax
            //var Result = CustomerList.SelectMany(c => c.Orders);

            //// 2. Query Syntax
            //Result = from C in CustomerList
            //         from O in C.Orders
            //         select O;

            #endregion

            #region Select Product Id and Product Name
            //// 1. Fluent Syntax
            //var Result = ProductList.Select(p => new { p.ProductID, p.ProductName });

            //// 2. Query Syntax
            //Result = from P in ProductList
            //         select new 
            //         { 
            //             P.ProductID, 
            //             P.ProductName 
            //         };

            #endregion

            #region Select Product In Stock And Apply Discount 10 % On Its Price
            //// 1. Fluent Syntax
            //var Result = ProductList.Where(p => p.UnitsInStock > 0)
            //                        .Select(p => new
            //                        {
            //                            Id = p.ProductID,
            //                            Name = p.ProductName,
            //                            OldPrice = p.UnitPrice,
            //                            NewPrice = p.UnitPrice - (p.UnitPrice * 0.1m)
            //                        });

            //// 2. Query Syntax
            //Result = from P in ProductList
            //         where P.UnitsInStock > 0
            //         select new
            //         {
            //             Id = P.ProductID,
            //             Name = P.ProductName,
            //             OldPrice = P.UnitPrice,
            //             NewPrice = P.UnitPrice - (P.UnitPrice * 0.1m)
            //         };

            #endregion

            #region Get Product Index And Name that are In Stock
            // Indexed Select

            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //    .Select((P, I) => new
            //    {
            //        Index = I,
            //        Name = P.ProductName
            //    });

            #endregion

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            //-------------------------------------- Vedio 10 --------------------------------------
            #region Ording Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]

            #region Get Products Ordered By Price Asc
            //// 1. Fluent Syntax
            //var Result = ProductList.OrderBy(P => P.UnitPrice);

            //// 2. Query Syntax
            //Result = from P in ProductList
            //         orderby P.UnitPrice
            //         select P;


            #endregion

            #region Get Products Ordered By Price Desc
            //// 1. Fluent Syntax
            //var Result = ProductList.OrderByDescending(P => P.UnitPrice);

            //// 2. Query Syntax
            //Result = from P in ProductList
            //         orderby P.UnitPrice descending
            //         select P;

            #endregion

            #region Get Products Ordered By Price Asc and Number Of Items In Stock
            //// 1. Fluent Syntax
            //var Result = ProductList.OrderBy(P => P.UnitPrice)
            //                         .ThenBy(P => P.UnitsInStock)
            //                         .Reverse();

            //// 2. Query Syntax
            //Result = from P in ProductList
            //         orderby P.UnitPrice, P.UnitsInStock descending
            //         select P;

            #endregion

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //-------------------------------------- Vedio 11 --------------------------------------
            #region Elements Operator - Immediate Execution [Valid Only With Fluent Syntax]
            //List<Product> TestProduct = new List<Product>();

            //var Result = ProductList.FirstOrDefault();
            //Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);

            //var Result = TestProduct.LastOrDefault();
            //Result = TestProduct.LastOrDefault(P => P.UnitsInStock == 0);

            //var Result = ProductList.ElementAtOrDefault(0);

            //var Result = ProductList.Single();
            //var Result = ProductList.SingleOrDefault();

            //Console.WriteLine(Result?.ProductName ?? "Not Found");

            // Hypird Syntax => Fluent syntax + Query Syntax
            // Hypird Syntax => (Query Syntax).Fluent syntax

            //var Result = (from P in ProductList
            //              where P.UnitsInStock == 0
            //              select new
            //              {
            //                  P.ProductID,
            //                  P.ProductName,
            //                  P.UnitsInStock
            //              }).FirstOrDefault();

            //Console.WriteLine(Result);

            #endregion

        }
    }
}
