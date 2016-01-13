using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program.Main();

namespace SummaKeskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään käyttäjältä luku
            Console.Write("Anna 3 lukua: ");
            // int luku = int.Parse(rivi); // 1
            
            int luku1,luku2,luku3;
            luku1 = int.Parse(Console.ReadLine());
            luku2 = int.Parse(Console.ReadLine());
            luku3 = int.Parse(Console.ReadLine());

            int summa = (luku1 + luku2 + luku3);
            int keskiarvo = (summa / 3);
            Console.WriteLine("Lukujen summa: " + summa);
            Console.WriteLine("Lukujen keskiarvo: " + keskiarvo);

            Console.ReadLine();
        }
    }
}
