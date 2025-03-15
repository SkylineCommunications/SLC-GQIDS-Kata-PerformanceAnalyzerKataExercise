namespace PerformanceAnalyzerKataExercise.Database
{
	using System.Collections.Generic;

	using PerformanceAnalyzerKataExercise.Database.Models;

	using Skyline.DataMiner.Utils.PerformanceAnalyzer;
	using Skyline.DataMiner.Utils.PerformanceAnalyzer.Loggers;

	internal class DatabaseController
	{
		private readonly PerformanceCollector collector;

		internal DatabaseController()
		{
			var logger = new PerformanceFileLogger("Kata", "Exercise 1");

			collector = new PerformanceCollector(logger);
		}

		internal List<Employee> GetAllEmployees()
		{
			using (new PerformanceTracker(collector))
			{
				Connect();
				var allEmployees = Fetch();
				var processedEmployees = Process(allEmployees);
				Store(processedEmployees);
				Disconnect();

				return allEmployees;
			}
		}

		private void Connect()
		{
			using (new PerformanceTracker(collector))
			{
				Authenticate();
				Authorize();

				MockExecution.Connect();
			}
		}

		private void Authenticate()
		{
			using (new PerformanceTracker(collector))
			{
				MockExecution.Authenticate();
			}
		}

		private void Authorize()
		{
			using (new PerformanceTracker(collector))
			{
				MockExecution.Authorize();
			}
		}

		private List<Employee> Fetch()
		{
			using (new PerformanceTracker(collector))
			{
				string query = CreateQuery();

				var allEmployees = MockExecution.Fetch(query);

				return allEmployees;
			}
		}

		private string CreateQuery()
		{
			using (new PerformanceTracker(collector))
			{
				string query = MockExecution.CreateQuery();

				return query;
			}
		}

		private List<Employee> Process(List<Employee> employees)
		{
			using (new PerformanceTracker(collector))
			{
				var processedEmployees = new List<Employee>();

				foreach (var employee in employees)
				{
					using (new PerformanceTracker(collector, nameof(MockExecution), nameof(MockExecution.Process)))
					{
						var processedEmployee = MockExecution.Process(employee);

						processedEmployees.Add(processedEmployee);
					}
				}

				return processedEmployees;
			}
		}

		private void Store(List<Employee> employees)
		{
			using (new PerformanceTracker(collector))
			{
				MockExecution.Store(employees);
			}
		}

		private void Disconnect()
		{
			using (new PerformanceTracker(collector))
			{
				MockExecution.Disconnect();
			}
		}
	}
}