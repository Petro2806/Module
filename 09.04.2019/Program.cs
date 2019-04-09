using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _09._04._2019
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Kraina> Krainy = new List<Kraina>();
				string[] lines = File.ReadAllLines("C:/Users/Shop/source/repos/Programming_Univer/Proga/09.04.2019/09.04.2019/input.txt");
				
			foreach (var line in lines)
			{
				try
				{
					Krainy.Add(new Kraina(line));
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			Console.WriteLine("Task 1");
			Dictionary<string, int> NamePeople = new Dictionary<string, int>();
			foreach (var kraina in Krainy)
			{
				NamePeople.Add(kraina.Name, kraina.AllPeople());
				Console.WriteLine(kraina.Name + " " + Convert.ToString(NamePeople[kraina.Name]));
			}
			Console.WriteLine("Task 2");
			Console.WriteLine("Enter lowerbound: ");
			int lowerbound = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter upperbound: ");
			int upperbound = Convert.ToInt32(Console.ReadLine());
			var Task2List = Krainy.Where(x => x.Punkts.Count >= lowerbound && x.Punkts.Count <= upperbound)
				.ToList();
			foreach (var elem in Task2List)
			{
				Console.WriteLine(Convert.ToString(elem));
			}
			Console.WriteLine("Task 3");
			var Task3List = Krainy.Where(x => x.SeloPeople() > x.CityPeople())
				.ToList()
				.OrderBy(x => x.Name);
			foreach(var elem in Task3List)
			{
				Console.WriteLine(Convert.ToString(elem));
			}
		}
	}
}
