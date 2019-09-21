namespace DIP
{
	using System;
	using System.Linq;
	using HighLevel;

	internal class Program
	{
		private static void Main(string[] args)
		{
			var a = new A();

			a.DoHighLevelStuff();
		}
	}
}

namespace HighLevel
{
	using System;
	using System.Linq;
	using LowLevel;

	public class A
	{
		private readonly B b;

		public A() => b = new B();

		public void DoHighLevelStuff()
		{
			b.DoLowLevelStuff();
		}
	}
}

namespace LowLevel
{
	using System;
	using System.Linq;

	public class B
	{
		public void DoLowLevelStuff() { }
	}
}