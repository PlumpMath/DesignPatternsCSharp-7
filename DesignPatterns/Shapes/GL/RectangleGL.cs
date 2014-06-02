using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.GL
{
	class RectangleGL : Rectangle
	{
		public RectangleGL(double x, double y, double w, double h)
			: base(x, y, w, h)
		{
		}

		public RectangleGL(RectangleGL other)
			: base(other)
		{
		}

		public override Shape Clone()
		{
			return new RectangleGL(this);
		}
	}
}
