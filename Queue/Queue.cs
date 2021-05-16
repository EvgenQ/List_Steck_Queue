using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
	public class Queue
	{
		public object Data { get; private set; }
		public Queue Next { get; set; }
		public Queue()
		{

		}
		public Queue(object data)
		{
			Data = data;
		}
	}
}
