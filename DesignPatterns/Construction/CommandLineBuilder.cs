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
		public override Shape Construct(ShapeFactory shapeFactory)
		{
			string line = Console.ReadLine();

			var shape = shapeFactory.CreateComposite();

			while(line != string.Empty)
			{
				var parts = line.Split(' ');
				if (parts[0] == "circle")
				{
					var x = double.Parse(parts[1]);
					var y = double.Parse(parts[2]);
					var r = double.Parse(parts[3]);

					shape.Add(shapeFactory.CreateCircle(x, y, r));
				}
				else if (parts[0] == "rectangle")
				{
					var x = double.Parse(parts[1]);
					var y = double.Parse(parts[2]);
					var w = double.Parse(parts[3]);
					var h = double.Parse(parts[4]);

					shape.Add(shapeFactory.CreateRectangle(x, y, w, h));
				}
				else if (parts[0] == "complex")
				{
					shape.Add(this.Construct(shapeFactory));
				}

				line = Console.ReadLine();
			}

			return shape;
		}
	}
}
