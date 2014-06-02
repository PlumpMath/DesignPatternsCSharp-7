using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes
{
	public abstract class ShapeFactory
	{
		public abstract Circle CreateCircle(double x, double y, double r);

		public abstract Rectangle CreateRectangle(double x, double y, double w, double h);

		public abstract CompositeShape CreateComposite(params Shape[] shapes);
	}
}
