using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Shapes;

namespace DesignPatterns.Visitors
{
	public class CountingVisitor : ShapeVisitor
	{
		public int Circles { get; set; }
		public int Rectangles { get; set; }
		public int Composites { get; set; }

		public override void VisitCircle(Circle circle)
		{
			this.Circles++;
		}

		public override void VisitRectangle(Rectangle rectangle)
		{
			this.Rectangles++;
		}

		public override void VisitCompositeShape(CompositeShape composite)
		{
			this.Composites++;

			foreach(var c in composite.Shapes)
			{
				c.Accept(this);
			}
		}
	}
}
