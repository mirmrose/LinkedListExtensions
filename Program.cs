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
			{
				LinkedList<object> list1 = new LinkedList<object>();
				list1.AddLast("A");
				list1.AddLast("B");
				list1.AddLast("C");
				list1.AddLast("D");
				list1.AddLast("E");
				list1.AddLast("F");
				list1.AddLast("G");
				list1.AddLast("H");
				list1.AddLast("I");
				list1.AddLast("J");

				int index = 2;

                //var retVal = LinkedListExtensions.RemoveAt(index, list1);
                object o = "New Val";
                var retVal = LinkedListExtensions.InsertAt(index, o,list1);

                Console.WriteLine(retVal);

				foreach (var s in list1)
					Console.WriteLine(s);

                LinkedListExtensions.PrintReverse(list1);
			}

		}
	}
}
