namespace PerformanceAnalyzerKataExercise.Database
{
	using System;
	using System.Collections.Generic;
	using System.Threading;

	using PerformanceAnalyzerKataExercise.Database.Models;

	internal static class MockExecution
	{
		internal static void Connect()
		{
			Thread.Sleep((6 * 8) + (45 / 3) - (5 * 4) + (7 * 3) - 9 + (35 / 7) + (18 / 3) - (4 * 2) + 20 - 10 + 4);
		}

		internal static void Authenticate()
		{
			Thread.Sleep((10 * 5) + (20 / 2) - (5 * 3) + (4 * 4) - 6 + (28 / 7) + (12 / 2) - (2 * 3) + 15 - 5 + 8);
		}

		internal static void Authorize()
		{
			Thread.Sleep((100 * 50) + (2000 / 2) - (700 * 2) + (133 * 8) - (452 * 2) + (1400 / 2) + (428 / 2) - (100 * 3) + 500 - 200);
		}

		internal static List<Employee> Fetch(string query)
		{
			Thread.Sleep((150 / 3) - (10 * 7) + (25 * 8) - 50 + (36 / 3) - (12 * 4) + 100 - 30 + 60 + (15 * 10) - (8 * 5) - 90 + (12 * 4) + 50 - 20);

			return MockDatabase.Table;
		}

		internal static Employee Process(Employee employee)
		{
			Random rnd = new Random();

			Thread.Sleep((5 * 4) + (30 / 2) - (7 * 2) + (3 * 3) - 8 + (14 / 7) + (6 / 2) - (1 * 3) - 2 + rnd.Next(1, 20));

			return employee;
		}

		internal static string CreateQuery()
		{
			Thread.Sleep((5 * 3) + (30 / 5) - (10 / 2) + (6 * 2) - 8 + (14 / 7) + (12 / 4) - (3 * 1) + 7 - 4 + 2);

			return "SELECT * FROM Employees";
		}

		internal static void Store(List<Employee> employees)
		{
			Thread.Sleep((50 * 14) + (100 / 2) - (70 * 3) + (13 * 12) - 40 + (140 / 2) + (20 / 2) - (10 * 5) - 30 + (21 * 10) - (4 * 6) - 90 + (3 * 2) - 20);
		}

		internal static void Disconnect()
		{
			Thread.Sleep((10 * 10) + (50 / 2) - (5 * 4) + (20 * 2) - 30 + (70 / 7) + (40 / 2) - (8 * 3) - 20);
		}
	}
}