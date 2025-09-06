using System.Collections.Generic;
using static Session_01.ListGenerator;
namespace Session_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region Q1
            //1. Find all products that are out of stock.

            //var Result = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2
            //2. Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3
            //3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((name, index) => name.Length < index);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Element Operators

            #region Q1
            //1.Get first Product out of Stock

            //var Result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(Result);

            #endregion

            #region Q2
            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(Result is not null ? Result :"Not Fount");

            #endregion

            #region Q3
            //Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(Result);

            #endregion

            #endregion


        }
    }
}
