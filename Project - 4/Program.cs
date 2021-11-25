using System;

namespace Project___4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir cümle giriniz :");
            string sentence = Console.ReadLine();
            string[] array = sentence.Split(" ");
            Console.WriteLine(" toplam kelime : " + array.TotalWords());
            Console.WriteLine(" toplam harf : " + array.TotalLetters());
        }


    }

    public static class Methods
    {
        public static int TotalWords(this string[] param)
        {
            return param.Length;
        }
        public static int TotalLetters(this string[] param)
        {
            int totalLetter = 0;
            foreach (string item in param)
            {
                char[] letters = item.ToCharArray();
                totalLetter += letters.Length;
            }
            return totalLetter;
        }
    }
}
