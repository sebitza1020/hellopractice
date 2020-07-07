using System;

namespace Hello
{
    internal class Mesaje
    {
        internal static void Afiseaza(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        internal static void Afiseaza(string mesaj, string limba)
        {
            switch (limba)
            {
                case "EN": Console.WriteLine("Hello world!"); break;
                case "RO": Console.WriteLine("Salut lume!"); break;
                case "HU": Console.WriteLine("Helló Világ"); break;
                default:
                    Console.WriteLine("Salut default!");
                    break;
            }
        }
    }
}