/*Created by Aamer Saleem Mohammed*/
/**********************************/
using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LARGEST NUMBER\nPlease provide two Integers\n");

            int num1=Convert.ToInt32(Console.ReadLine());
                                                            //Input numbers
            int num2 = Convert.ToInt32(Console.ReadLine());


            //Comparing numbers

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is LARGER than " + num2);
            }
         
            else if (num2 > num1)
            {
                Console.WriteLine(num2 + " is LARGER than " + num1);
            }

            else Console.WriteLine(num1 + "is EQUAL " + num2);

            Console.ReadLine();
        }
    }
}
