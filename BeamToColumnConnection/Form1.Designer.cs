namespace BeamToColumnConnection
{
	partial class BeamToColumnConnection
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
			this.buttonCreateBeamsAndColumn = new System.Windows.Forms.Button();
			this.buttonClipAngle141 = new System.Windows.Forms.Button();
			this.buttonShearPlateSimple146 = new System.Windows.Forms.Button();
			this.buttonEndPlate144 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCreateBeamsAndColumn
			// 
			this.buttonCreateBeamsAndColumn.Location = new System.Drawing.Point(26, 102);
			this.buttonCreateBeamsAndColumn.Name = "buttonCreateBeamsAndColumn";
			this.buttonCreateBeamsAndColumn.Size = new System.Drawing.Size(228, 42);
			this.buttonCreateBeamsAndColumn.TabIndex = 11;
			this.buttonCreateBeamsAndColumn.Text = "Create Beams and Column";
			this.buttonCreateBeamsAndColumn.UseVisualStyleBackColor = true;
			this.buttonCreateBeamsAndColumn.Click += new System.EventHandler(this.buttonCreateBeamsAndColumn_Click);
			// 
			// buttonClipAngle141
			// 
			this.buttonClipAngle141.Location = new System.Drawing.Point(26, 172);
			this.buttonClipAngle141.Name = "buttonClipAngle141";
			this.buttonClipAngle141.Size = new System.Drawing.Size(228, 42);
			this.buttonClipAngle141.TabIndex = 10;
			this.buttonClipAngle141.Text = "Clip Angle (141)";
			this.buttonClipAngle141.UseVisualStyleBackColor = true;
			this.buttonClipAngle141.Click += new System.EventHandler(this.buttonClipAngle141_Click);
			// 
			// buttonShearPlateSimple146
			// 
			this.buttonShearPlateSimple146.Location = new System.Drawing.Point(26, 268);
			this.buttonShearPlateSimple146.Name = "buttonShearPlateSimple146";
			this.buttonShearPlateSimple146.Size = new System.Drawing.Size(228, 42);
			this.buttonShearPlateSimple146.TabIndex = 9;
			this.buttonShearPlateSimple146.Text = "Shear Plate Simple (146)";
			this.buttonShearPlateSimple146.UseVisualStyleBackColor = true;
			this.buttonShearPlateSimple146.Click += new System.EventHandler(this.buttonShearPlateSimple146_Click);
			// 
			// buttonEndPlate144
			// 
			this.buttonEndPlate144.Location = new System.Drawing.Point(26, 220);
			this.buttonEndPlate144.Name = "buttonEndPlate144";
			this.buttonEndPlate144.Size = new System.Drawing.Size(228, 42);
			this.buttonEndPlate144.TabIndex = 8;
			this.buttonEndPlate144.Text = "End Plate (144)";
			this.buttonEndPlate144.UseVisualStyleBackColor = true;
			this.buttonEndPlate144.Click += new System.EventHandler(this.buttonEndPlate144_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BeamToColumnConnection.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(56, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(172, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// BeamToColumnConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 353);
			this.Controls.Add(this.buttonCreateBeamsAndColumn);
			this.Controls.Add(this.buttonClipAngle141);
			this.Controls.Add(this.buttonShearPlateSimple146);
			this.Controls.Add(this.buttonEndPlate144);
			this.Controls.Add(this.pictureBox1);
			this.Name = "BeamToColumnConnection";
			this.Text = "Beam To Column Connection";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonCreateBeamsAndColumn;
		private System.Windows.Forms.Button buttonClipAngle141;
		private System.Windows.Forms.Button buttonShearPlateSimple146;
		private System.Windows.Forms.Button buttonEndPlate144;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

