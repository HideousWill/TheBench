using System.Numerics;

namespace HideousWorks.Fractory.Model.Evaluators
{
    public interface IFractalEvaluator
    {
		// A Fractal Evaluator tells you two things about a complex number with
		// respect to a set of complex numbers: 
		//    1. Is the number a member of the set;
		//    2. If not, how long did it take to determine it is not.
		//
		// Interestingly, it's the non-members that are fun to render. For example, 
		// in the typical rendering of the Mandelbrot set, the members are the black
		// 'interior' regions; the colorful bands are non-members, with the number of
		// iterations it took to determine they are outside the set mapped to colors.
		//
		//---[ What to do in an implementation ]---
		// Evaluate whether the 'subject' is a member of the set by iterating a
		// maximum of 'iterations' times. If at any iteration the absolute value 
		// exceeds 'tolerance', then 'subject' is *not* a member of the set!
		//
		// Returns 0 if 'subject' *is* a set member; else returns the iteration step
		// on which it went out of 'tolerance'.
        int Evaluate( Complex subject, int iterations, double tolerance );
    }
}