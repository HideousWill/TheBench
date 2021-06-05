using System.Numerics;

namespace HideousWorks.Fractory.Model.Evaluators
{
    public class SpottyEvaluator : EvaluatorBase
    {
        //----------------------------------------------------------------------
        public override int Evaluate( Complex subject, int iterations, double tolerance )
        {
            var c = new Complex( 0.1, 0.2 );

            var current = new Complex( 1, 2 );

            for( var i = 0; i < iterations; i++ )
            {
                current = (subject * current) + c / Complex.Pow( current, 2 );

	            if( Complex.Abs( current ) > tolerance )
	            {
		            return i;
	            }
            }

            return 0;
        }

        //----------------------------------------------------------------------
        public override string ToString()
        {
            return "Spotty Set";
        }
    }
}