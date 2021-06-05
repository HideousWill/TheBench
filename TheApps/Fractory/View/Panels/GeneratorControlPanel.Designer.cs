namespace HideousWorks.Fractory.View.Panels
{
	partial class GeneratorControlPanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorControlPanel));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DefaultsButton = new System.Windows.Forms.Button();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.EvaluationControl = new HideousWorks.Fractory.View.Controls.EvaluationControl();
			this.SampleRateControl = new HideousWorks.Fractory.View.Controls.SampleRateControl();
			this.RangeControl = new HideousWorks.Fractory.View.Controls.RangeControl();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DefaultsButton);
			this.groupBox1.Controls.Add(this.GenerateButton);
			this.groupBox1.Controls.Add(this.EvaluationControl);
			this.groupBox1.Controls.Add(this.SampleRateControl);
			this.groupBox1.Controls.Add(this.RangeControl);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(281, 444);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Generation Controls";
			// 
			// DefaultsButton
			// 
			this.DefaultsButton.Location = new System.Drawing.Point(3, 292);
			this.DefaultsButton.Name = "DefaultsButton";
			this.DefaultsButton.Size = new System.Drawing.Size(75, 23);
			this.DefaultsButton.TabIndex = 4;
			this.DefaultsButton.Text = "Defaults";
			this.DefaultsButton.UseVisualStyleBackColor = true;
			this.DefaultsButton.Click += new System.EventHandler(this.DefaultsButton_Click);
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(84, 292);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(75, 23);
			this.GenerateButton.TabIndex = 3;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// EvaluationControl
			// 
			this.EvaluationControl.Convergence = 2D;
			this.EvaluationControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.EvaluationControl.Iterations = 200;
			this.EvaluationControl.Location = new System.Drawing.Point(3, 186);
			this.EvaluationControl.Name = "EvaluationControl";
			this.EvaluationControl.Size = new System.Drawing.Size(275, 100);
			this.EvaluationControl.TabIndex = 2;
			// 
			// SampleRateControl
			// 
			this.SampleRateControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.SampleRateControl.Location = new System.Drawing.Point(3, 116);
			this.SampleRateControl.Name = "SampleRateControl";
			this.SampleRateControl.Resolution = new System.Drawing.Size(256, 256);
			this.SampleRateControl.Size = new System.Drawing.Size(275, 70);
			this.SampleRateControl.TabIndex = 1;
			// 
			// RangeControl
			// 
			this.RangeControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.RangeControl.Extent = ((System.Numerics.Complex)(resources.GetObject("RangeControl.Extent")));
			this.RangeControl.Location = new System.Drawing.Point(3, 16);
			this.RangeControl.Min = ((System.Numerics.Complex)(resources.GetObject("RangeControl.Min")));
			this.RangeControl.Name = "RangeControl";
			this.RangeControl.Size = new System.Drawing.Size(275, 100);
			this.RangeControl.TabIndex = 0;
			// 
			// GeneratorControlPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.Name = "GeneratorControlPanel";
			this.Size = new System.Drawing.Size(281, 444);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private Controls.EvaluationControl EvaluationControl;
		private Controls.SampleRateControl SampleRateControl;
		private Controls.RangeControl RangeControl;
		private System.Windows.Forms.Button DefaultsButton;
		private System.Windows.Forms.Button GenerateButton;
	}
}
