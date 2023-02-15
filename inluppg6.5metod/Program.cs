using System;

namespace inluppg64metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Längst("hej vad heter du", "Vad gör du, eller varför gör du"));
        }
        static string Längst(string sträng1, string sträng2)
        {
            if (sträng1.Length > sträng2.Length)
            {
                return sträng1;
            }
            else if (sträng1.Length == sträng2.Length)
            {
                return sträng1 + sträng2;
            }
            else
            {
                return sträng2;
            }
        }
    }
}