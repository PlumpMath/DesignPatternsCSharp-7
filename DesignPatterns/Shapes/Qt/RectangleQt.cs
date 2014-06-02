using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.Qt
{
	class RectangleQt : Rectangle
	{
		public RectangleQt(double x, double y, double w, double h)
			: base(x, y, w, h)
		{
		}

		public RectangleQt(RectangleQt other)
			: base(other)
		{
		}

		public override Shape Clone()
		{
			return new RectangleQt(this);
		}

		/*
		 * Specifics for Qt
		 */
	}
}
