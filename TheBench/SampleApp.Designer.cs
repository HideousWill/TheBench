namespace HideousWorks.TheBench
{
	partial class SampleApp
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Silver;
			this.label1.Location = new System.Drawing.Point(23, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is the sample app";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label2.Location = new System.Drawing.Point(182, 237);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Bottom Right";
			// 
			// SampleApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
			this.MaximumSize = new System.Drawing.Size(400, 400);
			this.MinimumSize = new System.Drawing.Size(250, 250);
			this.Name = "SampleApp";
			this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.Size = new System.Drawing.Size(250, 250);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SampleApp_MouseClick);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
