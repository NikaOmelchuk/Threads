using System;
using System.IO;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[8];
            int[] c = new int[5];

            Console.WriteLine();
            Console.WriteLine("Запис у файлi:");
            Console.WriteLine();

            Thread t1 = new Thread(() =>
            {
                SaveAsThread s = new SaveAsThread();
                s.RandZap(a);
                s.Save(a);
            });

            Thread t2 = new Thread(() =>
            {
                SaveAsThread s = new SaveAsThread();
                s.RandZap(b);
                s.Save(b);
            });

            Thread t3 = new Thread(() =>
            {
                SaveAsThread s = new SaveAsThread();
                s.RandZap(c);
                s.Save(c);
            });

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine();
        }
    }
}
