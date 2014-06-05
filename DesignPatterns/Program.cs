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
			var rootShape = new CompositeShape();

			rootShape.Add(new Rectangle(10, 30, 5, 4));
			rootShape.Add(new Circle(10, 3, 13));

			rootShape.Add(new CompositeShape(
					new Rectangle(12, 14, 2, 2),
					new Circle(15, 18, 2)
				));

			var totalArea = rootShape.CalcArea();

			Console.WriteLine("Total Surface Area: {0}", totalArea);
		}
	}
}
