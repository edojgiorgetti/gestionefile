using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionefile
{
    internal class Reader
    {
        private string FilePath;

        public Reader(string Path)
        {
            FilePath = Path;
        }
        public void LeggiFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) 
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("Errore nella lettura del file" + e.Message);
            }            
        }
    }
}
