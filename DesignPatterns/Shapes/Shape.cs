using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes
{
	public abstract class Shape
	{
		public abstract double CalcArea();

		public abstract void Accept(ShapeVisitor visitor);
	}
}
