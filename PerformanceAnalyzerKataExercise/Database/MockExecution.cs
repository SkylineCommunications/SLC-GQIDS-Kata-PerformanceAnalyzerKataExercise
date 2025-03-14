namespace PerformanceAnalyzerKataExercise.Database
{
	using System.Threading;

	internal static class MockExecution
    {
		internal static void GetEmployees()
		{
			Thread.Sleep(((((((((((((((((((50 + 25) * 2) - 40) + 100) * 2) / 2) + 200) * 3) - 50) + 1500) / 2) * 4) - 300) + 2500) / 2) + 1250) * 2) - 2500) - (5 * (100 + (4 * 100))));
		}

		internal static void GetEmployeeById()
		{
			Thread.Sleep((((((((((((((((((5 + 3) * 2) - 6) + 12) * 2) / 2) + 20) * 3) - 10) + 100) / 2) * 2) - 50) + 250) / 2) + 125) * 2) - 250);
		}

		internal static void GetEmployeesByName()
		{
			Thread.Sleep(((((((((((((((((((10 + 5) * 2) - 15) + 35) * 2) / 2) + 50) * 3) - 25) + 200) / 2) * 4) - 150) + 500) / 2) + 250) * 2) - 500) + 500);
		}

		internal static void GetEmployeesByRole()
		{
			Thread.Sleep(((((((((((((((((((20 + 5) * 2) - 15) + 35) * 2) / 2) + 50) * 3) - 25) + 400) / 2) * 4) - 150) + 1000) / 2) + 500) * 2) - 1000) + 1000);
		}

		internal static void GetEmployeesByDepartment()
		{
			Thread.Sleep(((((((((((((((((((25 + 10) * 2) - 20) + 50) * 2) / 2) + 75) * 3) - 30) + 500) / 2) * 4) - 200) + 1500) / 2) + 750) * 2) - 1500) + 500);
		}

		internal static void GetEmployeesByLocation()
		{
			Thread.Sleep((((((((((((((((((30 + 15) * 2) - 25) + 65) * 2) / 2) + 100) * 3) - 35) + 600) / 2) * 4) - 250) + 2000) / 2) + 1000) * 2) - 2000);
		}
	}
}
