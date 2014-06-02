using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.GL
{
	class CircleGL : Circle
	{
		public CircleGL(double x, double y, double r)
			: base(x, y, r)
		{
		}

		public CircleGL(CircleGL other)
			: base(other)
		{
		}

		public override Shape Clone()
		{
			return new CircleGL(this);
		}

		/*
		 * Specifics to GL
		 */
	}
}
