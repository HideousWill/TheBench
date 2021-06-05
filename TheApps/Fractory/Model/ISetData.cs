using System;

namespace HideousWorks.Fractory.Model
{
	public interface ISetData
	{
		event Action        SetStarted;
		event Action        EntireSetChanged;
		event Action< int > RowChanged;

		int[,] Data { get; }
	}
}