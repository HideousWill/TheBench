using System;
using System.Windows.Forms;
using HideousWorks.CommonWorks;

namespace HideousWorks.TheBench
{
	[BenchApplication( "Bench Test" )]
	public partial class SampleApp : UserControl
	{
		public SampleApp()
		{
			InitializeComponent();
		}

		void SampleApp_MouseClick( object sender, MouseEventArgs e )
		{
			Console.WriteLine( $"Mouse click: [{e.X},{e.Y}]" );
		}
	}
}
