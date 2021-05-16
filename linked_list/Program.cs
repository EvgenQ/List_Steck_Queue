using System;

namespace linked_list
{
	class Program
	{
		static void Main(string[] args)
		{
			List list = new List();
			int[] num = { 1, 2, 3, 4, 5, 6, 7 };

			list.Add(num);
			list.Add('P');
			list.Add(456);
			list.Add("like");
			list.Add(list);
			list.Find(11);
			list.Delete("like");
			list.ViewContent();
			Console.ReadLine();
		}
	}
}
