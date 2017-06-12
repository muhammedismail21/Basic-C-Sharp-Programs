/*Created by Aamer Saleem Mohammed*/
/*6/12/2017*/
using System;

namespace Fahrenheit_to_C_and_C_to_F
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1: Celsius to Fahreneheit\nEnter 2: Fahranheit to Celsius\n");
                int cf = Convert.ToUInt16(Console.ReadLine());


                // Converting Celsius to Fahrenheit
                if (cf == 1)
                {
                    Console.WriteLine("Enter temperature in Celsius: ");
                    double Celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit is: " + (Celsius * 1.8 + 32) + " F");
                }

                // Converting Fahrenheit to Celsius
                else
                {
                    Console.WriteLine("Enter temperature in Fahrenheit: ");
                    double Fahrenheit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius is: " + (Fahrenheit - 32) / 1.8 + "C");
                }

                Console.ReadLine();

            }


            catch (Exception e)
            {
                //
            }
        }
    }
}