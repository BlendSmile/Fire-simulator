
using System.Drawing;

namespace EffectSimulator
{
    partial class EffectSim
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EffectSim));
            this.toolBar = new System.Windows.Forms.PictureBox();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.SensivityX = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SensivityY = new System.Windows.Forms.NumericUpDown();
            this.Fire = new System.Windows.Forms.CheckBox();
            this.tailBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.tailValue = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tailHigh = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.pngSequence = new System.Windows.Forms.CheckBox();
            this.bmpSequence = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.jpgSequence = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.frameExportLimit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensivityX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensivityY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameExportLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolBar.Location = new System.Drawing.Point(2, 22);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(199, 425);
            this.toolBar.TabIndex = 0;
            this.toolBar.TabStop = false;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(12, 121);
            this.Speed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(38, 20);
            this.Speed.TabIndex = 22;
            this.Speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SensivityX
            // 
            this.SensivityX.Location = new System.Drawing.Point(12, 170);
            this.SensivityX.Name = "SensivityX";
            this.SensivityX.Size = new System.Drawing.Size(38, 20);
            this.SensivityX.TabIndex = 24;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(207, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(461, 425);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // SensivityY
            // 
            this.SensivityY.Location = new System.Drawing.Point(12, 218);
            this.SensivityY.Name = "SensivityY";
            this.SensivityY.Size = new System.Drawing.Size(38, 20);
            this.SensivityY.TabIndex = 37;
            // 
            // Fire
            // 
            this.Fire.AutoSize = true;
            this.Fire.Checked = true;
            this.Fire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Fire.Location = new System.Drawing.Point(9, 32);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(43, 17);
            this.Fire.TabIndex = 6;
            this.Fire.Text = "Fire";
            this.Fire.UseVisualStyleBackColor = true;
            // 
            // tailBox
            // 
            this.tailBox.AutoSize = true;
            this.tailBox.Checked = true;
            this.tailBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tailBox.Location = new System.Drawing.Point(10, 55);
            this.tailBox.Name = "tailBox";
            this.tailBox.Size = new System.Drawing.Size(43, 17);
            this.tailBox.TabIndex = 44;
            this.tailBox.Text = "Tail";
            this.tailBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Preview";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sensitivity Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Sensitivity X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Delay";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Tail";
            // 
            // tailValue
            // 
            this.tailValue.Location = new System.Drawing.Point(13, 274);
            this.tailValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tailValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tailValue.Name = "tailValue";
            this.tailValue.Size = new System.Drawing.Size(38, 20);
            this.tailValue.TabIndex = 54;
            this.tailValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Tail High";
            // 
            // tailHigh
            // 
            this.tailHigh.Location = new System.Drawing.Point(13, 327);
            this.tailHigh.Name = "tailHigh";
            this.tailHigh.Size = new System.Drawing.Size(38, 20);
            this.tailHigh.TabIndex = 56;
            this.tailHigh.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(674, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 425);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.No;
            this.ExportButton.Location = new System.Drawing.Point(740, 416);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(48, 22);
            this.ExportButton.TabIndex = 60;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // pngSequence
            // 
            this.pngSequence.AutoSize = true;
            this.pngSequence.Checked = true;
            this.pngSequence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pngSequence.Location = new System.Drawing.Point(689, 147);
            this.pngSequence.Name = "pngSequence";
            this.pngSequence.Size = new System.Drawing.Size(99, 17);
            this.pngSequence.TabIndex = 64;
            this.pngSequence.Text = "PNG sequence";
            this.pngSequence.UseVisualStyleBackColor = true;
            // 
            // bmpSequence
            // 
            this.bmpSequence.AutoSize = true;
            this.bmpSequence.Location = new System.Drawing.Point(689, 124);
            this.bmpSequence.Name = "bmpSequence";
            this.bmpSequence.Size = new System.Drawing.Size(99, 17);
            this.bmpSequence.TabIndex = 63;
            this.bmpSequence.Text = "BMP sequence";
            this.bmpSequence.UseVisualStyleBackColor = true;
            this.bmpSequence.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Export To";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(671, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Output";
            // 
            // jpgSequence
            // 
            this.jpgSequence.AutoSize = true;
            this.jpgSequence.Location = new System.Drawing.Point(689, 170);
            this.jpgSequence.Name = "jpgSequence";
            this.jpgSequence.Size = new System.Drawing.Size(96, 17);
            this.jpgSequence.TabIndex = 67;
            this.jpgSequence.Text = "JPG sequence";
            this.jpgSequence.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Directory";
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(689, 70);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(99, 20);
            this.directoryBox.TabIndex = 61;
            this.directoryBox.Text = "D:\\fires";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(689, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Frame To Export";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // frameExportLimit
            // 
            this.frameExportLimit.Location = new System.Drawing.Point(689, 218);
            this.frameExportLimit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.frameExportLimit.Name = "frameExportLimit";
            this.frameExportLimit.Size = new System.Drawing.Size(38, 20);
            this.frameExportLimit.TabIndex = 68;
            this.frameExportLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.frameExportLimit.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // EffectSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.frameExportLimit);
            this.Controls.Add(this.jpgSequence);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pngSequence);
            this.Controls.Add(this.bmpSequence);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tailHigh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tailValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tailBox);
            this.Controls.Add(this.SensivityY);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.SensivityX);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.toolBar);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EffectSim";
            this.Text = "Effect Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensivityX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensivityY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameExportLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox toolBar;
        private System.Windows.Forms.NumericUpDown Speed;
        private System.Windows.Forms.NumericUpDown SensivityX;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown SensivityY;
        private System.Windows.Forms.CheckBox Fire;
        private System.Windows.Forms.CheckBox tailBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown tailValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown tailHigh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.CheckBox pngSequence;
        private System.Windows.Forms.CheckBox bmpSequence;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox jpgSequence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown frameExportLimit;
    }
}

