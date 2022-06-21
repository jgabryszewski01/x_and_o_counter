using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace x_and_o_counter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj tekst: ");
            string tekst = Convert.ToString(Console.ReadLine());
            int xcounter = 0;
            int ocounter = 0;
            bool equal;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == 'x' || tekst[i] == 'X')
                {
                    xcounter++;
                }
                else if (tekst[i] == 'o' || tekst[i] == 'O')
                {
                    ocounter++;
                }
            }
            if (xcounter == ocounter) { equal = true; }
            else { equal = false; }
            Console.WriteLine("Wynik to: \n" + equal);
            Console.ReadKey();
        }
    }
}

