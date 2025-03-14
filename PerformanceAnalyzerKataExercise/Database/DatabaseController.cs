namespace PerformanceAnalyzerKataExercise.Database
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using PerformanceAnalyzerKataExercise.Database.Models;

	using Skyline.DataMiner.Utils.PerformanceAnalyzer;
	using Skyline.DataMiner.Utils.PerformanceAnalyzer.Loggers;

	internal class DatabaseController
	{
		private static int instanceCount = 0;
		private static PerformanceCollector performanceCollector;
		private static PerformanceTracker performanceTracker;

		internal DatabaseController()
		{
			var performanceLogger = new PerformanceFileLogger("Kata", "Kata Exercise");
			performanceCollector = new PerformanceCollector(performanceLogger);

			performanceTracker = new PerformanceTracker(performanceCollector, nameof(DatabaseController), nameof(DatabaseController));
			instanceCount++;
		}

		internal void Connect()
		{
			using (new PerformanceTracker(performanceCollector))
			{
				MockExecution.Connect();
			}
		}

		internal List<Employee> ExecuteQuery(Query query, string filter)
		{
			using (new PerformanceTracker(performanceCollector))
			{
				if (String.IsNullOrWhiteSpace(filter))
				{
					return GetEmployees();
				}

				switch (query)
				{
					case Query.GetEmployees:
						return GetEmployees();

					case Query.GetEmployeeById:
						return GetEmployeeById(filter);

					case Query.GetEmployeesByName:
						return GetEmployeesByName(filter);

					case Query.GetEmployeesByRole:
						return GetEmployeesByRole(filter);

					case Query.GetEmployeesByDepartment:
						return GetEmployeesByDepartment(filter);

					case Query.GetEmployeesByLocation:
						return GetEmployeesByLocation(filter);

					default:
						return new List<Employee>();
				}
			}
		}

		internal void Disconnect()
		{
			using (new PerformanceTracker(performanceCollector))
			{
				MockExecution.Disconnect();
			}

			if (--instanceCount == 0)
			{
				performanceTracker.Dispose();
				performanceCollector = null;
				performanceTracker = null;
			}
		}

		private List<Employee> GetEmployees()
		{
			Authorize();

			using (new PerformanceTracker(performanceCollector, nameof(MockExecution), nameof(MockExecution.GetEmployees)))
			{
				MockExecution.GetEmployees();
			}

			return MockDatabase.Table;
		}

		private List<Employee> GetEmployeeById(string filter)
		{
			Authorize();

			using (new PerformanceTracker(performanceCollector, nameof(MockExecution), nameof(MockExecution.GetEmployeeById)))
			{
				MockExecution.GetEmployeeById();
			}

			return MockDatabase.Table.Where(employee => employee.Equals(Query.GetEmployeeById, filter)).ToList();
		}

		private List<Employee> GetEmployeesByName(string filter)
		{
			Authorize();

			using (new PerformanceTracker(performanceCollector, nameof(MockExecution), nameof(MockExecution.GetEmployeesByName)))
			{
				MockExecution.GetEmployeesByName();
			}

			return MockDatabase.Table.Where(employee => employee.Equals(Query.GetEmployeesByName, filter)).ToList();
		}

		private List<Employee> GetEmployeesByRole(string filter)
		{
			Authorize();

			using (new PerformanceTracker(performanceCollector, nameof(MockExecution), nameof(MockExecution.GetEmployeesByRole)))
			{
				MockExecution.GetEmployeesByRole();
			}

			return MockDatabase.Table.Where(employee => employee.Equals(Query.GetEmployeesByRole, filter)).ToList();
		}

		private List<Employee> GetEmployeesByDepartment(string filter)
		{
			Authorize();

			using (new PerformanceTracker(performanceCollector, nameof(MockExecution), nameof(MockExecution.GetEmployeesByDepartment)))
			{
				MockExecution.GetEmployeesByDepartment();
			}

			return MockDatabase.Table.Where(employee => employee.Equals(Query.GetEmployeesByDepartment, filter)).ToList();
		}

		private List<Employee> GetEmployeesByLocation(string filter)
		{
			Authorize();

			using (new PerformanceTracker(performanceCollector, nameof(MockExecution), nameof(MockExecution.GetEmployeesByLocation)))
			{
				MockExecution.GetEmployeesByLocation();
			}

			return MockDatabase.Table.Where(employee => employee.Equals(Query.GetEmployeesByLocation, filter)).ToList();
		}

		private void Authorize()
		{
			using (new PerformanceTracker(performanceCollector))
			{
				MockExecution.Authorize();
			}
		}
	}
}