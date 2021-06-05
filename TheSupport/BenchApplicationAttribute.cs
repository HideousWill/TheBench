using System;

namespace HideousWorks.CommonWorks
{
	[AttributeUsage( AttributeTargets.Class )]
	public class BenchApplicationAttribute : Attribute
	{
		public string Label { get; }

		public BenchApplicationAttribute( string label = "" )
		{
			Label = label;
		}
	}
}
