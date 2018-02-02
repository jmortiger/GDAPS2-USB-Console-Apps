using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2_Linked_Lists_Pt_2
{
	class CustomDoublyLinkedNode<T>
	{
		private T value;
		public T Value
		{
			get { return value; }
			set { this.value = value; }
		}
		private CustomDoublyLinkedNode<T> nextNode;
		public CustomDoublyLinkedNode<T> NextNode
		{
			get { return nextNode; }
			set { nextNode = value; }
		}
		private CustomDoublyLinkedNode<T> prevNode;
		public CustomDoublyLinkedNode<T> PrevNode
		{
			get { return prevNode; }
			set { prevNode = value; }
		}

		public CustomDoublyLinkedNode(T value, CustomDoublyLinkedNode<T> nextNode)
			: this(value, nextNode, null)
		{ }
		public CustomDoublyLinkedNode(T value, CustomDoublyLinkedNode<T> nextNode, CustomDoublyLinkedNode<T> prevNode)
		{
			this.value = value;
			this.nextNode = nextNode;
			this.prevNode = prevNode;
		}
	}
}