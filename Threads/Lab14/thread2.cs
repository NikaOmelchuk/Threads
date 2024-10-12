using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace thread2
{
    class TestFu
    {
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
