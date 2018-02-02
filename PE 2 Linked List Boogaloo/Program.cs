using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2_Linked_Lists_Pt_2
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomLinkedList<int> list = new CustomLinkedList<int>();
			for (int x = 1; x <= 6; x++)
			{
				list.Add(x);
			}
			Console.WriteLine("Count = " + list.Count);
			CustomLinkedNode<int> currentNode = list.HeadNode;
			while (currentNode != null)
			{
				Console.WriteLine(currentNode.Value);
				currentNode = currentNode.NextNode;
			}
			try
			{
				list.Remove(200);
			}
			catch(IndexOutOfRangeException e)
			{
				Console.WriteLine("IndexOutOfRangeException: " + e.ToString());
			}
			try
			{
				list.Remove(0);
				list.Remove(list.Count - 1);
				list.Remove(2);
				Console.WriteLine("Count = " + list.Count);
				currentNode = list.HeadNode;
				while (currentNode != null)
				{
					Console.WriteLine(currentNode.Value);
					currentNode = currentNode.NextNode;
				}
			}
			catch
			{
				Console.WriteLine("Something went horribly wrong.");
			}
		}
	}
}