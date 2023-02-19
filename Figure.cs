using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLibrary
{
    public abstract class Figure
    {
		public string Type { get; set; }

		public Figure(string tName)
		{

			Type = tName;

		}

		public abstract double Square();

		public override string ToString()
		{

			return $"Введённый тип фигуры: " + Type;

		}

	}

}
