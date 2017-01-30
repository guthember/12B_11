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
            // leghosszabb adat a fájlban? 
            // kiiratni a méretét
            // feltételezés
            int max = adatok[0].Length;
            int min = adatok[0].Length;

            // Adatok kiírása
            foreach (string sz in adatok)
            {
                Console.WriteLine("{0}({1})",sz,sz.Length);
            }
            
            // Vizsgálat 2. elemtől a végéig
            for (int i = 1; i < adatok.Count; i++)
            {
                // Van-e nagyobb érték?
                if (adatok[i].Length > max)
                {
                    max = adatok[i].Length;
                }

                // Van-e kissebb érték?
                if (adatok[i].Length < min)
                {
                    min = adatok[i].Length;
                }
            }

            Console.WriteLine("A leghosszabb adat: {0} db karakter.", max);
            Console.WriteLine("A legrövidebb adat: {0} db karakter.", min);

            Console.ReadLine();
        }
    }
}
