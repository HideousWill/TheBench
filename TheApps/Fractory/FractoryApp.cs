using System;
using System.Windows.Forms;
using HideousWorks.CommonWorks;
using HideousWorks.Fractory.Model;

namespace HideousWorks.Fractory
{
	[BenchApplication( "The Fractory" )]
	public partial class FractoryApp : UserControl
	{
		SetGenerator Generator { get; } = new SetGenerator();

		public FractoryApp()
		{
			InitializeComponent();
		}

		void FractoryApp_Load( object sender, System.EventArgs e )
		{
			Console.WriteLine( "Loaded the Fratory!" );

			GeneratorControlPanel.Generator = Generator;
			VisualizerPanel.SetData         = Generator;
		}
	}
}
