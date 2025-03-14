namespace PerformanceAnalyzerKataExercise.Database.Models
{
	using System;

	internal class Employee
	{
		internal string Id { get; set; }

		internal string Name { get; set; }

		internal string Role { get; set; }

		internal string Department { get; set; }

		internal string Location { get; set; }

		internal bool Equals(Query query, string filter)
		{
			if (String.IsNullOrWhiteSpace(filter))
			{
				return true;
			}

			switch (query)
			{
				case Query.GetEmployees:
					return true;

				case Query.GetEmployeeById:
					return Id.IndexOf(filter, StringComparison.OrdinalIgnoreCase) != -1;

				case Query.GetEmployeesByName:
					return Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) != -1;

				case Query.GetEmployeesByRole:
					return Role.IndexOf(filter, StringComparison.OrdinalIgnoreCase) != -1;

				case Query.GetEmployeesByDepartment:
					return Department.IndexOf(filter, StringComparison.OrdinalIgnoreCase) != -1;

				case Query.GetEmployeesByLocation:
					return Location.IndexOf(filter, StringComparison.OrdinalIgnoreCase) != -1;

				default:
					return false;
			}
		}
	}
}