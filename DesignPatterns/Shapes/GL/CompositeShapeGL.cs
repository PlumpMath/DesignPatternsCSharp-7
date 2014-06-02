using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.GL
{
	class CompositeShapeGL : CompositeShape
	{
		public CompositeShapeGL(params Shape[] shapes)
			: base(shapes)
		{
		}
	}
}
