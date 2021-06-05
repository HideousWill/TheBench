using System;
using System.ComponentModel;
using System.Numerics;
using System.Windows.Forms;

namespace HideousWorks.Fractory.View.Controls
{
	public partial class ComplexNumberControl : UserControl
	{
		[Category( "Complex" ), Description( "Complex Value changed" )]
		public event EventHandler ValueChanged;
		protected virtual void OnValueChanged()
		{
			ValueChanged?.Invoke( this, EventArgs.Empty );
		}

		[Category( "Complex" ), Description( "Complex Value" )]
		public Complex Value
		{
			get => ToComplex( RealUpDown.Value, ImaginaryUpDown.Value );
			set => (RealUpDown.Value, ImaginaryUpDown.Value) = FromComplex( value );
		}

		[Category( "Complex" ), Description( "Minimum range" )]
		public Complex Min
		{
			get => ToComplex( RealUpDown.Minimum, ImaginaryUpDown.Minimum );
			set => (RealUpDown.Minimum, ImaginaryUpDown.Minimum) = FromComplex( value );
		}


		[Description( "Maximum range" ), Category( "Complex" )]
		public Complex Max
		{
			get => ToComplex( RealUpDown.Maximum, ImaginaryUpDown.Maximum );
			set => (RealUpDown.Maximum, ImaginaryUpDown.Maximum) = FromComplex( value );
		}

		static Complex ToComplex( decimal real, decimal imaginary ) =>
			(new Complex( Convert.ToDouble( real ), Convert.ToDouble( imaginary ) ));

		static (decimal, decimal) FromComplex( Complex complex ) =>
			(Convert.ToDecimal( complex.Real ), Convert.ToDecimal( complex.Imaginary ));

		public ComplexNumberControl()
		{
			InitializeComponent();
		}

		void RealOrImaginary_ValueChanged( object sender, EventArgs e )
		{
			OnValueChanged();
		}
	}
}
