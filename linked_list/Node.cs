using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
	class Node
	{
		public object Data { get; set; }
		public Node Next { get; set; }
		public Node()
		{

		}
		public Node(object data)
		{
			Data = data;
		}
	}
}
