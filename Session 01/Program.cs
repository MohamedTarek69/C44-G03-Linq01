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



        }
    }
}
