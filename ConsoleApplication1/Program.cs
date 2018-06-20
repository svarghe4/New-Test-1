using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            string file = @"C:\Users\AMIT\Desktop\filehandling.txt";
            File.WriteAllText(file, "hello");
           Console .WriteLine( File.ReadAllText(file));

            try
            {

               // Console.WriteLine(arithmetic(1,0));
                method2();

            }
            

            catch (Exception e)
            {
               // throw ;
                Console.WriteLine(e.StackTrace   );
            }
 Console.ReadLine();

        }
        
        public static int arithmetic(int n1, int n2)
        {
            int n3;
            //if (n1 == n2)
           // {
             //   throw new Exception("no are equal");
             //
            //}
            int answ =dividebyzero (n1,n2 );
            return answ;
            //throw new Exception("Divide by ze3ro not allowed");

        }

       

        public static void method1()
        {
            try
            {
                throw new Exception("this is from method1");

            }
            catch (Exception e)
            {
                throw ;
            }

        }
        public static void method2()
        {
            try
            {
                method1();

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static int dividebyzero(int n1, int n2)
        {
            int n3;
            if( (n1 < 0) || (n2 <0))
            {
                throw new Exception("negative no not allowed");
            }
            int answ = n1 / n2;
            return answ ;
            //throw new Exception("Divide by ze3ro not allowed");

        }
    }

    public class NumDenException : Exception
    {
      public   NumDenException(string message) : base(message)
        {

        }
    }

}

























// Calling a static function from one class to anoitherclass ??










