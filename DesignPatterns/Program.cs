using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Construction;
using DesignPatterns.Shapes;
using DesignPatterns.Shapes.GDI;
using DesignPatterns.Shapes.GL;
using DesignPatterns.Shapes.Qt;

namespace DesignPatterns
{
	public class Program
	{
		public Program(AbstractBuilder builder, ShapeFactory shapeFactory)
		{
			this.Builder = builder;
			this.ShapeFactory = shapeFactory;
		}

		public void Run()
		{
			var rootShape = this.Builder.Construct(this.ShapeFactory);
			var totalArea = rootShape.CalcArea();
			Console.WriteLine("Total Surface Area: {0}", totalArea);
		}

		public AbstractBuilder Builder { get; set; }

		public ShapeFactory ShapeFactory { get; set; }

		static void Main(string[] args)
		{
			var program = new Program(
							new CommandLineBuilder(),
							new ShapeFactoryGDI());

			program.Run();
		}
	}
}
