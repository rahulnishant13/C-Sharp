using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionCodes
{
    class ArrayListC
    {
        private ArrayList al;

        public ArrayListC()
        {
            al = new ArrayList();
        }

        public void addToList()
        {
            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);
        }

        public void doOperations()
        {
            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();

            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            //al.InsertRange(4, al);
            //al.Insert(4, 45);
            
            Console.WriteLine();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
