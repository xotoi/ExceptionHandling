using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainFunc();
        }

        private static char GetFirstChar (string data)
        {
            return string.IsNullOrEmpty(data)
                ? throw new ArgumentException("Provided string is null or empty", nameof(data))
                : data[0];
        }

        private static void MainFunc()
        {
            try
            {
                Console.WriteLine("\nPlease, enter something so i could return you first character of this word!");
                var word = Console.ReadLine();
                Console.WriteLine(GetFirstChar(word));
                MainFunc();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MainFunc();
            }
        }
    }
}
