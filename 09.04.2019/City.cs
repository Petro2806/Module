using System;

namespace _09._04._2019
{
	class City : Punkt
	{
		public City(string _Name = "", int _People = 1000, int _Area = 500) :
			base(_Name, _People, _Area)
		{
		}
		public override string ToString()
		{
			return "City " + Name + " have " + Convert.ToString(People) + " people and " + Convert.ToString(Area) + " km^2";
		}
	}
}
