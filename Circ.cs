using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLibrary
{
    public class Circ : Figure
    {

		public double Rad { get; set; }

		public Circ(string tName, double rad) : base(tName)
		{

			Rad = rad;

		}

		public override double Square()
		{

			return Math.Round(3.14f * Math.Pow(Rad, 2), 1);

		}

	}

}