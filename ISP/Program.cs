namespace ISP
{
	using System;
	using System.Linq;

	internal class Program
	{
		private static void Main(string[] args)
		{
			IService service = new Service();

			var client = new Client(service);

			client.DoStuff();
		}
	}

	internal class Client
	{
		private readonly IService service;

		public Client(IService service) => this.service = service;

		public void DoStuff()
		{
			service.DoFunctionality11();
			service.DoFunctionality12();
			service.DoFunctionality23();
			service.DoFunctionality24();
			service.DoFunctionality25();
			service.DoFunctionality36();
			service.DoFunctionality37();
			service.DoFunctionality48();
			service.DoFunctionality59();
		}
	}

	internal class Service : IService
	{
		public void DoFunctionality11()
		{
			throw new NotImplementedException();
		}

		public void DoFunctionality12()
		{
			throw new NotImplementedException();
		}

		public void DoFunctionality23()
		{
			throw new NotImplementedException();
		}

		public void DoFunctionality24()
		{
			throw new NotImplementedException();
		}

		public void DoFunctionality25()
		{
			throw new NotImplementedException();
		}

		public void DoFunctionality36()
		{
			throw new NotImplementedException();
		}

		public void DoFunctionality37()
		{
			throw new NotImplementedException();
		}

		public void DoFunctionality48()
		{
			throw new NotImplementedException();
		}

		public void DoFunctionality59()
		{
			throw new NotImplementedException();
		}
	}

	internal interface IService
	{
		void DoFunctionality11();

		void DoFunctionality12();

		void DoFunctionality23();

		void DoFunctionality24();

		void DoFunctionality25();

		void DoFunctionality36();

		void DoFunctionality37();

		void DoFunctionality48();

		void DoFunctionality59();
	}
}