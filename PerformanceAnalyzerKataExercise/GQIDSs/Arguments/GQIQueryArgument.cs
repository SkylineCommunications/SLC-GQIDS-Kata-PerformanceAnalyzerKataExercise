namespace PerformanceAnalyzerKataExercise.GQIDSs.Arguments
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Reflection;

	using PerformanceAnalyzerKataExercise.Database;

	using Skyline.DataMiner.Analytics.GenericInterface;

	internal class GQIQueryArgument : GQIStringDropdownArgument
	{
		public GQIQueryArgument(string name) : base(name, Helpers.GetQueryDescriptions())
		{
		}
	}
}