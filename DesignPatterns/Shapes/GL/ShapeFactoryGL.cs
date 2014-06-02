using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.GL
{
	public class ShapeFactoryGL : ShapeFactory
	{
		public override Circle CreateCircle(double x, double y, double r)
		{
			return new CircleGL(x, y, r);
		}

		public override Rectangle CreateRectangle(double x, double y, double w, double h)
		{
			return new RectangleGL(x, y, w, h);
		}

		public override CompositeShape CreateComposite(params Shape[] shapes)
		{
			return new CompositeShapeGL(shapes);
		}
	}
}
