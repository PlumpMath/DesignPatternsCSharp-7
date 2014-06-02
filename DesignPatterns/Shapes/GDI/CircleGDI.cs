using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.GDI
{
	class CircleGDI : Circle
	{
		public CircleGDI(double x, double y, double r)
			: base(x, y, r)
		{
		}

		public CircleGDI(CircleGDI other)
			: base(other)
		{
		}

		public override Shape Clone()
		{
			return new CircleGDI(this);
		}

		/*
		 * Specific to GDI
		 */
	}
}
