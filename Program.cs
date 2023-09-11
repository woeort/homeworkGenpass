using System;

namespace PasswordGeneration
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "J", "j", "K", "k", "L", "l", "M", "m", "N", "n", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "V", "v", "W", "w", "X", "x", "Z", "z" };
            string iPass = "";
            Random rnd = new Random();
            for (int i = 0; i < 6; i = i + 1)
            { 
                iPass = iPass + arr[rnd.Next(0, 57)];

            }
            Console.WriteLine(iPass);
            Console.ReadKey();
        }
    }
}
