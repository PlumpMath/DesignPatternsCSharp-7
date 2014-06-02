using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DesignPatterns.Construction;
using DesignPatterns.Shapes;
using DesignPatterns.Shapes.GDI;
using DesignPatterns.Shapes.GL;
using DesignPatterns.Shapes.Qt;
using DesignPatterns.Visitors;

namespace DesignPatterns
{
	public class Program
	{
		public Program(AbstractBuilder builder, ShapeFactory shapeFactory)
		{
			this.Builder = builder;
			this.ShapeFactory = shapeFactory;
		}

		private void CalculateSurfaceArea(Shape rootShape)
		{
			var totalArea = rootShape.CalcArea();
			Console.WriteLine("Total Surface Area: {0}", totalArea);
		}

		private void PrintElementCounts(Shape rootShape)
		{
			var elementCounts = new CountingVisitor();
			rootShape.Accept(elementCounts);

			Console.WriteLine("Circles: {0}, Rectangles: {1}, Composites: {2}",
				elementCounts.Circles, elementCounts.Rectangles, elementCounts.Composites);
		}

		private void WriteAsXml(Shape rootShape)
		{
			var xmlvisitor = new XmlOutVisitor();
			rootShape.Accept(xmlvisitor);

			var sb = new StringBuilder();
			using (var xmlWriter = XmlWriter.Create(sb, new XmlWriterSettings()
				{
					Indent = true,
					IndentChars = new string(' ', 2)
				}))
			{
				xmlvisitor.Document.Save(xmlWriter);
			}

			Console.WriteLine(sb.ToString());
		}

		public void Run()
		{
			var rootShape = this.Builder.Construct(this.ShapeFactory);

			this.CalculateSurfaceArea(rootShape);
			this.PrintElementCounts(rootShape);
			this.WriteAsXml(rootShape);
		}

		public AbstractBuilder Builder { get; set; }

		public ShapeFactory ShapeFactory { get; set; }

		static void Main(string[] args)
		{
			var program = new Program(
							new HardCodedBuilder(),
							new ShapeFactoryGDI());

			program.Run();
		}
	}
}
