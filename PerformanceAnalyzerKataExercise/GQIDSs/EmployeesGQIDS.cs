namespace PerformanceAnalyzerKataExercise.GQIDSs
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using PerformanceAnalyzerKataExercise.Database;
	using PerformanceAnalyzerKataExercise.Database.Models;

	using Skyline.DataMiner.Analytics.GenericInterface;

	[GQIMetaData(Name = "Employees Table")]
	public sealed class EmployeesGQIDS : IGQIDataSource, IGQIOnPrepareFetch
	{
		private DatabaseController databaseController;
		private GQIColumn[] gqiColumns;

		public GQIColumn[] GetColumns()
		{
			return CreateGQIColumns();
		}

		public GQIPage GetNextPage(GetNextPageInputArgs args)
		{
			var gqiRows = databaseController
				.GetAllEmployees()
				.Select(employee => CreateGQIRow(employee))
				.ToArray();

			return new GQIPage(gqiRows);
		}

		public OnPrepareFetchOutputArgs OnPrepareFetch(OnPrepareFetchInputArgs args)
		{
			databaseController = new DatabaseController();

			return new OnPrepareFetchOutputArgs();
		}

		private GQIColumn[] CreateGQIColumns()
		{
			gqiColumns = new GQIColumn[]
			{
				new GQIStringColumn("Id"),
				new GQIStringColumn("Name"),
				new GQIStringColumn("Role"),
				new GQIStringColumn("Department"),
				new GQIStringColumn("Location"),
			};

			return gqiColumns;
		}

		private GQIRow CreateGQIRow(Employee employee)
		{
			var cells = new List<GQICell>();

			foreach (var column in gqiColumns)
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