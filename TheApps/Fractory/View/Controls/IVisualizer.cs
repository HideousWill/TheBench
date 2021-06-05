using System;
using System.Drawing;
using HideousWorks.CommonWorks.ColorTables;
using HideousWorks.Fractory.Model;

namespace HideousWorks.Fractory.View.Controls
{
	public interface IImageNavigator
	{
		event Action< Rectangle > RectangleSelected;
	}

	public interface IVisualizer : IImageNavigator
	{
		ColorTableBase Palette { get; set; }

		ISetData Data { get; set; }

		void Reload();
	}
}