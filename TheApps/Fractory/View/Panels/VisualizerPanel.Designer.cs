namespace HideousWorks.Fractory.View.Panels
{
	partial class VisualizerPanel
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
			this.VisualizerControl = new HideousWorks.Fractory.View.Controls.VisualizerControl();
			this.ImageHost = new HideousWorks.Fractory.View.Controls.ImageHostControl();
			this.SuspendLayout();
			// 
			// VisualizerControl
			// 
			this.VisualizerControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.VisualizerControl.Location = new System.Drawing.Point(0, 0);
			this.VisualizerControl.Name = "VisualizerControl";
			this.VisualizerControl.Size = new System.Drawing.Size(372, 77);
			this.VisualizerControl.TabIndex = 0;
			// 
			// ImageHost
			// 
			this.ImageHost.BackColor = System.Drawing.Color.White;
			this.ImageHost.Data = null;
			this.ImageHost.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ImageHost.Location = new System.Drawing.Point(0, 77);
			this.ImageHost.Name = "ImageHost";
			this.ImageHost.Palette = null;
			this.ImageHost.Size = new System.Drawing.Size(372, 324);
			this.ImageHost.TabIndex = 1;
			// 
			// VisualizerPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ImageHost);
			this.Controls.Add(this.VisualizerControl);
			this.Name = "VisualizerPanel";
			this.Size = new System.Drawing.Size(372, 401);
			this.Load += new System.EventHandler(this.VisualizerPanel_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.VisualizerControl VisualizerControl;
		private Controls.ImageHostControl ImageHost;
	}
}
