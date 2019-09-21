namespace LSP
{
	using System;
	using System.Linq;

	internal class Program
	{
		private static void Main(string[] args)
		{
			var blender = new Blender();

			blender.MakeSmoothie(new Apple());
		}
	}

	internal class Blender
	{
		public void MakeSmoothie(Fruit fruit)
		{
			// Makes smoothie; whatever that means
		}
	}

	internal class Fruit { }

	internal class Apple : Fruit { }

	internal class Banana : Fruit { }

	internal class Orange : Fruit { }
}