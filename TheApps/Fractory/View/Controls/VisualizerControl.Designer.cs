namespace HideousWorks.Fractory.View.Controls
{
	partial class VisualizerControl
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.FpsUpDown = new System.Windows.Forms.NumericUpDown();
			this.FpsLabel = new System.Windows.Forms.Label();
			this.AnimateCheckBox = new System.Windows.Forms.CheckBox();
			this.RandomSeedUpDown = new System.Windows.Forms.NumericUpDown();
			this.RandomSeedLabel = new System.Windows.Forms.Label();
			this.ColorTableComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FpsUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RandomSeedUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.FpsUpDown);
			this.groupBox1.Controls.Add(this.FpsLabel);
			this.groupBox1.Controls.Add(this.AnimateCheckBox);
			this.groupBox1.Controls.Add(this.RandomSeedUpDown);
			this.groupBox1.Controls.Add(this.RandomSeedLabel);
			this.groupBox1.Controls.Add(this.ColorTableComboBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(325, 77);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Image Controls";
			// 
			// FpsUpDown
			// 
			this.FpsUpDown.Enabled = false;
			this.FpsUpDown.Location = new System.Drawing.Point(251, 48);
			this.FpsUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.FpsUpDown.Name = "FpsUpDown";
			this.FpsUpDown.Size = new System.Drawing.Size(38, 20);
			this.FpsUpDown.TabIndex = 6;
			this.FpsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.FpsUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// FpsLabel
			// 
			this.FpsLabel.AutoSize = true;
			this.FpsLabel.Enabled = false;
			this.FpsLabel.Location = new System.Drawing.Point(215, 50);
			this.FpsLabel.Name = "FpsLabel";
			this.FpsLabel.Size = new System.Drawing.Size(30, 13);
			this.FpsLabel.TabIndex = 5;
			this.FpsLabel.Text = "FPS:";
			this.FpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AnimateCheckBox
			// 
			this.AnimateCheckBox.AutoSize = true;
			this.AnimateCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AnimateCheckBox.Enabled = false;
			this.AnimateCheckBox.Location = new System.Drawing.Point(145, 49);
			this.AnimateCheckBox.Name = "AnimateCheckBox";
			this.AnimateCheckBox.Size = new System.Drawing.Size(64, 17);
			this.AnimateCheckBox.TabIndex = 4;
			this.AnimateCheckBox.Text = "Animate";
			this.AnimateCheckBox.UseVisualStyleBackColor = true;
			// 
			// RandomSeedUpDown
			// 
			this.RandomSeedUpDown.Enabled = false;
			this.RandomSeedUpDown.Location = new System.Drawing.Point(78, 47);
			this.RandomSeedUpDown.Name = "RandomSeedUpDown";
			this.RandomSeedUpDown.Size = new System.Drawing.Size(53, 20);
			this.RandomSeedUpDown.TabIndex = 3;
			this.RandomSeedUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.RandomSeedUpDown.ValueChanged += new System.EventHandler(this.RandomSeedUpDown_ValueChanged);
			// 
			// RandomSeedLabel
			// 
			this.RandomSeedLabel.AutoSize = true;
			this.RandomSeedLabel.Enabled = false;
			this.RandomSeedLabel.Location = new System.Drawing.Point(35, 49);
			this.RandomSeedLabel.Name = "RandomSeedLabel";
			this.RandomSeedLabel.Size = new System.Drawing.Size(35, 13);
			this.RandomSeedLabel.TabIndex = 2;
			this.RandomSeedLabel.Text = "Seed:";
			this.RandomSeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ColorTableComboBox
			// 
			this.ColorTableComboBox.FormattingEnabled = true;
			this.ColorTableComboBox.Location = new System.Drawing.Point(78, 20);
			this.ColorTableComboBox.Name = "ColorTableComboBox";
			this.ColorTableComboBox.Size = new System.Drawing.Size(130, 21);
			this.ColorTableComboBox.TabIndex = 1;
			this.ColorTableComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorTableComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Color Table:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// VisualizerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "VisualizerControl";
			this.Size = new System.Drawing.Size(325, 77);
			this.Load += new System.EventHandler(this.VisualizerControl_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FpsUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RandomSeedUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown FpsUpDown;
		private System.Windows.Forms.Label FpsLabel;
		private System.Windows.Forms.CheckBox AnimateCheckBox;
		private System.Windows.Forms.NumericUpDown RandomSeedUpDown;
		private System.Windows.Forms.Label RandomSeedLabel;
		private System.Windows.Forms.ComboBox ColorTableComboBox;
		private System.Windows.Forms.Label label1;
	}
}
