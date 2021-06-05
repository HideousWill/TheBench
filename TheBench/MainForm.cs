using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using HideousWorks.CommonWorks;

namespace HideousWorks.TheBench
{
	public partial class MainForm : Form
	{
		//----------------------------------------------------------------------
		public MainForm()
		{
			InitializeComponent();
		}

		//----------------------------------------------------------------------
		TextBoxWriter ConsoleWriter { get; set; }

		Panel AppHostPanel => RootSplitter.Panel1;

		//----------------------------------------------------------------------
		UserControl _ActiveAppControl;
		UserControl ActiveAppControl
		{
			get => _ActiveAppControl;
			set
			{
				if (null != _ActiveAppControl)
				{
					AppHostPanel.Controls.Remove( _ActiveAppControl );
					_ActiveAppControl.Dispose();
				}
				_ActiveAppControl = value;
				if (null != _ActiveAppControl)
				{
					AppHostPanel.Controls.Add( _ActiveAppControl );
					_ActiveAppControl.Parent = AppHostPanel;
				}
			}
		}

		//----------------------------------------------------------------------
		void BuildAppMenu()
		{
			foreach( var dll in Directory.GetFiles( ".", "*.dll" ) )
			{
				Assembly.LoadFrom( dll );
			}

			foreach( var assembly in AppDomain.CurrentDomain.GetAssemblies() )
				foreach( var type in assembly.GetTypes() )
				{
					if( ! type.IsSubclassOf( typeof( UserControl ) ) ) continue;
					if( ! (Attribute.GetCustomAttribute( type, typeof( BenchApplicationAttribute ) ) is
						BenchApplicationAttribute attr) ) continue;

					var item = new ToolStripMenuItem( attr.Label );
					item.Click += OnApplicationItemClick;
					item.Tag   =  type;

					applicationToolStripMenuItem.DropDownItems.Add( item );

					Console.WriteLine( $"Added app '{item.Text}'" );
				}
		}

		//----------------------------------------------------------------------
		void OnApplicationItemClick( object sender, EventArgs e )
		{
			if( ! (sender is ToolStripMenuItem item) ) return;

			var type = item.Tag as Type;

			Debug.Assert( type != null, nameof(type) + " != null" );
			var app = Activator.CreateInstance( type ) as UserControl;

			Console.WriteLine( $"Activating '{item.Text}'" );

			ActiveAppControl = app;
		}

		//----------------------------------------------------------------------
		void MainForm_Load(object sender, EventArgs e)
		{
			ConsoleWriter = new TextBoxWriter(ConsoleTextBox);

			Console.SetOut( ConsoleWriter );
			Console.SetError( ConsoleWriter );

			BuildAppMenu();
		}
	}
}
