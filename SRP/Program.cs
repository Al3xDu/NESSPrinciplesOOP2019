namespace SRP
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	internal class Program
	{
		private static void Main(string[] args)
		{
			var avg = CalculateAgeAverageFiveUsers();
		}

		private static double CalculateAgeAverageFiveUsers()
		{
			var users = new List<User>
			{
				new User {Name = "A", Age = 1},
				new User {Name = "B", Age = 2},
				new User {Name = "C", Age = 3},
				new User {Name = "D", Age = 4},
				new User {Name = "E", Age = 5}
			};

			var ages = new List<int>();

			foreach (var user in users) ages.Add(user.Age);

			var sum = 0;

			foreach (var age in ages) sum += age;

			return sum / 5.0;
		}
	}

	internal class User
	{
		public string Name { get; set; }

		public int Age { get; set; }
	}
}