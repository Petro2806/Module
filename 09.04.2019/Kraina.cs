using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._04._2019
{
	class Kraina
	{
		public string Name { set; get; }
		public List<Punkt> Punkts;
		public Kraina(string Line)
		{
			Punkts = new List<Punkt>();
			string[] elems = Line.Split();
			Name = elems[0];
			for (int i = 1; i < elems.Length; i += 4)
			{
				if(i+3>=elems.Length)
					throw new Exception("Bad File Format not full info about punkt");

				Punkt elem;
				if(elems[i]=="Selo")
				{
					elem = new Selo(elems[i+1],Convert.ToInt32(elems[i+2]),Convert.ToInt32(elems[i+3]));
				}
				else
				{
					if (elems[i] == "City")
						elem = new City(elems[i + 1], Convert.ToInt32(elems[i + 2]), Convert.ToInt32(elems[i + 3]));
					else
						throw new Exception("Bad File Format not City not Selo");
				}
				Punkts.Add(elem);
			}
			Punkts = Punkts.OrderBy(x => x.Name).ToList();
		}
		public int SeloPeople()
		{
			int Result = 0;
			foreach(var elem in Punkts)
			{
				if (elem is Selo)
					Result += elem.People;
			}
			return Result;
		}
		public int CityPeople()
		{
			int Result = 0;
			foreach (var elem in Punkts)
			{
				if (elem is City)
					Result += elem.People;
			}
			return Result;
		}
		public int AllPeople()
		{
			int Result = 0;
			foreach (var elem in Punkts)
			{
				Result += elem.People;
			}
			return Result;
		}
		public override string ToString()
		{
			string Result = Name;
			foreach(var elem in Punkts)
			{
				Result += " ";
				Result += Convert.ToString(elem);
			}
			return Result;
		}

	}
}
