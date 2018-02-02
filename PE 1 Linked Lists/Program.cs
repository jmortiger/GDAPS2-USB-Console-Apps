using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_1_Linked_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomLinkedList<int> list = new CustomLinkedList<int>();
			for (int x = 1; x <= 5; x++)
			{
				list.Add(x);
			}
			Console.WriteLine("Count = " + list.Count);
			CustomLinkedNode<int> currentNode = list.HeadNode;
			while(currentNode != null)
			{
				Console.WriteLine(currentNode.Value);
				currentNode = currentNode.NextNode;
			}
		}
	}
}
