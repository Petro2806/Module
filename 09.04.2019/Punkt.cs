using System;

namespace _09._04._2019
{
	class Punkt
	{
		public string Name { set; get; }
		public int People { set; get; }
		public int Area { set; get; }
		public Punkt(string _Name = "", int _People = 1000, int _Area = 500)
		{
			Name = _Name;
			People = _People;
			Area = _Area;
		}
		public override string ToString()
		{
			return Name + " have " + Convert.ToString(People) + " people and " + Convert.ToString(Area) + " km^2";
		}
	}
}
