using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Shapes;

namespace DesignPatterns.Construction
{
	public class HardCodedBuilder : AbstractBuilder
	{
		public override Shape Construct(ShapeFactory shapeFactory)
		{
			var rootShape = shapeFactory.CreateComposite();

			rootShape.Add(shapeFactory.CreateRectangle(10, 30, 5, 4));
			rootShape.Add(shapeFactory.CreateCircle(10, 3, 13));

			rootShape.Add(shapeFactory.CreateComposite(
					shapeFactory.CreateRectangle(12, 14, 2, 2),
					shapeFactory.CreateCircle(15, 18, 2)
				));

			return rootShape;
		}
	}
}
