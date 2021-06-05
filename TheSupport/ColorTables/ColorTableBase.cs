using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HideousWorks.CommonWorks.ColorTables
{
	public abstract class ColorTableBase
	{
		//----------------------------------------------------------------------
		Timer _CycleTimer;
		public Timer CycleTimer
		{
			get => _CycleTimer;
			set
			{
				if( null != _CycleTimer )
				{
					_CycleTimer.Tick -= HandleTick;
				}

				_CycleTimer = value;
				if( null != _CycleTimer )
				{
					_CycleTimer.Tick += HandleTick;
				}
			}
		}

		//----------------------------------------------------------------------
		void HandleTick( object sender, EventArgs e )
		{
			++IndexOffset;
			IndexOffset = IndexOffset % NumberOfColors;
		}

		int IndexOffset { get; set; }

		//----------------------------------------------------------------------
		public Color this[ int index ] => Colors[ (index + IndexOffset) % NumberOfColors ];

		//----------------------------------------------------------------------
		public int NumberOfColors { get; set; }

		//----------------------------------------------------------------------
		public List< Color > Colors { get; private set; }

		//----------------------------------------------------------------------
		protected ColorTableBase( int numberOfColors )
		{
			Colors         = new List< Color >( numberOfColors );
			NumberOfColors = numberOfColors;

			CycleTimer = new Timer {Interval = 200};
			//            CycleTimer.Enabled = true;
		}

		//----------------------------------------------------------------------
		protected static Color SetMemberColor { get { return Color.Black; } }

		//----------------------------------------------------------------------
		protected static float Clamp( float x )
		{
			return x > 1.0f ? 1.0f : (x < 0f ? 0 : x);
		}
	}
}
