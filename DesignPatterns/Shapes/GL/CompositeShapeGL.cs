using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.GL
{
	public class CompositeShapeGL : CompositeShape
	{
		public CompositeShapeGL(params Shape[] shapes)
			: base(shapes)
		{
		}

		public CompositeShapeGL(CompositeShapeGL other)
			: base(other)
		{
		}

		public override Shape Clone()
		{
			return new CompositeShapeGL(this);
		}
	}
}
