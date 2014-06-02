using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.GDI
{
	class CompositeShapeGDI : CompositeShape
	{
		public CompositeShapeGDI(params Shape[] shapes)
			: base(shapes)
		{
		}

		public CompositeShapeGDI(CompositeShapeGDI other)
			: base(other)
		{
		}

		public override Shape Clone()
		{
			return new CompositeShapeGDI(this);
		}
	}
}
