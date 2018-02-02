using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2_Linked_Lists_Pt_2
{
	class CustomLinkedList<T>
	{
		private int count = 0;
		private CustomLinkedNode<T> headNode;
		private CustomLinkedNode<T> tailNode;
		public int Count { get { return count; } }
		public CustomLinkedNode<T> HeadNode
		{
			get { return headNode; }
			set { headNode = value; }
		}
		public CustomLinkedNode<T> TailNode
		{
			get { return tailNode; }
			set { tailNode = value; }
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
		public T Remove(int index)
		{
			CustomLinkedNode<T> removeNode;
			if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
			else
			{
				removeNode = HeadNode;
				if (Count == 1)
				{
					removeNode = HeadNode;
					HeadNode = null;
					TailNode = null;
				}
				else if (index == 0)
				{
					removeNode = HeadNode;
					HeadNode = HeadNode.NextNode;
				}
				else if (index == Count - 1)
				{
					removeNode = TailNode;
					TailNode = GetNode(Count - 2);
					TailNode.NextNode = null;
				}
				else
				{
					CustomLinkedNode<T> beforeRemoveNode = GetNode(index - 1);
					removeNode = beforeRemoveNode.NextNode;
					beforeRemoveNode.NextNode = removeNode.NextNode;
				}
				count--;
				return removeNode.Value;
			}
		}
		public T GetData(int index)
		{
			CustomLinkedNode<T> currentNode = HeadNode.NextNode;
			if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
			else
			{
				if (index == 0) { return headNode.Value; }
				else if (index == Count - 1) { return tailNode.Value; }
				else
					for (int x = 1; x < index; x++) currentNode = currentNode.NextNode;
			}
			return currentNode.Value;
		}
		public CustomLinkedNode<T> GetNode(int index)
		{
			CustomLinkedNode<T> currentNode = HeadNode.NextNode;
			if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
			else
			{
				if (index == 0) { return headNode; }
				else if (index == Count - 1) { return tailNode; }
				else
					for (int x = 1; x < index; x++) currentNode = currentNode.NextNode;
			}
			return currentNode;
		}
	}
}