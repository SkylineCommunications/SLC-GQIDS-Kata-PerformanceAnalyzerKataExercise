﻿namespace PerformanceAnalyzerKataExercise.Database
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading;

	using PerformanceAnalyzerKataExercise.Database.Models;

	internal class DatabaseController
	{
		internal void Connect()
		{
			Thread.Sleep(3000);
		}

		internal List<Employee> ExecuteQuery(Query query, string filter)
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

		internal void Disconnect()
		{
			Thread.Sleep(1000);
		}

		private List<Employee> GetEmployees()
		{
			Thread.Sleep(10000);

			return MockDatabase.Table;
		}

		private List<Employee> GetEmployeeById(string filter)
		{
			Thread.Sleep(500);

			return MockDatabase.Table.Where(employee => employee.Equals(Query.GetEmployeeById, filter)).ToList();
		}

		private List<Employee> GetEmployeesByName(string filter)
		{
			Thread.Sleep(1500);

			return MockDatabase.Table.Where(employee => employee.Equals(Query.GetEmployeesByName, filter)).ToList();
		}

		private List<Employee> GetEmployeesByRole(string filter)
		{
			Thread.Sleep(2000);

			return MockDatabase.Table.Where(employee => employee.Equals(Query.GetEmployeesByRole, filter)).ToList();
		}

		private List<Employee> GetEmployeesByDepartment(string filter)
		{
			Thread.Sleep(2500);

			return MockDatabase.Table.Where(employee => employee.Equals(Query.GetEmployeesByDepartment, filter)).ToList();
		}

		private List<Employee> GetEmployeesByLocation(string filter)
		{
			Thread.Sleep(3000);

			return MockDatabase.Table.Where(employee => employee.Equals(Query.GetEmployeesByLocation, filter)).ToList();
		}
	}
}