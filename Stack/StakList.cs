using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	class StakList
	{
		private Stack First { get; set; }
		private Stack Last { get; set; }
		public void Push(object data) 
		{
			Stack stack = new Stack(data);
			if (First == null && Last == null)
			{
				First = stack;
			}
			else 
			{
				Last = Push(Last, data);
			}
		}

		private Stack Push(Stack last, object data)
		{
			if (last == null)
			{
				last = new Stack(data);
				return last;
			}
			else if (last != null)
			{
				Last.Next = Push(last.Next, data);
			}
			return last;
		}
		public object Pull() 
		{
			if (First == null && Last == null)
			{
				object EmptyList = "Стэк пуст";
				return EmptyList;
			}
			object element = Last.Data;
			Last = First;
			if (First == null)
			{
				return element;
			}
			First = First.Next;
			Last.Next = null;

			return element;
		}
		public object Peek() 
		{
			if (Last == null)
			{
				object list = "Стэк пуст";
				return list;
			}
			else
				return Last.Data;
		}
	}
}
