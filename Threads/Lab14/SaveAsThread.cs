using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Threads
{
    class SaveAsThread
    {
        private static object lo = new object();

        public void Save(int[] a)
        {
            lock (lo)
            {
                using (StreamWriter writer = new StreamWriter("la14.txt", true))
                {
                    foreach (int i in a)
                    {
                        writer.Write(i + "  ");
                        Console.Write(i + "  ");
                    }
                    writer.WriteLine();
                    writer.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }

        public void RandZap(int[] a)
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-50, 50);
            }
        }
    }
}
