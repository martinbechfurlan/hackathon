using System;

namespace abuela
{
    public class Program
    {
        class DecimalToBinary
        {
            static void Main(string[] args)
            {
                Console.Write("Decimal: ");
                int decimalNumber = int.Parse(Console.ReadLine());
                int num1 = decimalNumber;
                int remainder;
                string result = string.Empty;
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;
                }
                Console.Write("Decimal 2: ");
                int decimalNumber2 = int.Parse(Console.ReadLine());
                int num2 = decimalNumber2;
                int remainder2;
                string result2 = string.Empty;
                while (decimalNumber2 > 0)
                {
                    remainder2 = decimalNumber2 % 2;
                    decimalNumber2 /= 2;
                    result2 = remainder2.ToString() + result2;
                }


             


                int count = result.Split('1').Length - 1;
                int count2 = result2.Split('1').Length - 1;
                int count4 = count + count2;
                
                Console.WriteLine("Binary1:  {0}", result);
                Console.WriteLine("Binary2:  {0}", result2);
           
                Console.WriteLine("cantidad de avellanas: " + count4.ToString());
            }
        }
    }

}