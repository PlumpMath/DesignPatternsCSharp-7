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
		/*
		 * Specifics to Qt.
		 */
	}
}
