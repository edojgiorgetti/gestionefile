using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace gestionefile
{
    internal class Writer
    {
        private string filePath;

        public Writer (string Path)
        {
            filePath = Path;
        }

        public void ScriviFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath)) 
                {
                    writer.WriteLine("prima riga");
                    writer.WriteLine("seconda riga");
                    writer.WriteLine("terza riga");
                }
                Console.WriteLine("file scritto con successo");
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Errore nella scrittura del file" + ex.Message);
            }

        }
    }
}
