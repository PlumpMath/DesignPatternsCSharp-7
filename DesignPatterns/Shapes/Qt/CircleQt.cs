using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.Qt
{
	class CircleQt : Circle
	{
		public CircleQt(double x, double y, double r) 
			: base(x, y, r)
		{
		}

		public CircleQt(CircleQt other)
			: base(other)
		{
		}

		public override Shape Clone()
		{
			return new CircleQt(this);
		}

		/*
		 * Specifics to Qt.
		 */
	}
}
