using HideousWorks.Fractory.View.Panels;

namespace HideousWorks.Fractory
{
	partial class FractoryApp
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.RootSplitter = new System.Windows.Forms.SplitContainer();
			this.GeneratorControlPanel = new HideousWorks.Fractory.View.Panels.GeneratorControlPanel();
			this.VisualizerPanel = new HideousWorks.Fractory.View.Panels.VisualizerPanel();
			((System.ComponentModel.ISupportInitialize)(this.RootSplitter)).BeginInit();
			this.RootSplitter.Panel1.SuspendLayout();
			this.RootSplitter.Panel2.SuspendLayout();
			this.RootSplitter.SuspendLayout();
			this.SuspendLayout();
			// 
			// RootSplitter
			// 
			this.RootSplitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.RootSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RootSplitter.IsSplitterFixed = true;
			this.RootSplitter.Location = new System.Drawing.Point(0, 0);
			this.RootSplitter.Name = "RootSplitter";
			// 
			// RootSplitter.Panel1
			// 
			this.RootSplitter.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.RootSplitter.Panel1.Controls.Add(this.GeneratorControlPanel);
			// 
			// RootSplitter.Panel2
			// 
			this.RootSplitter.Panel2.Controls.Add(this.VisualizerPanel);
			this.RootSplitter.Size = new System.Drawing.Size(825, 650);
			this.RootSplitter.SplitterDistance = 278;
			this.RootSplitter.TabIndex = 0;
			// 
			// GeneratorControlPanel
			// 
			this.GeneratorControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GeneratorControlPanel.Generator = null;
			this.GeneratorControlPanel.Location = new System.Drawing.Point(0, 0);
			this.GeneratorControlPanel.Name = "GeneratorControlPanel";
			this.GeneratorControlPanel.Size = new System.Drawing.Size(276, 648);
			this.GeneratorControlPanel.TabIndex = 0;
			// 
			// VisualizerPanel
			// 
			this.VisualizerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VisualizerPanel.Location = new System.Drawing.Point(0, 0);
			this.VisualizerPanel.Name = "VisualizerPanel";
			this.VisualizerPanel.SetData = null;
			this.VisualizerPanel.Size = new System.Drawing.Size(541, 648);
			this.VisualizerPanel.TabIndex = 0;
			// 
			// FractoryApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.RootSplitter);
			this.MinimumSize = new System.Drawing.Size(640, 400);
			this.Name = "FractoryApp";
			this.Size = new System.Drawing.Size(825, 650);
			this.Load += new System.EventHandler(this.FractoryApp_Load);
			this.RootSplitter.Panel1.ResumeLayout(false);
			this.RootSplitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RootSplitter)).EndInit();
			this.RootSplitter.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer RootSplitter;
		private VisualizerPanel VisualizerPanel;
		private GeneratorControlPanel GeneratorControlPanel;
	}
}
