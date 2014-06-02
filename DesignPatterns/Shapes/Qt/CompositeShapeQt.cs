using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.Qt
{
	class CompositeShapeQt : CompositeShape
	{
		public CompositeShapeQt(params Shape[] shapes)
			: base(shapes)
		{
		}

		public CompositeShapeQt(CompositeShapeQt other)
			: base(other)
		{
		}

		public override Shape Clone()
		{
			return new CompositeShapeQt(this);
		}
	}
}
