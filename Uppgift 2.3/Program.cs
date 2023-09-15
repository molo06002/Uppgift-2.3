// See https://aka.ms/new-console-template for more information
using System;
namespace Uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 300;
            int extra = 500;
            string test = "kostnaden för antal kilometer: ";
            Console.WriteLine("Hur Många dagar ska du köra?");
           string x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            Console.WriteLine("Hur många kilometer ska du köra?");
            string k = Console.ReadLine();
            int t = Convert.ToInt32(k);
            int R = t * 1;
            int m = 300 + (500 * y) - 500 + R;
            string r = "kr";
            string pris = "Kostnaden blir: ";
            Console.WriteLine(pris + m + r + " " + test + R + r);//
        }
    }
}