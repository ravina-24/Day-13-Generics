using System;

namespace Day_13_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Find max Number");
            //int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            //Console.WriteLine(output);
            //double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
            //Console.WriteLine(doubleoutput);
            //string strigoutput = MaximumNumberCheck.MaximumStringNumber("apple", "banana", "peach");
            //Console.WriteLine(strigoutput);


            int[] intArray = { 912, 744, 832, 455, 478 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
          
            double[] doubleArray = { 67.2, 96.4, 8.32, 55.5, 34.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
           
            string[] stringArray = { "mango", "apple", "grapes", "peach", "kiwi" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            
            Console.ReadKey();


        }
    }
}
