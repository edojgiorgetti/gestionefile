using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionefile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il path");
            string path = Console.ReadLine();

            Writer w = new Writer(path);

            w.ScriviFile();

            Console.WriteLine("operazione completata");
        }
    }
}
