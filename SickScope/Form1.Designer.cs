namespace SickScope
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numHThick = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Vert = new System.Windows.Forms.CheckBox();
            this.cb_Hor = new System.Windows.Forms.CheckBox();
            this.numVThick = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Zoom = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHThick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVThick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numHThick
            // 
            this.numHThick.Location = new System.Drawing.Point(75, 10);
            this.numHThick.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHThick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHThick.Name = "numHThick";
            this.numHThick.Size = new System.Drawing.Size(120, 20);
            this.numHThick.TabIndex = 0;
            this.numHThick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "H Thickness";
            // 
            // cb_Vert
            // 
            this.cb_Vert.AutoSize = true;
            this.cb_Vert.Checked = true;
            this.cb_Vert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Vert.Location = new System.Drawing.Point(10, 85);
            this.cb_Vert.Name = "cb_Vert";
            this.cb_Vert.Size = new System.Drawing.Size(84, 17);
            this.cb_Vert.TabIndex = 3;
            this.cb_Vert.Text = "Vertical Line";
            this.cb_Vert.UseVisualStyleBackColor = true;
            // 
            // cb_Hor
            // 
            this.cb_Hor.AutoSize = true;
            this.cb_Hor.Checked = true;
            this.cb_Hor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Hor.Location = new System.Drawing.Point(10, 62);
            this.cb_Hor.Name = "cb_Hor";
            this.cb_Hor.Size = new System.Drawing.Size(96, 17);
            this.cb_Hor.TabIndex = 2;
            this.cb_Hor.Text = "Horizontal Line";
            this.cb_Hor.UseVisualStyleBackColor = true;
            // 
            // numVThick
            // 
            this.numVThick.Location = new System.Drawing.Point(75, 36);
            this.numVThick.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVThick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVThick.Name = "numVThick";
            this.numVThick.Size = new System.Drawing.Size(120, 20);
            this.numVThick.TabIndex = 1;
            this.numVThick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "V Thickness";
            // 
            // cb_Zoom
            // 
            this.cb_Zoom.AutoSize = true;
            this.cb_Zoom.Checked = true;
            this.cb_Zoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Zoom.Location = new System.Drawing.Point(10, 108);
            this.cb_Zoom.Name = "cb_Zoom";
            this.cb_Zoom.Size = new System.Drawing.Size(53, 17);
            this.cb_Zoom.TabIndex = 6;
            this.cb_Zoom.Text = "Zoom";
            this.cb_Zoom.UseVisualStyleBackColor = true;
            this.cb_Zoom.CheckedChanged += new System.EventHandler(this.cb_Zoom_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height";
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(74, 153);
            this.numHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 20);
            this.numHeight.TabIndex = 5;
            this.numHeight.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numHeight.ValueChanged += new System.EventHandler(this.numHeight_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Width";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(74, 127);
            this.numWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 20);
            this.numWidth.TabIndex = 4;
            this.numWidth.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 529);
            this.Controls.Add(this.cb_Zoom);
            this.Controls.Add(this.cb_Vert);
            this.Controls.Add(this.cb_Hor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numVThick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numHThick);
            this.Name = "Form1";
            this.Text = "SickZoomMachine";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHThick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVThick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numHThick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numVThick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.CheckBox cb_Vert;
        private System.Windows.Forms.CheckBox cb_Hor;
        private System.Windows.Forms.CheckBox cb_Zoom;
    }
}

