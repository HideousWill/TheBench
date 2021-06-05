namespace HideousWorks.Fractory.View.Controls
{
	partial class ComplexNumberControl
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
			this.RealUpDown = new System.Windows.Forms.NumericUpDown();
			this.ImaginaryUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.RealUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImaginaryUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// RealUpDown
			// 
			this.RealUpDown.DecimalPlaces = 10;
			this.RealUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.RealUpDown.Location = new System.Drawing.Point(0, 0);
			this.RealUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.RealUpDown.Name = "RealUpDown";
			this.RealUpDown.Size = new System.Drawing.Size(100, 20);
			this.RealUpDown.TabIndex = 0;
			this.RealUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.RealUpDown.ValueChanged += new System.EventHandler(this.RealOrImaginary_ValueChanged);
			// 
			// ImaginaryUpDown
			// 
			this.ImaginaryUpDown.DecimalPlaces = 10;
			this.ImaginaryUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.ImaginaryUpDown.Location = new System.Drawing.Point(106, 0);
			this.ImaginaryUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.ImaginaryUpDown.Name = "ImaginaryUpDown";
			this.ImaginaryUpDown.Size = new System.Drawing.Size(100, 20);
			this.ImaginaryUpDown.TabIndex = 1;
			this.ImaginaryUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ImaginaryUpDown.ValueChanged += new System.EventHandler(this.RealOrImaginary_ValueChanged);
			// 
			// ComplexNumberControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ImaginaryUpDown);
			this.Controls.Add(this.RealUpDown);
			this.MaximumSize = new System.Drawing.Size(209, 20);
			this.MinimumSize = new System.Drawing.Size(209, 20);
			this.Name = "ComplexNumberControl";
			this.Size = new System.Drawing.Size(209, 20);
			((System.ComponentModel.ISupportInitialize)(this.RealUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImaginaryUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown RealUpDown;
		private System.Windows.Forms.NumericUpDown ImaginaryUpDown;
	}
}
