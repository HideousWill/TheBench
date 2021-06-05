using System;
using System.Windows.Forms;
using HideousWorks.CommonWorks.ColorTables;

namespace HideousWorks.Fractory.View.Controls
{
	public partial class VisualizerControl : UserControl
	{
		//----------------------------------------------------------------------
		IVisualizer _Visualizer;
		public IVisualizer Visualizer
		{
			get => _Visualizer;
			set
			{
				_Visualizer = value;

				_Visualizer.Palette = SelectedColorTable;
			}
		}

		//----------------------------------------------------------------------
		ColorTableList _ColorTables;
		public ColorTableList ColorTables
		{
			get => _ColorTables;
			set
			{
				_ColorTables = value;
				ColorTableComboBox.Items.Clear();

				if( null == value ) return;

				if( 0 == value.Count ) return;

				ColorTableComboBox.Items.AddRange( items: value.ToArray() );
				ColorTableComboBox.SelectedIndex = 0;
			}
		}

		//----------------------------------------------------------------------
		ColorTableBase SelectedColorTable => ColorTableComboBox.SelectedItem as ColorTableBase;

		//----------------------------------------------------------------------
		public VisualizerControl()
		{
			InitializeComponent();

			Visualizer = new NullVisualizer();
		}

		//----------------------------------------------------------------------
		void VisualizerControl_Load( object sender, EventArgs e )
		{
			// This is deferred until load time because the class builds is own tables reflexively
			ColorTables = new ColorTableList();
		}

		//----------------------------------------------------------------------
		void ColorTableComboBox_SelectedIndexChanged( object sender, EventArgs e )
		{
			Visualizer.Palette = SelectedColorTable;

			var seeded = SelectedColorTable as IRandomSeeded;

			var isSeeded = null != seeded;

			RandomSeedUpDown.Enabled = isSeeded;
			RandomSeedLabel.Enabled  = isSeeded;
			AnimateCheckBox.Enabled  = isSeeded;
			FpsLabel.Enabled         = isSeeded;
			FpsUpDown.Enabled        = isSeeded;

			if( isSeeded )
			{
				RandomSeedUpDown.Value = seeded.Seed;
			}
		}

		//----------------------------------------------------------------------
		void RandomSeedUpDown_ValueChanged( object sender, EventArgs e )
		{
			if( ! (SelectedColorTable is IRandomSeeded seeded) ) return;

			seeded.Seed = Convert.ToInt32( RandomSeedUpDown.Value );

			Visualizer.Reload();
		}
	}
}
