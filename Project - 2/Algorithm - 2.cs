using System;
using System.Collections.Generic;

namespace Project___2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Pozitif 2 tam sayı girin");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine(n+" tane tam sayı giriniz");
            for (int i = 0; i < n; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("---------------------");
            foreach (int item in numbers)
            {
                if (item.IsEventNumbers(m))
                {
                    Console.WriteLine(m + " 'e tam bölünen sayılar : " + item.ToString());
                }
            }
        }
    }

    public static class Methods
    {
        public static bool IsEventNumbers(this int param, int m)
        {
            return param % m == 0;
        }
    }
}
