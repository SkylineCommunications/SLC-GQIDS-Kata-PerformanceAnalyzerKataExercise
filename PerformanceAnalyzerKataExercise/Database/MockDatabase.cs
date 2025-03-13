﻿namespace PerformanceAnalyzerKataExercise.Database
{
	using System.Collections.Generic;

	using PerformanceAnalyzerKataExercise.Database.Models;

	internal static class MockDatabase
	{
		internal static readonly List<Employee> Table = new List<Employee>
						{
							new Employee { Id = "1", Name = "John Doe", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "2", Name = "Jane Smith", Role = "Manager", Department = "HR", Location = "Chicago" },
							new Employee { Id = "3", Name = "Alice Johnson", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "4", Name = "Bob Brown", Role = "Analyst", Department = "Finance", Location = "New York" },
							new Employee { Id = "5", Name = "Charlie Davis", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "6", Name = "Diana Evans", Role = "Manager", Department = "Sales", Location = "San Francisco" },
							new Employee { Id = "7", Name = "Eve Foster", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "8", Name = "Frank Green", Role = "Analyst", Department = "Finance", Location = "Chicago" },
							new Employee { Id = "9", Name = "Grace Harris", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "10", Name = "Hank Irving", Role = "Manager", Department = "HR", Location = "New York" },
							new Employee { Id = "11", Name = "Ivy Johnson", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "12", Name = "Jack King", Role = "Analyst", Department = "Finance", Location = "San Francisco" },
							new Employee { Id = "13", Name = "Karen Lee", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "14", Name = "Leo Martin", Role = "Manager", Department = "Sales", Location = "Chicago" },
							new Employee { Id = "15", Name = "Mona Nelson", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "16", Name = "Nina Owens", Role = "Analyst", Department = "Finance", Location = "New York" },
							new Employee { Id = "17", Name = "Oscar Perez", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "18", Name = "Paul Quinn", Role = "Manager", Department = "HR", Location = "San Francisco" },
							new Employee { Id = "19", Name = "Quincy Roberts", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "20", Name = "Rachel Scott", Role = "Analyst", Department = "Finance", Location = "Chicago" },
							new Employee { Id = "21", Name = "Sam Taylor", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "22", Name = "Tina Underwood", Role = "Manager", Department = "Sales", Location = "New York" },
							new Employee { Id = "23", Name = "Uma Vance", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "24", Name = "Victor White", Role = "Analyst", Department = "Finance", Location = "San Francisco" },
							new Employee { Id = "25", Name = "Wendy Xander", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "26", Name = "Xander Young", Role = "Manager", Department = "HR", Location = "Chicago" },
							new Employee { Id = "27", Name = "Yara Zane", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "28", Name = "Zack Allen", Role = "Analyst", Department = "Finance", Location = "New York" },
							new Employee { Id = "29", Name = "Amy Baker", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "30", Name = "Brian Clark", Role = "Manager", Department = "Sales", Location = "San Francisco" },
							new Employee { Id = "31", Name = "Cathy Davis", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "32", Name = "David Evans", Role = "Analyst", Department = "Finance", Location = "Chicago" },
							new Employee { Id = "33", Name = "Eva Foster", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "34", Name = "George Hill", Role = "Manager", Department = "HR", Location = "New York" },
							new Employee { Id = "35", Name = "Helen Ingram", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "36", Name = "Ian Jackson", Role = "Analyst", Department = "Finance", Location = "San Francisco" },
							new Employee { Id = "37", Name = "Jill Kelly", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "38", Name = "Kevin Lewis", Role = "Manager", Department = "Sales", Location = "Chicago" },
							new Employee { Id = "39", Name = "Laura Martinez", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "40", Name = "Mike Nelson", Role = "Analyst", Department = "Finance", Location = "New York" },
							new Employee { Id = "41", Name = "Nina Owens", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "42", Name = "Oscar Perez", Role = "Manager", Department = "HR", Location = "San Francisco" },
							new Employee { Id = "43", Name = "Paul Quinn", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "44", Name = "Quincy Roberts", Role = "Analyst", Department = "Finance", Location = "Chicago" },
							new Employee { Id = "45", Name = "Rachel Scott", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "46", Name = "Sam Taylor", Role = "Manager", Department = "Sales", Location = "New York" },
							new Employee { Id = "47", Name = "Tina Underwood", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "48", Name = "Uma Vance", Role = "Analyst", Department = "Finance", Location = "San Francisco" },
							new Employee { Id = "49", Name = "Victor White", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "50", Name = "Wendy Xander", Role = "Manager", Department = "HR", Location = "Chicago" },
							new Employee { Id = "51", Name = "Xander Young", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "52", Name = "Yara Zane", Role = "Analyst", Department = "Finance", Location = "New York" },
							new Employee { Id = "53", Name = "Zack Allen", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "54", Name = "Amy Baker", Role = "Manager", Department = "Sales", Location = "San Francisco" },
							new Employee { Id = "55", Name = "Brian Clark", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "56", Name = "Cathy Davis", Role = "Analyst", Department = "Finance", Location = "Chicago" },
							new Employee { Id = "57", Name = "David Evans", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "58", Name = "Eva Foster", Role = "Manager", Department = "HR", Location = "New York" },
							new Employee { Id = "59", Name = "Frank Green", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "60", Name = "Grace Harris", Role = "Analyst", Department = "Finance", Location = "San Francisco" },
							new Employee { Id = "61", Name = "Hank Irving", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "62", Name = "Ivy Johnson", Role = "Manager", Department = "Sales", Location = "Chicago" },
							new Employee { Id = "63", Name = "Jack King", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "64", Name = "Karen Lee", Role = "Analyst", Department = "Finance", Location = "New York" },
							new Employee { Id = "65", Name = "Leo Martin", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "66", Name = "Mona Nelson", Role = "Manager", Department = "HR", Location = "San Francisco" },
							new Employee { Id = "67", Name = "Nina Owens", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "68", Name = "Oscar Perez", Role = "Analyst", Department = "Finance", Location = "Chicago" },
							new Employee { Id = "69", Name = "Paul Quinn", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "70", Name = "Quincy Roberts", Role = "Manager", Department = "Sales", Location = "New York" },
							new Employee { Id = "71", Name = "Rachel Scott", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "72", Name = "Sam Taylor", Role = "Analyst", Department = "Finance", Location = "San Francisco" },
							new Employee { Id = "73", Name = "Tina Underwood", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "74", Name = "Uma Vance", Role = "Manager", Department = "HR", Location = "Chicago" },
							new Employee { Id = "75", Name = "Victor White", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "76", Name = "Wendy Xander", Role = "Analyst", Department = "Finance", Location = "New York" },
							new Employee { Id = "77", Name = "Xander Young", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "78", Name = "Yara Zane", Role = "Manager", Department = "Sales", Location = "San Francisco" },
							new Employee { Id = "79", Name = "Zack Allen", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "80", Name = "Amy Baker", Role = "Analyst", Department = "Finance", Location = "Chicago" },
							new Employee { Id = "81", Name = "Brian Clark", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "82", Name = "Cathy Davis", Role = "Manager", Department = "HR", Location = "New York" },
							new Employee { Id = "83", Name = "David Evans", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "84", Name = "Eva Foster", Role = "Analyst", Department = "Finance", Location = "San Francisco" },
							new Employee { Id = "85", Name = "Frank Green", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "86", Name = "Grace Harris", Role = "Manager", Department = "Sales", Location = "Chicago" },
							new Employee { Id = "87", Name = "Hank Irving", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "88", Name = "Ivy Johnson", Role = "Analyst", Department = "Finance", Location = "New York" },
							new Employee { Id = "89", Name = "Jack King", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "90", Name = "Karen Lee", Role = "Manager", Department = "HR", Location = "San Francisco" },
							new Employee { Id = "91", Name = "Leo Martin", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "92", Name = "Mona Nelson", Role = "Analyst", Department = "Finance", Location = "Chicago" },
							new Employee { Id = "93", Name = "Nina Owens", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "94", Name = "Oscar Perez", Role = "Manager", Department = "Sales", Location = "New York" },
							new Employee { Id = "95", Name = "Paul Quinn", Role = "Developer", Department = "IT", Location = "Chicago" },
							new Employee { Id = "96", Name = "Quincy Roberts", Role = "Analyst", Department = "Finance", Location = "San Francisco" },
							new Employee { Id = "97", Name = "Rachel Scott", Role = "Developer", Department = "IT", Location = "New York" },
							new Employee { Id = "98", Name = "Sam Taylor", Role = "Manager", Department = "HR", Location = "Chicago" },
							new Employee { Id = "99", Name = "Tina Underwood", Role = "Developer", Department = "IT", Location = "San Francisco" },
							new Employee { Id = "100", Name = "Uma Vance", Role = "Analyst", Department = "Finance", Location = "New York" },
						};
	}
}