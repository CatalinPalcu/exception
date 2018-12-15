using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                int a = 0;
                int b = 100 / a;

                Console.WriteLine(a);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
            }
            catch (System.Exception error)
            {
                Console.WriteLine(error.Message);
            }*/
            Person pers1;
            Start:

            try
            {
                Console.WriteLine("Give the age");
                int age = Int32.Parse(Console.ReadLine());
                 pers1 = new Person(age);
            }/*
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message + ex.GetType());
                goto Start;
            }*/
            
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message + ex.GetType());
                goto Start;
            }
            catch (DressCodeException ex)
            {
                Console.WriteLine(ex.Message + ex.GetType());
                goto Start;
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            

            Console.WriteLine("The age is: "+pers1.Age);
            Console.ReadLine();

        }
    }
}
