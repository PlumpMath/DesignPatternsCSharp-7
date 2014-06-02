using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shapes.GDI
{
	public class RectangleGDI : Rectangle
	{
		public RectangleGDI(double x, double y, double w, double h)
			: base(x, y, w, h)
		{
		}
		/*
		 * Functionality specific to GDI
		 */ 
	}
}
