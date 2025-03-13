namespace PerformanceAnalyzerKataExercise.GQIDSs.Arguments
{
	using PerformanceAnalyzerKataExercise.Database;

	using Skyline.DataMiner.Analytics.GenericInterface;

	internal class InputArguments
	{
		private readonly GQIQueryArgument query = new GQIQueryArgument("Query");
		private readonly GQIStringArgument filter = new GQIStringArgument("Filter");

		public Query Query { get; private set; }

		public string Filter { get; private set; }

		public GQIColumn[] GQIColumns { get; private set; }

		internal GQIArgument[] GetArguments()
		{
			return new GQIArgument[] { query, filter };
		}

		internal OnArgumentsProcessedOutputArgs ProcessArguments(OnArgumentsProcessedInputArgs args)
		{
			GQIColumns = new GQIColumn[]
			{
				new GQIStringColumn("Id"),
				new GQIStringColumn("Name"),
				new GQIStringColumn("Role"),
				new GQIStringColumn("Department"),
				new GQIStringColumn("Location"),
			};

			Query = Helpers.GetEnumValueFromDescription(args.GetArgumentValue(query));
			Filter = args.GetArgumentValue(filter);

			return new OnArgumentsProcessedOutputArgs();
		}
	}
}