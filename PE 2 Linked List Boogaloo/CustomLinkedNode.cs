using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2_Linked_Lists_Pt_2
{
	class CustomLinkedNode<T>
	{
		private T value;
		private CustomLinkedNode<T> nextNode;
		public T Value
		{
			get
			{
				return value;
			}
			set
			{
				this.value = value;
			}
		}
		public CustomLinkedNode<T> NextNode
		{
			get
			{
				return nextNode;
			}
			set
			{
				nextNode = value;
			}
		}
		public CustomLinkedNode(T value, CustomLinkedNode<T> nextNode)
		{
			this.value = value;
			this.nextNode = nextNode;
		}
	}
}