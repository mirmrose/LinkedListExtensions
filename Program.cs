using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
            //{
            //	LinkedList<object> list1 = new LinkedList<object>();
            //	list1.AddLast("A");
            //	list1.AddLast("B");
            //	list1.AddLast("C");
            //	list1.AddLast("D");
            //	list1.AddLast("E");
            //	list1.AddLast("F");
            //	list1.AddLast("G");
            //	list1.AddLast("H");
            //	list1.AddLast("I");
            //	list1.AddLast("J");

            //	int index = 2;

            //             //var retVal = LinkedListExtensions.RemoveAt(index, list1);
            //             object o = "New Val";
            //             var retVal = LinkedListExtensions.InsertAt(index, o,list1);

            //             Console.WriteLine(retVal);

            //	foreach (var s in list1)
            //		Console.WriteLine(s);

            //             LinkedListExtensions.PrintReverse(list1);
            //}

            //random example
            int[] arr1 = { 1, 2, 2, 1, 5, 2, 3, 5, 4 };
            CountOccurrencesWithHashMap(arr1);
            Console.ReadKey();
		}
   
        public static void CountOccurrencesWithHashMap(int[] arr1)
        {
            SortedDictionary<int, int> hashMap1 = new SortedDictionary<int, int>();


            for (int i = 0; i <= arr1.Length - 1; i++)
            {
                //int int1 = Convert.ToInt32(arr1.GetValue(i));
                int int1 = Convert.ToInt32(arr1[i]);

                if (hashMap1.ContainsKey(int1))
                    // already included, increment by 1
                    hashMap1[int1] = hashMap1[int1] + 1;
                else
                    // add to hashmap
                    hashMap1.Add(int1, 1);
            }

            foreach (var keyvaluepair in hashMap1)
                Console.WriteLine($"[{keyvaluepair.Key}] {keyvaluepair.Value}");
        }
    }
}
