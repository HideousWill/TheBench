using System.Numerics;

namespace HideousWorks.Fractory.Model.Evaluators
{
	public class TestEvaluator : IFractalEvaluator
	{
		public int Evaluate( Complex subject, int iterations, double tolerance )
		{
			var x = subject.Real      > 0 ?  8 : 16;
			var y = subject.Imaginary > 0 ? 32 : 64;

			var result = x | y;

			return result;
		}

		public override string ToString()
		{
			return "Test Set";
		}
	}
}