using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
	class List
	{
		Node head;
		Node tail;
		public int count { get { return count; } private set { } }
		public void Add(object data) 
		{
			Node node = new Node(data);
			if (head == null && tail == null)
			{
				head = node;
				tail = node;
			}
			else 
			{
				tail.Next = node;
				tail = node;
			}
			count++;
		}
		public void ViewContent() 
		{
			int x = 1;
			Node node = head;
			while (node != null) 
			{
				Console.WriteLine($"№{x} {node.Data}");
				node = node.Next;
				x++;
			}
		}
		public void Delete(object data) 
		{
			Node node = new Node();
			if (head.Data.Equals(data))
			{
				head = head.Next;
			}
			else
			{
				node = FindToDelete(head.Next, data);
				head.Next = node;
			}
		}

		private Node FindToDelete(Node head, object data)
		{
			Node node = new Node();
			if (head.Data.Equals(data))
			{
				
				node = head.Next;
				head = node;
			}
			else
			{
				node = FindToDelete(head.Next, data);
				head.Next = node;
				if (head.Next == null)
				{
					tail = head;
					count--;
				}
			}
			
			return head;
		}

		public void Find(object data) 
		{

			if (data == head.Data)
			{
				Console.WriteLine($"You find {head.Data}");
			}
			else if(data != head.Data) 
			{
				Find(head.Next,data);
			}
			else
				Console.WriteLine("NotFind");
		}
		private Node Find(Node next, object data)
		{
			if (data == next.Data)
			{
				Console.WriteLine($"You find \"{next.Data}\"");
			}
			else if (data != next.Data)
			{
				if (next.Next == null)
				{
					Console.WriteLine("NotFind");
					return next;
				}
				else
					Find(next.Next, data);
			}
			return next;
		}

	}
}
