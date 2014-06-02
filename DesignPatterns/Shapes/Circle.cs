using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes
{
	public abstract class Circle : Shape
	{
		public Circle(double x, double y, double radius)
		{
			this.CenterX = x;
			this.CenterY = y;
			this.Radius = radius;
		}

		public Circle(Circle other)
		{
			this.CenterX = other.CenterX;
			this.CenterY = other.CenterY;
			this.Radius = other.Radius;
		}

		public double CenterX
		{ get; set; }

		public double CenterY
		{ get; set; }

		public double Radius
		{ get; set; }

		public override double CalcArea()
		{
			return this.Radius * this.Radius * Math.PI;
		}

		public override void Accept(ShapeVisitor visitor)
		{
			visitor.VisitCircle(this);
		}
	}
}
