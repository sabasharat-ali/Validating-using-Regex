using System;
using System.Text.RegularExpressions;

namespace CC_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex q1 = new Regex("^[a-z A-Z]{1}[a-z A-Z 0-9 _ - .]+[@gmail @yahoo]+[.com .co]+$");
            Console.WriteLine("string matched:" + q1.IsMatch("sabasharat.ali12@gmail.com"));
        }
    }
}
