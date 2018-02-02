using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_1_Linked_Lists
{
	class CustomLinkedList<T>
	{
		private int count = 0;
		private CustomLinkedNode<T> headNode;
		private CustomLinkedNode<T> tailNode;
		public int Count { get { return count; } }
		public CustomLinkedNode<T> HeadNode
		{
			get
			{
				return headNode;
			}
			set
			{
				headNode = value;
			}
		}
		public CustomLinkedNode<T> TailNode
		{
			get
			{
				return tailNode;
			}
			set
			{
				tailNode = value;
			}
		}
		public CustomLinkedList() { }
		public void Add(T data)
		{
			CustomLinkedNode<T> newNode = new CustomLinkedNode<T>(data, null);
			if (HeadNode != null)
			{
				TailNode.NextNode = newNode;
				TailNode = newNode;
				count++;
			}
			else
			{
				HeadNode = newNode;
				TailNode = newNode;
				count++;
			}
		}
		public T GetData(int index)
		{
			CustomLinkedNode<T> currentNode = HeadNode.NextNode;
			if (index < 0 || index >= Count)
			{
				throw new IndexOutOfRangeException();
			}
			else
			{
				if (index == 0) { return headNode.Value; }
				else if (index == Count - 1) { return tailNode.Value; }
				else
				{
					for (int x = 1; x < index; x++)
					{
						currentNode = currentNode.NextNode;
					}
				}
			}
			return currentNode.Value;
		}
	}
}
