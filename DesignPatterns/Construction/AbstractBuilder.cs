using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Shapes;

namespace DesignPatterns
{
	public abstract class AbstractBuilder
	{
		public abstract Shape Construct();
	}
}
