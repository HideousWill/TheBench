﻿namespace HideousWorks.CommonWorks.ColorTables
{
    public class RandomColorTable : ColorTableBase, IRandomSeeded
    {
        //----------------------------------------------------------------------
        public int Seed
        {
            get => ColorGenerator.Seed;
	        set
            {
                if( Seed.Equals( value ) ) return;

                ColorGenerator.Seed = value;

                CreateRandomColors();
            }
        }

        //----------------------------------------------------------------------
        RandomColorGenerator ColorGenerator { get; set; }

        //----------------------------------------------------------------------
        public RandomColorTable( int numberOfColors ): base( numberOfColors )
        {
            ColorGenerator = new RandomColorGenerator( 0 );
            Seed = 0;
            CreateRandomColors();
        }

        //----------------------------------------------------------------------
        public override string ToString()
        {
            return "Random";
        }

        //----------------------------------------------------------------------
        void CreateRandomColors()
        {
            Colors.Clear();

            Colors.Add( SetMemberColor );

            for( var i = 1; i < NumberOfColors; i++ )
            {
                Colors.Add( ColorGenerator.GetColor() );
            }
        }
    }
}