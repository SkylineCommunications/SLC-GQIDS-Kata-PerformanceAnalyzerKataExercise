namespace PerformanceAnalyzerKataExercise.Database
{
	using System.Collections.Generic;

	using PerformanceAnalyzerKataExercise.Database.Models;

	internal class DatabaseController
	{
		internal List<Employee> GetAllEmployees()
		{
			Connect();
			var allEmployees = Fetch();
			var processedEmployees = Process(allEmployees);
			Store(processedEmployees);
			Disconnect();

			return allEmployees;
		}

		private void Connect()
		{
			Authenticate();
			Authorize();

			MockExecution.Connect();
		}

		private void Authenticate()
		{
			MockExecution.Authenticate();
		}

		private void Authorize()
		{
			MockExecution.Authorize();
		}

		private List<Employee> Fetch()
		{
			string query = CreateQuery();

			var allEmployees = MockExecution.Fetch(query);

			return allEmployees;
		}

		private string CreateQuery()
		{
			string query = MockExecution.CreateQuery();

			return query;
		}

		private List<Employee> Process(List<Employee> employees)
		{
			var processedEmployees = new List<Employee>();

			foreach (var employee in employees)
			{
				var processedEmployee = MockExecution.Process(employee);

				processedEmployees.Add(processedEmployee);
			}

			return processedEmployees;
		}

		private void Store(List<Employee> employees)
		{
			MockExecution.Store(employees);
		}

		private void Disconnect()
		{
			MockExecution.Disconnect();
		}
	}
}