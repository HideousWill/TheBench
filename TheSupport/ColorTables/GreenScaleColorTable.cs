﻿namespace HideousWorks.CommonWorks.ColorTables
{
    public class GreenScaleColorTable : ScaledColorTableBase
    {
        //----------------------------------------------------------------------
        public GreenScaleColorTable( int numberOfColors ) : base( numberOfColors )
        {
            CreateScaledColors( new ColorScaleBuilder( 0f, 1.0f, 0f ) );
        }

        //----------------------------------------------------------------------
        public override string ToString()
        {
            return "Green-scale";
        }
    }
}