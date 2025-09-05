using Microsoft.VisualBasic;

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


        }
    }
}
