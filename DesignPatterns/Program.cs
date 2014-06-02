using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Construction;
using DesignPatterns.Shapes;

namespace DesignPatterns
{
	class Program
	{
		public Program(AbstractBuilder builder)
		{
			this.Builder = builder;
		}

		public void Run()
		{
			var rootShape = this.Builder.Construct();
			var totalArea = rootShape.CalcArea();
			Console.WriteLine("Total Surface Area: {0}", totalArea);
		}

		public AbstractBuilder Builder { get; set; }

		static void Main(string[] args)
		{
			var program = new Program(
							new CommandLineBuilder());

			program.Run();
		}
	}
}
