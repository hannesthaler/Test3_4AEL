using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test4AEL
{
    class Program
    {
        //**Konvertierung in Zahlensysteme
        static void Main(string[] args)
        {
           
            Titel("Dies ist ein TESt");
            Console.ReadKey();
        }
        static void Titel(string titel)
        {
            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }
    }
}
