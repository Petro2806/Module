using System;
using System.Collections.Generic;
using System.Text;

namespace _09._04._2019
{
	class Selo:Punkt
	{
		public Selo(string _Name = "", int _People = 1000, int _Area = 500) :
			   base(_Name, _People, _Area)
		{
		}
		public override string ToString()
		{
			return "Selo " + Name + " have " + Convert.ToString(People) + " people and " + Convert.ToString(Area) + " km^2";
		}
	}
}
