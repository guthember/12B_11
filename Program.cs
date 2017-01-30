using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Statisztika
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> adatok = new List<string>();

            FileStream file = new FileStream(@"C:\Users\guthe\documents\visual studio 2010\Projects\Statisztika\adat.txt", FileMode.Open);
            StreamReader Be = new StreamReader(file);

            while (!Be.EndOfStream)
            {
                adatok.Add(Be.ReadLine());
            }
            
            Be.Close();
            file.Close();

            foreach (string sz in adatok)
            {
                Console.WriteLine(sz);
            }

            Console.ReadLine();
        }
    }
}
