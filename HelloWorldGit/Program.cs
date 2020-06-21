using System;

namespace HelloWorldGit
{
    class Program
    {
        static void HelloFromDeb()
        {
            Console.WriteLine("Deb says hello world!");
        }

        static void HelloFromAlex()
        {
            Console.WriteLine("Alex says hello world!");
        }
        static void Main(string[] args)
        {
            HelloFromAlex();
            HelloFromDeb();
        }
    }
}
