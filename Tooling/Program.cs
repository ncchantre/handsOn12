using System;
// See https://aka.ms/new-console-template for more information
// NC

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMessage());
        }

        public static string GetMessage()
        {
            return "Hello, World!";
        }
    }
}
