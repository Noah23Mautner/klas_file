using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klas_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string putanja = @"c:\test\";

            Console.WriteLine(putanja);

            string datoteka = "ime.txt";
            string putanjaDatoteke = putanja + datoteka;


            Console.WriteLine("Upisi ime:");
            string ime = Console.ReadLine();

            if(File.Exists(putanjaDatoteke))
            {
                Console.Write("Datoteka postoji!");
                if(!Directory.Exists("bkp"))
                {
                    Directory.CreateDirectory(putanja+"bkp");
                }
                File.Copy(putanjaDatoteke, putanja + "bkp\\ime_"
                    + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt");
            }
            else
            {
                File.Create(putanjaDatoteke);
                Console.WriteLine("Kreirao sam datoteku");
            }
            File.WriteAllText(putanjaDatoteke, ime);
            
            Console.ReadKey();
        }
    }
}
