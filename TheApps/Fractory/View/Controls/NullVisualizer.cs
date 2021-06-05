using System;
using System.Drawing;
using HideousWorks.CommonWorks.ColorTables;
using HideousWorks.Fractory.Model;

namespace HideousWorks.Fractory.View.Controls
{
	public class NullVisualizer : IVisualizer
	{
		public event Action< Rectangle > RectangleSelected;

		public ColorTableBase Palette { get; set; }

		public ISetData Data { get; set; }

		public void Reload() { }
	}
}