using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HideousWorks.CommonWorks
{
	public class Factory
	{
		//----------------------------------------------------------------------
		public static IEnumerable< T > InstantiateTypesImplementing< T >() where T : class
		{
			if( null == Assembly.GetEntryAssembly() ) yield break;

			var targetType = typeof( T );

			foreach( var assembly in AppDomain.CurrentDomain.GetAssemblies() )
				foreach( var type in assembly.GetTypes() )
				{
					if( type.IsInterface ) continue;
					if( type.IsAbstract ) continue;

					if( type.GetInterfaces().Any( interfaceType => interfaceType == targetType ) )
					{
						yield return Activator.CreateInstance( type ) as T;
					}
				}
		}

		//----------------------------------------------------------------------
		public static IEnumerable< T > InstantiateTypesImplementing< T, TArg >( TArg arg ) where T : class
		{
			if( null == Assembly.GetEntryAssembly() ) yield break;

			var targetType = typeof( T );

			foreach( var assembly in AppDomain.CurrentDomain.GetAssemblies() )
			{
				foreach( var type in assembly.GetTypes() )
				{
					if( type.IsInterface ) continue;
					if( type.IsAbstract ) continue;

					if( ! type.IsSubclassOf( targetType ) ) continue;

					yield return (T) Activator.CreateInstance( type, new object[] {arg} );
				}
			}
		}
	}
}
