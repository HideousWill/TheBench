using System.Collections.Generic;

namespace HideousWorks.CommonWorks.ColorTables
{
	public class ColorTableList : List< ColorTableBase >
	{
		//----------------------------------------------------------------------
		public ColorTableList()
		{
			BuildColorTables( 256 );
		}

		//----------------------------------------------------------------------
		void BuildColorTables( int numberOfColors )
		{
			AddRange( 
				Factory.InstantiateTypesImplementing< ColorTableBase, int >(
					numberOfColors ) );
		}
	}
}
