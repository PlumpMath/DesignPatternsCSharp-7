using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes
{
	public abstract class ShapeVisitor
	{
		public abstract void VisitCircle(Circle circle);

		public abstract void VisitRectangle(Rectangle rectangle);

		public abstract void VisitCompositeShape(CompositeShape composite);
	}
}
