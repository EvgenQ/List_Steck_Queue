using System;

namespace Queue
{
	class Program
	{
		static void Main(string[] args)
		{
			QueueList list = new QueueList();
			int[] num = { 1, 2, 3, 4, 5, 6, 7 };
			list.Enqueue("ZXzzWW");
			list.Enqueue(234);
			list.Enqueue(num);
			object element1 = list.Dequeue();
			object element2 = list.Dequeue();
			object element3 = list.Dequeue();
			object element4 = list.Dequeue();
			Console.WriteLine($"{element1} {element2} {element3} {element4}");
			Console.WriteLine(list.Peek());
			Console.ReadLine();
		}
	}
}
