using System;
using Language;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var translation = new Language.Localise().Translate(args[0]);

            Console.WriteLine(translation);
        }
    }
}
