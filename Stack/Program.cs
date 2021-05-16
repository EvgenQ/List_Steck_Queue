using System;

namespace Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			StakList list = new StakList();
			int[] num = { 1, 2, 3, 4, 5, 6, 7 };
			list.Push("fhgafsdhag");
			list.Push(456);
			list.Push(num);
			object element1 = list.Pull();
			object element2 = list.Pull();
			object element3 = list.Pull();
			object element4 = list.Pull();
			Console.WriteLine($"{element1} {element2} {element3} {element4}");
			Console.WriteLine(list.Peek());
			Console.ReadLine();
		}
	}
}
