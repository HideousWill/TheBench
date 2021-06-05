using System.Drawing;
using System.Numerics;
using HideousWorks.Fractory.Model.Evaluators;

namespace HideousWorks.Fractory.Model
{
	public class GeneratorInfo
	{
		public Complex           Min              { get; set; }
		public Complex           Extent           { get; set; }
		public Size              Resolution       { get; set; }
		public double            ConvergenceLimit { get; set; }
		public int               Iterations       { get; set; }
		public IFractalEvaluator Evaluator        { get; set; }

		public GeneratorInfo( IFractalEvaluator evaluator )
		{
			Min              = new Complex( -2, -1.5 );
			Extent           = new Complex( 3,  3 );
			Resolution       = new Size( 256, 256 );
			ConvergenceLimit = 2f;
			Iterations       = 200;
			Evaluator        = evaluator;
		}
	}
}
