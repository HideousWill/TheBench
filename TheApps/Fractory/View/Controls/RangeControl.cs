using System;
using System.Numerics;
using System.Windows.Forms;

namespace HideousWorks.Fractory.View.Controls
{
	public partial class RangeControl : UserControl
	{
		public Complex Min
		{
			get => MinValueControl.Value;
			set => MinValueControl.Value = value;
		}

		public Complex Extent
		{
			get => ExtentValueControl.Value;
			set => ExtentValueControl.Value = value;
		}

		public Complex Max    => MaxValueControl.Value;

		public RangeControl()
		{
			InitializeComponent();

			MinValueControl.ValueChanged    += HandleValueChanged;
			ExtentValueControl.ValueChanged += HandleValueChanged;
		}

		void HandleValueChanged( object sender, EventArgs e )
		{
			MaxValueControl.Value = MinValueControl.Value + ExtentValueControl.Value;
		}

		void ExtentValueControl_Load( object sender, System.EventArgs e )
		{
			MinValueControl.Min = new Complex( -10, -10 );
			MaxValueControl.Min = new Complex( -10, -10 );
		}
	}
}
