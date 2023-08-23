using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_og_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Her udskrives et resultat fra en For løkke: \n");
            ForShowExample();
            Console.WriteLine("\nHer udskrives et resultat fra en Foreach løkke: \n");
            ForeachShowExample();
            Console.ReadKey();
        }

        public static void ForShowExample()
        {
            For @for = new For();
            int inputLength = 5;
            @for.ForExample(inputLength);
        }

        public static void ForeachShowExample()
        {
            Foreach @foreach = new Foreach();
            string[] fruits = { "Banana", "Apple", "Kiwi", "Grape" };
            @foreach.ForeachExample(fruits);
        }
    }
}
