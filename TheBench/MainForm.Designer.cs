namespace HideousWorks.TheBench
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RootSplitter = new System.Windows.Forms.SplitContainer();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ConsoleTextBox = new System.Windows.Forms.TextBox();
			this.MainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RootSplitter)).BeginInit();
			this.RootSplitter.Panel2.SuspendLayout();
			this.RootSplitter.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(635, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "MainMenu";
			// 
			// applicationToolStripMenuItem
			// 
			this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
			this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.applicationToolStripMenuItem.Text = "Application";
			// 
			// RootSplitter
			// 
			this.RootSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RootSplitter.Location = new System.Drawing.Point(0, 24);
			this.RootSplitter.Name = "RootSplitter";
			this.RootSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// RootSplitter.Panel1
			// 
			this.RootSplitter.Panel1.AutoScroll = true;
			this.RootSplitter.Panel1.AutoScrollMargin = new System.Drawing.Size(1, 1);
			// 
			// RootSplitter.Panel2
			// 
			this.RootSplitter.Panel2.Controls.Add(this.statusStrip1);
			this.RootSplitter.Panel2.Controls.Add(this.ConsoleTextBox);
			this.RootSplitter.Size = new System.Drawing.Size(635, 615);
			this.RootSplitter.SplitterDistance = 439;
			this.RootSplitter.TabIndex = 1;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 150);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(635, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// ConsoleTextBox
			// 
			this.ConsoleTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ConsoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ConsoleTextBox.Location = new System.Drawing.Point(0, 0);
			this.ConsoleTextBox.Multiline = true;
			this.ConsoleTextBox.Name = "ConsoleTextBox";
			this.ConsoleTextBox.ReadOnly = true;
			this.ConsoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ConsoleTextBox.Size = new System.Drawing.Size(635, 172);
			this.ConsoleTextBox.TabIndex = 0;
			this.ConsoleTextBox.WordWrap = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 639);
			this.Controls.Add(this.RootSplitter);
			this.Controls.Add(this.MainMenu);
			this.Name = "MainForm";
			this.Text = "The Bench";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.RootSplitter.Panel2.ResumeLayout(false);
			this.RootSplitter.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RootSplitter)).EndInit();
			this.RootSplitter.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
		private System.Windows.Forms.SplitContainer RootSplitter;
		private System.Windows.Forms.TextBox ConsoleTextBox;
		private System.Windows.Forms.StatusStrip statusStrip1;
	}
}

