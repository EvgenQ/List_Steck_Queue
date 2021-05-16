using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	class Stack
	{
		public object Data { get; private set; }
		public Stack Next { get; set; }
		public Stack()
		{

		}
		public Stack(object data)
		{
			Data = data;
		}
	}
}
