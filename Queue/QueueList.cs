using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
	class QueueList
	{
		private Queue First { get; set; }
		private Queue Last { get; set; }
		private int Count { get; set; }
		public QueueList()
		{

		}
		
		public void Enqueue(object data) 
		{
			Queue queue = new Queue(data);
			if (First == null && Last == null)
			{
				First = queue;
			}
			else 
			{
				Last = Enqueue(Last,data);
			}
			First.Next = null;
			Count++;
		}

		private Queue Enqueue(Queue next, object data)
		{
			if (next == null)
			{
				next = new Queue(data);
				return next;
			}
			else if(next!=null)
			{
				Last.Next = Enqueue(next.Next, data);
			}
			return next;
		}

		public object Dequeue()
		{
			if (First == null && Last == null)
			{
				object EmptyList = "Список пуст";
				return EmptyList;
			}
			object element = First.Data;
			First = Last;
			if (Last == null) 
			{
				return element;
			}
			Last = Last.Next;
			First.Next = null;
			
			return element;
		}
		public object Peek() 
		{
			if (First == null) 
			{
				object list = "Очередь пуста";
				return list;
			}
			else
				return First.Data;
		}
	}
}
