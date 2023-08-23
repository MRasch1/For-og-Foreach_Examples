using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_og_Foreach
{
    internal class Foreach
    {
        public Foreach()
        {

        }

        public void ForeachExample(string[] Fruits)
        {
            foreach (var item in Fruits)
            {
                Console.WriteLine(item);
            };

            //En foreach løkke bruger man til at køre igennem elementer i et array
        }

    }
}
