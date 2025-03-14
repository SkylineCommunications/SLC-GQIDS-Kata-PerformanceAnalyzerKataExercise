namespace PerformanceAnalyzerKataExercise.Database
{
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Reflection;

	internal static class Helpers
	{
		internal static string[] GetQueryDescriptions()
		{
			var type = typeof(Query);
			var descriptions = new List<string>();

			foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static))
			{
				var descriptionAttribute = field.GetCustomAttribute<DescriptionAttribute>();
				if (descriptionAttribute != null)
				{
					descriptions.Add(descriptionAttribute.Description);
				}
				else
				{
					descriptions.Add(field.Name);
				}
			}

			return descriptions.ToArray();
		}

		internal static Query GetEnumValueFromDescription(string description)
		{
			var type = typeof(Query);
			foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static))
			{
				var descriptionAttribute = field.GetCustomAttribute<DescriptionAttribute>();
				if (descriptionAttribute != null && descriptionAttribute.Description == description)
				{
					return (Query)field.GetValue(null);
				}
			}

			return Query.GetEmployees;
		}
	}
}