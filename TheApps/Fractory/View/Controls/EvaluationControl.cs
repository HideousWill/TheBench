using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HideousWorks.Fractory.Model.Evaluators;
using HideousWorks.CommonWorks;

namespace HideousWorks.Fractory.View.Controls
{
    public partial class EvaluationControl : UserControl
    {
        //----------------------------------------------------------------------
        public int Iterations
        {
            get => Convert.ToInt32( IterationUpDown.Value );
	        set => IterationUpDown.Value = value;
        }

        //----------------------------------------------------------------------
        public double Convergence
        {
            get => Convert.ToDouble( ConvergenceUpDown.Value );
	        set => ConvergenceUpDown.Value = Convert.ToDecimal( value );
        }

        //----------------------------------------------------------------------
        public IFractalEvaluator Evaluator => GeneratorComboBox.SelectedItem as IFractalEvaluator;

	    //----------------------------------------------------------------------
        public EvaluationControl()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------
        private void EvaluationControl_Load( object sender, EventArgs e )
        {
            GeneratorComboBox.Items.AddRange( GetEvaluators().ToArray() );

            if( 0 < GeneratorComboBox.Items.Count )
            {
                GeneratorComboBox.SelectedIndex = 0;
            }
        }

        //----------------------------------------------------------------------
	    static List< IFractalEvaluator > GetEvaluators()
	    {
		    var evaluators = Factory.InstantiateTypesImplementing< IFractalEvaluator >();

		    return null == evaluators
			    ? new List< IFractalEvaluator >()
			    : new List< IFractalEvaluator >( evaluators );
	    }
    }
}
