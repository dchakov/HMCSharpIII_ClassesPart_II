using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericClass
{
    class MainMethod
    {
        static void Main()
        {
            int capacity = 6;
            GenericList<int> test1 = new GenericList<int>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                test1.Add(34+ i);
            }
            
            Console.WriteLine(test1.ToString());
            int index = 1;
            Console.WriteLine("Element at index {0} is {1}",index,test1[1]);
            test1.Add(18);
            Console.WriteLine("Double capacity {0}",test1.Capacity);
            int removeIndex = 3;
            Console.WriteLine("Removed element {0} at index {1}",test1.RemoveAt(removeIndex),removeIndex);
            Console.WriteLine(test1.ToString());
            Console.WriteLine("Insert element {0} at index {1}",21,4);
            test1.Insert(21, 4);
            Console.WriteLine(test1.ToString());
            Console.WriteLine("IndexOf {0} is {1}",36,test1.IndexOf(36));

            Console.WriteLine("Min element {0}",test1.Min());
            Console.WriteLine("Max element {0}",test1.Max());
            Console.WriteLine("List clear");
            test1.Clear();
            Console.WriteLine("Count = {0}",test1.Count);
            Console.WriteLine("Capacity = {0}",test1.Capacity);
            GenericList<string> test2 = new GenericList<string>(capacity);

        }
    }
}
