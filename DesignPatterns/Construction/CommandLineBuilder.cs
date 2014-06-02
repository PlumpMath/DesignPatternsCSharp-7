using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Shapes;

namespace DesignPatterns.Construction
{
	public class CommandLineBuilder : AbstractBuilder
	{
		public override Shape Construct()
		{
			string line = Console.ReadLine();

			var shape = new CompositeShape();
			while(line != string.Empty)
			{
				var parts = line.Split(' ');
				if (parts[0] == "circle")
				{
					double x = double.Parse(parts[1]);
					double y = double.Parse(parts[2]);
					double r = double.Parse(parts[3]);

					shape.Add(new Circle(x, y, r));
				}
				else if (parts[0] == "rectangle")
				{
					double x = double.Parse(parts[1]);
					double y = double.Parse(parts[2]);
					double w = double.Parse(parts[3]);
					double h = double.Parse(parts[4]);

					shape.Add(new Rectangle(x, y, w, h));
				}
				else if (parts[0] == "complex")
				{
					shape.Add(this.Construct());
				}

				line = Console.ReadLine();
			}

			return shape;
		}
	}
}
