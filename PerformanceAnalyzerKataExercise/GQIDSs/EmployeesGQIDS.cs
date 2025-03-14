namespace PerformanceAnalyzerKataExercise.GQIDSs
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using PerformanceAnalyzerKataExercise.Database;
	using PerformanceAnalyzerKataExercise.Database.Models;
	using PerformanceAnalyzerKataExercise.GQIDSs.Arguments;

	using Skyline.DataMiner.Analytics.GenericInterface;

	[GQIMetaData(Name = "Employees Table")]
	public sealed class EmployeesGQIDS : IGQIDataSource, IGQIOnPrepareFetch, IGQIOnDestroy, IGQIInputArguments
	{
		private readonly InputArguments inputArguments = new InputArguments();

		private DatabaseController databaseController;
		private List<Employee> allEmployees;

		public GQIArgument[] GetInputArguments()
		{
			return inputArguments.GetArguments();
		}

		public OnArgumentsProcessedOutputArgs OnArgumentsProcessed(OnArgumentsProcessedInputArgs args)
		{
			return inputArguments.ProcessArguments(args);
		}

		public GQIColumn[] GetColumns()
		{
			return inputArguments.GQIColumns;
		}

		public GQIPage GetNextPage(GetNextPageInputArgs args)
		{
			var newRows = allEmployees
				.Where(employee => employee.Equals(inputArguments.Query, inputArguments.Filter))
				.Select(employee => CreateGQIRow(employee))
				.ToArray();

			return new GQIPage(newRows);
		}

		public OnPrepareFetchOutputArgs OnPrepareFetch(OnPrepareFetchInputArgs args)
		{
			databaseController = new DatabaseController();
			databaseController.Connect();

			allEmployees = databaseController
				.ExecuteQuery(Query.GetEmployees, String.Empty);

			return new OnPrepareFetchOutputArgs();
		}

		public OnDestroyOutputArgs OnDestroy(OnDestroyInputArgs args)
		{
			databaseController?.Disconnect();

			return new OnDestroyOutputArgs();
		}

		private GQIRow CreateGQIRow(Employee employee)
		{
			var cells = new List<GQICell>();

			foreach (var column in inputArguments.GQIColumns)
			{
				switch (column.Name)
				{
					case "Id":
						cells.Add(new GQICell() { Value = employee.Id });
						break;

					case "Name":
						cells.Add(new GQICell() { Value = employee.Name });
						break;

					case "Role":
						cells.Add(new GQICell() { Value = employee.Role });
						break;

					case "Department":
						cells.Add(new GQICell() { Value = employee.Department });
						break;

					case "Location":
						cells.Add(new GQICell() { Value = employee.Location });
						break;

					default:
						throw new InvalidOperationException($"Unknown column name: {column.Name}");
				}
			}

			return new GQIRow(employee.Id, cells.ToArray());
		}
	}
}