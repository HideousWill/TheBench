using System;
using System.Drawing;
using System.Windows.Forms;

namespace HideousWorks.Fractory.View.Controls
{
	public partial class SampleRateControl : UserControl
	{
		//----------------------------------------------------------------------
		public Size Resolution
		{
			get => new Size( Convert.ToInt32( RealUpDown.Value ), Convert.ToInt32( ImaginaryUpDown.Value ) );
			set
			{
				RealUpDown.Value      = value.Width;
				ImaginaryUpDown.Value = value.Height;
			}
		}

		//----------------------------------------------------------------------
		public SampleRateControl()
		{
			InitializeComponent();

			ComputeAspectRatio();
		}

		//----------------------------------------------------------------------
		void ComputeAspectRatio()
		{
			AspectRatio = Convert.ToSingle( RealUpDown.Value ) /
			              Convert.ToSingle( ImaginaryUpDown.Value );
		}

		//----------------------------------------------------------------------
		float AspectRatio { get; set; }

		//----------------------------------------------------------------------
		void RealUpDown_ValueChanged( object sender, EventArgs e )
		{
			if( ! LockAspectRatioCheckBox.Checked ) return;

			var r = Convert.ToSingle( RealUpDown.Value );
			var i = r / AspectRatio;

			ImaginaryUpDown.Value = Convert.ToDecimal( i );
		}

		//----------------------------------------------------------------------
		void ImaginaryUpDown_ValueChanged( object sender, EventArgs e )
		{
			if( ! LockAspectRatioCheckBox.Checked ) return;

			var i = Convert.ToSingle( ImaginaryUpDown.Value );
			var r = i * AspectRatio;

			RealUpDown.Value = Convert.ToDecimal( r );
		}

		//----------------------------------------------------------------------
		void LockAspectRatioCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if( LockAspectRatioCheckBox.Checked )
			{
				ComputeAspectRatio();
			}
		}
	}
}
