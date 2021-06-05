using System.Windows.Forms;
using HideousWorks.Fractory.Model;

namespace HideousWorks.Fractory.View.Panels
{
	public partial class VisualizerPanel : UserControl
	{
		ISetData _SetData;

		public ISetData SetData
		{
			get => _SetData;
			set
			{
				_SetData = value;
				VisualizerControl.Visualizer.Data = _SetData;
			}
		}

		public VisualizerPanel()
		{
			InitializeComponent();
		}

		void VisualizerPanel_Load(object sender, System.EventArgs e)
		{
			VisualizerControl.Visualizer = ImageHost;
		}
	}
}
