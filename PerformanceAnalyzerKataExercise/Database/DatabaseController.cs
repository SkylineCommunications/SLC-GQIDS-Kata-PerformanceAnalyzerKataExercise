namespace PerformanceAnalyzerKataExercise.Database
{
	using System;
	using System.Collections.Generic;
	using System.Threading;
	using System.Threading.Tasks;

	using PerformanceAnalyzerKataExercise.Database.Models;

	using Skyline.DataMiner.Utils.PerformanceAnalyzer;
	using Skyline.DataMiner.Utils.PerformanceAnalyzer.Loggers;

	internal class DatabaseController
	{
		private readonly PerformanceCollector collector;

		internal DatabaseController()
		{
			var logger = new PerformanceFileLogger("Kata", "Exercise 2");

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
			using (var tracker = new PerformanceTracker(collector))
			{
				var processedEmployees = new List<Employee>();

				Parallel.ForEach(employees, employee =>
				{
					using (var threadTracker = new PerformanceTracker(tracker))
					{
						threadTracker
							.AddMetadata("Thread Id", Convert.ToString(Thread.CurrentThread.ManagedThreadId))
							.AddMetadata("Employee Id", employee.Id)
							.AddMetadata("Employee Name", employee.Name);

						var processedEmployee = MockExecution.Process(employee);

						processedEmployees.Add(processedEmployee);
					}
				});

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