using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes
{
	public class Circle : Shape
	{
		public Circle(double x, double y, double radius)
		{
			this.CenterX = x;
			this.CenterY = y;
			this.Radius = radius;
		}

		public double CenterX
		{ get; set; }

		public double CenterY
		{ get; set; }

		public double Radius
		{ get; set; }
	}
}
