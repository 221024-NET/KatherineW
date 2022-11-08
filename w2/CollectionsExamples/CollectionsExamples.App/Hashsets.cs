using System;
using System.Collections.Generic;

namespace CollectionsExamples
{
    class Hashsets
    {
        //public HashSet<DateTime> hs = new HashSet<DateTime>();
        public HashSet<int> hs = new HashSet<int>();
        public HashSet<int> hs2 = new HashSet<int>();
        public int hashsetLength = 100;
        Random rand = new Random();

        public Hashsets()
        {
            for (int i = 0; i < hashsetLength; i++)
            {
                hs.Add(rand.Next(101));
            }
        }

        public void HashSetTest()
        {
            for (int i = 0; i < 101; i++)
            {
                if (hs.Contains(i))
                {
                    Console.Write(i + " ");
                    if (i % 2 == 0)
                    {
                        hs2.Add(i);
                        hs.Remove(i);
                    }
                }
            }
            hs.UnionWith(hs2);
            Console.WriteLine("\n{0} HashSet items remaining", hs.Count());
        }
    }
}