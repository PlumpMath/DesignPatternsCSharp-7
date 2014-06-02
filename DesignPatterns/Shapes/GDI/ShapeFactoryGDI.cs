using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.GDI
{
	public class ShapeFactoryGDI : ShapeFactory
	{
		public override Circle CreateCircle(double x, double y, double r)
		{
			return new CircleGDI(x, y, r);
		}

		public override Rectangle CreateRectangle(double x, double y, double w, double h)
		{
			return new RectangleGDI(x, y, w, h);
		}

		public override CompositeShape CreateComposite(params Shape[] shapes)
		{
			return new CompositeShapeGDI(shapes.ToArray());
		}
	}
}
