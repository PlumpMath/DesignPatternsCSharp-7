using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Shapes;

namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			var shapes = new List<Shape>();

			shapes.Add(new Rectangle(10, 30, 5, 4));
			shapes.Add(new Circle(10, 3, 13));

			var totalArea = shapes.Aggregate(0.0, (area, s) => area += s.CalcArea());
			Console.WriteLine("Total Surface Area:", totalArea);
		}
	}
}
