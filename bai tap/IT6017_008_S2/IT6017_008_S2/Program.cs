using System;
using System.Collections;

namespace IT6017_008_S2
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList li1 = new ArrayList();
            li1.Add(100);
            li1.Add("Xuan Hoang");
            li1.Add(100.5);
            li1.Add(true);

            Console.WriteLine("Size: " + li1.Count);
        }
    }
}
