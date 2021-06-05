using System.Numerics;

namespace HideousWorks.Fractory.Model.Evaluators
{
    public class MandelbrotEvaluator : EvaluatorBase
    {
        //----------------------------------------------------------------------
        public override int Evaluate( Complex subject, int iterations, double tolerance )
        {
            var current = new Complex();

            for( var i = 0; i < iterations; i++ )
            {
                current = current * current + subject;

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
            return "Mandelbrot Set";
        }
    }
}
