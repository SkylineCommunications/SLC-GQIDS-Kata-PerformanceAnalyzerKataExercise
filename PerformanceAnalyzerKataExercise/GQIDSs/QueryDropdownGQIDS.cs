namespace PerformanceAnalyzerKataExercise.GQIDSs
{
	using System.Linq;

	using PerformanceAnalyzerKataExercise.Database;

	using Skyline.DataMiner.Analytics.GenericInterface;

	[GQIMetaData(Name = "Query Dropdown")]
	public sealed class QueryDropdownGQIDS : IGQIDataSource
	{
		public GQIColumn[] GetColumns()
		{
			return new GQIColumn[] { new GQIStringColumn("Query") };
		}

		public GQIPage GetNextPage(GetNextPageInputArgs args)
		{
			var newRows = Helpers.GetQueryDescriptions().Select(query => CreateGQIRow(query)).ToArray();

			return new GQIPage(newRows);
		}

		private GQIRow CreateGQIRow(string query)
		{
			var cells = new GQICell[]
			{
				new GQICell() { Value = query },
			};

			return new GQIRow(cells);
		}
	}
}