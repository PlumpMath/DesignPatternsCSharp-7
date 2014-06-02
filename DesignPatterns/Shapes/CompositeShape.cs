using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes
{
	public class CompositeShape : Shape
	{
		private List<Shape> shapes;

		public CompositeShape()
		{
			this.shapes = new List<Shape>();
		}

		public CompositeShape(params Shape[] shapes)
		{
			this.shapes = new List<Shape>(shapes);
		}

		public override double CalcArea()
		{
			return this.shapes.Aggregate(0.0, (area, s) => area + s.CalcArea());
		}

		public IEnumerable<Shape> Shapes
		{
			get
			{
				return this.shapes;
			}
		}

		public void Add(Shape shape)
		{
			this.shapes.Add(shape);
		}

		public bool Remove(Shape shape)
		{
			return this.shapes.Remove(shape);
		}
	}
}
