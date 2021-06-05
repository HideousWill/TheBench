using System.Windows.Forms;
using HideousWorks.Fractory.Model;

namespace HideousWorks.Fractory.View.Panels
{
	public partial class GeneratorControlPanel : UserControl
	{
		public SetGenerator Generator { get; set; }

		public GeneratorControlPanel()
		{
			InitializeComponent();
		}

		void GenerateButton_Click( object sender, System.EventArgs e )
		{
			var info = new GeneratorInfo( EvaluationControl.Evaluator )
			{
				Min              = RangeControl.Min,
				Extent           = RangeControl.Extent,
				Resolution       = SampleRateControl.Resolution,
				ConvergenceLimit = EvaluationControl.Convergence,
				Iterations       = EvaluationControl.Iterations
			};

			Generator.Info = info;
			Generator.Generate();
		}

		void DefaultsButton_Click( object sender, System.EventArgs e )
		{
			var info = new GeneratorInfo( EvaluationControl.Evaluator );


			RangeControl.Min              = info.Min;
			RangeControl.Extent           = info.Extent;
			SampleRateControl.Resolution  = info.Resolution;
			EvaluationControl.Iterations  = info.Iterations;
			EvaluationControl.Convergence = info.ConvergenceLimit;

			Generator.Info = info;
			Generator.Generate();
		}
	}
}
