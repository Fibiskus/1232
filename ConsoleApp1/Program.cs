using System;

namespace ConsoleApp1
{
    public class Program
    {
        static public string Convert(int x)
        {
            string n;
            switch (x)
            {
                case 1: n = "Monday"; break;
                case 2: n = "Tuesday"; break;
                case 3: n = "Wednesday"; break;
                case 4: n = "Thursday"; break;
                case 5: n = "Friday"; break;
                case 6: n = "Saturday"; break;
                case 7: n = "Sunday"; break;
                default: n = "NULL"; break;
            }
            return n;
        }
        static public void Main(string[] args)
        {
            string p;
            Console.WriteLine("Enter a number from 1 to 7:");
            int a = int.Parse(Console.ReadLine());
            if (a >= 1 && a <= 7)
            {
                p = Convert(a);
                Console.WriteLine("\nTransformation:\n" + a + " - " + p);
            }
            else
                Console.WriteLine("\nThe value you entered is incorrect");
        }
    }
}