using System;
using System.Collections.Generic;

namespace Project___3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            Console.Write("Bir adet tam sayı giriniz :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------");
            Console.WriteLine(n + " adet kelime giriniz");
            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }
            Console.WriteLine(words.ReverseArray());
            
        }
    }

    public static class Methods
    {
        public static string ReverseArray(this List<string> param)
        {
            param.Reverse();
            return string.Join(" - ", param);
        }
            
    }
}
