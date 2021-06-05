namespace HideousWorks.Fractory.View.Controls
{
	partial class RangeControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangeControl));
			this.RangeGroupBox = new System.Windows.Forms.GroupBox();
			this.MinValueControl = new HideousWorks.Fractory.View.Controls.ComplexNumberControl();
			this.MinLabel = new System.Windows.Forms.Label();
			this.ExtentValueControl = new HideousWorks.Fractory.View.Controls.ComplexNumberControl();
			this.ExtentLabel = new System.Windows.Forms.Label();
			this.MaxValueControl = new HideousWorks.Fractory.View.Controls.ComplexNumberControl();
			this.MaxLabel = new System.Windows.Forms.Label();
			this.RangeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// RangeGroupBox
			// 
			this.RangeGroupBox.Controls.Add(this.MinValueControl);
			this.RangeGroupBox.Controls.Add(this.MinLabel);
			this.RangeGroupBox.Controls.Add(this.ExtentValueControl);
			this.RangeGroupBox.Controls.Add(this.ExtentLabel);
			this.RangeGroupBox.Controls.Add(this.MaxValueControl);
			this.RangeGroupBox.Controls.Add(this.MaxLabel);
			this.RangeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RangeGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RangeGroupBox.Location = new System.Drawing.Point(0, 0);
			this.RangeGroupBox.Name = "RangeGroupBox";
			this.RangeGroupBox.Size = new System.Drawing.Size(265, 100);
			this.RangeGroupBox.TabIndex = 0;
			this.RangeGroupBox.TabStop = false;
			this.RangeGroupBox.Text = "Range (complex values)";
			// 
			// MinValueControl
			// 
			this.MinValueControl.Location = new System.Drawing.Point(50, 69);
			this.MinValueControl.Max = ((System.Numerics.Complex)(resources.GetObject("MinValueControl.Max")));
			this.MinValueControl.MaximumSize = new System.Drawing.Size(209, 20);
			this.MinValueControl.Min = ((System.Numerics.Complex)(resources.GetObject("MinValueControl.Min")));
			this.MinValueControl.MinimumSize = new System.Drawing.Size(209, 20);
			this.MinValueControl.Name = "MinValueControl";
			this.MinValueControl.Size = new System.Drawing.Size(209, 20);
			this.MinValueControl.TabIndex = 5;
			this.MinValueControl.Value = ((System.Numerics.Complex)(resources.GetObject("MinValueControl.Value")));
			// 
			// MinLabel
			// 
			this.MinLabel.Location = new System.Drawing.Point(4, 69);
			this.MinLabel.Name = "MinLabel";
			this.MinLabel.Size = new System.Drawing.Size(40, 20);
			this.MinLabel.TabIndex = 4;
			this.MinLabel.Text = "Min:";
			this.MinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ExtentValueControl
			// 
			this.ExtentValueControl.Location = new System.Drawing.Point(50, 43);
			this.ExtentValueControl.Max = ((System.Numerics.Complex)(resources.GetObject("ExtentValueControl.Max")));
			this.ExtentValueControl.MaximumSize = new System.Drawing.Size(209, 20);
			this.ExtentValueControl.Min = ((System.Numerics.Complex)(resources.GetObject("ExtentValueControl.Min")));
			this.ExtentValueControl.MinimumSize = new System.Drawing.Size(209, 20);
			this.ExtentValueControl.Name = "ExtentValueControl";
			this.ExtentValueControl.Size = new System.Drawing.Size(209, 20);
			this.ExtentValueControl.TabIndex = 3;
			this.ExtentValueControl.Value = ((System.Numerics.Complex)(resources.GetObject("ExtentValueControl.Value")));
			this.ExtentValueControl.Load += new System.EventHandler(this.ExtentValueControl_Load);
			// 
			// ExtentLabel
			// 
			this.ExtentLabel.Location = new System.Drawing.Point(4, 43);
			this.ExtentLabel.Name = "ExtentLabel";
			this.ExtentLabel.Size = new System.Drawing.Size(40, 20);
			this.ExtentLabel.TabIndex = 2;
			this.ExtentLabel.Text = "Extent:";
			this.ExtentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MaxValueControl
			// 
			this.MaxValueControl.Enabled = false;
			this.MaxValueControl.Location = new System.Drawing.Point(50, 17);
			this.MaxValueControl.Max = ((System.Numerics.Complex)(resources.GetObject("MaxValueControl.Max")));
			this.MaxValueControl.MaximumSize = new System.Drawing.Size(209, 20);
			this.MaxValueControl.Min = ((System.Numerics.Complex)(resources.GetObject("MaxValueControl.Min")));
			this.MaxValueControl.MinimumSize = new System.Drawing.Size(209, 20);
			this.MaxValueControl.Name = "MaxValueControl";
			this.MaxValueControl.Size = new System.Drawing.Size(209, 20);
			this.MaxValueControl.TabIndex = 1;
			this.MaxValueControl.Value = ((System.Numerics.Complex)(resources.GetObject("MaxValueControl.Value")));
			// 
			// MaxLabel
			// 
			this.MaxLabel.Location = new System.Drawing.Point(4, 17);
			this.MaxLabel.Name = "MaxLabel";
			this.MaxLabel.Size = new System.Drawing.Size(40, 20);
			this.MaxLabel.TabIndex = 0;
			this.MaxLabel.Text = "Max:";
			this.MaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RangeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.RangeGroupBox);
			this.Name = "RangeControl";
			this.Size = new System.Drawing.Size(265, 100);
			this.RangeGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox RangeGroupBox;
		private ComplexNumberControl MinValueControl;
		private System.Windows.Forms.Label MinLabel;
		private ComplexNumberControl ExtentValueControl;
		private System.Windows.Forms.Label ExtentLabel;
		private ComplexNumberControl MaxValueControl;
		private System.Windows.Forms.Label MaxLabel;
	}
}
