using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DesignPatterns.Shapes;

namespace DesignPatterns.Visitors
{
	public class XmlOutVisitor : ShapeVisitor
	{
		private static readonly XNamespace XmlNamespace = XNamespace.Get("http://tempuri.org/");
		private Stack<XElement> nodeStack = new Stack<XElement>();

		public XDocument Document { get; private set; }
		public XmlOutVisitor()
		{
			var rootNode = new XElement(XmlNamespace + "root");
			this.nodeStack.Push(rootNode);

			this.Document = new XDocument(rootNode);
		}

		public override void VisitCircle(Circle circle)
		{
			var circleNode = new XElement(XmlNamespace + "Circle");

			circleNode.Add(new XAttribute("x", circle.CenterX));
			circleNode.Add(new XAttribute("y", circle.CenterY));
			circleNode.Add(new XAttribute("r", circle.Radius));

			nodeStack.Peek().Add(circleNode);
		}

		public override void VisitRectangle(Rectangle rectangle)
		{
			var rectangleNode = new XElement(XmlNamespace + "Rectangle");

			rectangleNode.Add(new XAttribute("x", rectangle.X));
			rectangleNode.Add(new XAttribute("y", rectangle.Y));
			rectangleNode.Add(new XAttribute("width", rectangle.Width));
			rectangleNode.Add(new XAttribute("height", rectangle.Height));

			nodeStack.Peek().Add(rectangleNode);
		}

		public override void VisitCompositeShape(CompositeShape composite)
		{
			var newSubNode = new XElement(XmlNamespace + "Composite");
			nodeStack.Peek().Add(newSubNode);
			nodeStack.Push(newSubNode);

			foreach (var shape in composite.Shapes)
			{
				shape.Accept(this);
			}

			nodeStack.Pop();
		}
	}
}
