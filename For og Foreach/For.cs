using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_og_Foreach
{
    internal class For
    {
        public For()
        {

        }

        public void ForExample(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(i);
            }

            //En for løkke bruger man til at køre igennem en blok kode et bestemt antal gange, og det
            //antal vælger man selv.
        }
    }
}
