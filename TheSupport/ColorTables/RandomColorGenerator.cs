using System;
using System.Drawing;

namespace HideousWorks.CommonWorks.ColorTables
{
	internal class RandomColorGenerator
    {
        //----------------------------------------------------------------------
        int _Seed;
        public int Seed
        {
            get { return _Seed; }
            set
            {
                if( _Seed.Equals( value ) ) return;

                _Seed = value;

                Random = new Random( _Seed );
            }
        }

        //----------------------------------------------------------------------
        Random Random { get; set; }

        //----------------------------------------------------------------------
        public RandomColorGenerator( int seed )
        {
            Random = new Random( seed );
            Seed = seed;
        }

        //----------------------------------------------------------------------
        public Color GetColor()
        {
            return Color.FromArgb( 255, Random.Next( 255 ), Random.Next( 255 ), Random.Next( 255 ) );
        }
    }
}