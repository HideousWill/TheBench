using System;
using System.Collections.Generic;
using System.Drawing;

namespace HideousWorks.CommonWorks.ColorTables
{
	public abstract class ScaledColorTableBase : ColorTableBase
	{
		//----------------------------------------------------------------------
		protected ScaledColorTableBase( int numberOfColors ) : base( numberOfColors )
		{ }

		//----------------------------------------------------------------------
		public struct ColorScaleBuilder
		{
			//----------------------------------------------------------------------
			public ColorScaleBuilder( float redLimit, float greenLimit, float blueLimit )
			{
				Red   = redLimit;
				Green = greenLimit;
				Blue  = blueLimit;
			}

			//----------------------------------------------------------------------
			public ColorScaleBuilder( Color brightest )
			{
				Red   = brightest.R / 255.0f;
				Green = brightest.G / 255.0f;
				Blue  = brightest.B / 255.0f;
			}

			//----------------------------------------------------------------------
			public float Red   { get; }
			public float Green { get; }
			public float Blue  { get; }

			//----------------------------------------------------------------------
			public List< Color > Build( int numberOfSteps )
			{
				var colors = new List< Color >();

				var stepR = StepSize( Red,   numberOfSteps );
				var stepG = StepSize( Green, numberOfSteps );
				var stepB = StepSize( Blue,  numberOfSteps );

				for( var i = numberOfSteps; i > 0; i-- )
				{
					colors.Add( Color.FromArgb( 255,
					                            Convert.ToInt32( i * stepR ),
					                            Convert.ToInt32( i * stepG ),
					                            Convert.ToInt32( i * stepB ) ) );
				}

				return colors;
			}

			//----------------------------------------------------------------------
			static float StepSize( float limit, int numberOfSteps )
			{
				return Clamp( limit ) * 255f / numberOfSteps;
			}
		}

		//----------------------------------------------------------------------
		protected void CreateScaledColors( ColorScaleBuilder colorScaleBuilder )
		{
			Colors.Add( SetMemberColor );

			Colors.AddRange( colorScaleBuilder.Build( NumberOfColors - 1 ) );
		}
	}
}