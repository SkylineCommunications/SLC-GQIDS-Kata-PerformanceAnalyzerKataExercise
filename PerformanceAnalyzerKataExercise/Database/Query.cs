namespace PerformanceAnalyzerKataExercise.Database
{
	using System.ComponentModel;

	internal enum Query
	{
		[Description("Get Employees")]
		GetEmployees,

		[Description("Get Employees by Id")]
		GetEmployeeById,

		[Description("Get Employees by Name")]
		GetEmployeesByName,

		[Description("Get Employees by Role")]
		GetEmployeesByRole,

		[Description("Get Employees by Department")]
		GetEmployeesByDepartment,

		[Description("Get Employees by Location")]
		GetEmployeesByLocation,
	}
}