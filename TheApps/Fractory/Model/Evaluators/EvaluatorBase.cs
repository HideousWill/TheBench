using System.Numerics;

namespace HideousWorks.Fractory.Model.Evaluators
{
    public abstract class EvaluatorBase : IFractalEvaluator
    {
        //----------------------------------------------------------------------
        public abstract int Evaluate( Complex subject, int iterations, double tolerance );
    }
}