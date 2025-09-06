using Session_01.Data;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.Arm;
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

            #region LINQ - Aggregate Operators

            #region Q1
            //1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine(Result);

            #endregion

            #region Q2
            //2. Return a list of customers and how many orders each has.

            //var Result = from c in CustomerList
            //             select new
            //             {
            //                 CustomerName = c.CustomerName,
            //                 OrdersCount = c.Orders?.Count() ?? 0
            //             };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"CustomerName: {item.CustomerName}, OrdersCount: {item.OrdersCount}");
            //}

            #endregion

            #region Q3
            //3. Return a list of categories and how many products each has

            //var Result = ProductList.GroupBy(p => p.Category)
            //                        .Select(P => new { Category = P.Key, ProductsCount = P.Count() });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, ProductsCount: {item.ProductsCount}");
            //}

            #endregion

            #region Q4
            //4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Sum();

            //Console.WriteLine(Result);

            #endregion

            #region Q5
            //5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var Result = DictionaryEnglish.Sum(S => S.Length);

            //Console.WriteLine(Result);

            #endregion

            #region Q6
            //6.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var Result = DictionaryEnglish.Min(M => M.Length);

            //Console.WriteLine(Result);

            #endregion

            #region Q7
            //7. Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            //var Result = DictionaryEnglish.Max(M => M.Length);

            //Console.WriteLine(Result);

            #endregion

            #region Q8
            //8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var Result = DictionaryEnglish.Average(A => A.Length);

            //Console.WriteLine(Result);

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region Q1
            //1. Sort a list of products by name

            //var Result = ProductList.OrderBy(p => p.ProductName);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2
            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(A => A.ToLower());

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q3
            //3.Sort a list of products by units in stock from highest to lowest.

            //var Result = from p in ProductList
            //             orderby p.UnitsInStock descending
            //             select p;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q4
            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.OrderBy(A => A.Length).ThenBy(N => N);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q5
            //5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(A => A.Length).ThenBy(A => A.ToLower());

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q6
            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var Result = from p in ProductList
            //             orderby p.Category, p.UnitPrice descending
            //             select p;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q7
            //7.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = from A in Arr
            //             orderby A.Length, A.ToLower() descending
            //             select A;

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Q8
            //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where(w => w[1] == 'i').Reverse();

            //foreach (var item in Result)
            //{ 
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion


        }
    }
}
