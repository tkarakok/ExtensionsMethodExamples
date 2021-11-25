using System;
using System.Collections.Generic;

namespace ProjectsForKodluyoruz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Bir adet tam sayı giriniz");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(value + " adet pozitif tam sayı giriniz");
            for (int i = 0; i < value; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);
            }
            foreach (int item in numbers)
            {
                if (item.IsEven())
                {
                    Console.WriteLine(item.ToString());
                }
            }


        }
        
    }

    public static class ExtensionMethods
    {
        public static bool IsEven(this int param)
        {
            return param % 2 == 0;
        }
    } 
}

