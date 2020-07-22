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
            this.cb_LockX = new System.Windows.Forms.CheckBox();
            this.cb_LockY = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num_Refresh = new System.Windows.Forms.NumericUpDown();
            this.cb_IgnoreScope = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pan_HorizontalColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pan_VerticalColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHThick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVThick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Refresh)).BeginInit();
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
            this.numHThick.Location = new System.Drawing.Point(142, 35);
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
            this.numHThick.Size = new System.Drawing.Size(52, 20);
            this.numHThick.TabIndex = 1;
            this.numHThick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Horizontal Line Thickness";
            // 
            // cb_Vert
            // 
            this.cb_Vert.AutoSize = true;
            this.cb_Vert.Checked = true;
            this.cb_Vert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Vert.Location = new System.Drawing.Point(12, 90);
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
            this.cb_Hor.Location = new System.Drawing.Point(12, 12);
            this.cb_Hor.Name = "cb_Hor";
            this.cb_Hor.Size = new System.Drawing.Size(96, 17);
            this.cb_Hor.TabIndex = 0;
            this.cb_Hor.Text = "Horizontal Line";
            this.cb_Hor.UseVisualStyleBackColor = true;
            // 
            // numVThick
            // 
            this.numVThick.Location = new System.Drawing.Point(142, 113);
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
            this.numVThick.Size = new System.Drawing.Size(52, 20);
            this.numVThick.TabIndex = 4;
            this.numVThick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vertical Line Thickness";
            // 
            // cb_Zoom
            // 
            this.cb_Zoom.AutoSize = true;
            this.cb_Zoom.Checked = true;
            this.cb_Zoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Zoom.Location = new System.Drawing.Point(9, 259);
            this.cb_Zoom.Name = "cb_Zoom";
            this.cb_Zoom.Size = new System.Drawing.Size(53, 17);
            this.cb_Zoom.TabIndex = 9;
            this.cb_Zoom.Text = "Zoom";
            this.cb_Zoom.UseVisualStyleBackColor = true;
            this.cb_Zoom.CheckedChanged += new System.EventHandler(this.cb_Zoom_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height";
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(142, 196);
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
            this.numHeight.Size = new System.Drawing.Size(52, 20);
            this.numHeight.TabIndex = 7;
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
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Width";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(142, 170);
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
            this.numWidth.Size = new System.Drawing.Size(52, 20);
            this.numWidth.TabIndex = 6;
            this.numWidth.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.numWidth_ValueChanged);
            // 
            // cb_LockX
            // 
            this.cb_LockX.AutoSize = true;
            this.cb_LockX.Location = new System.Drawing.Point(9, 282);
            this.cb_LockX.Name = "cb_LockX";
            this.cb_LockX.Size = new System.Drawing.Size(115, 17);
            this.cb_LockX.TabIndex = 10;
            this.cb_LockX.Text = "Lock X (Ctrl+Alt+X)";
            this.cb_LockX.UseVisualStyleBackColor = true;
            this.cb_LockX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_LockX_MouseClick);
            // 
            // cb_LockY
            // 
            this.cb_LockY.AutoSize = true;
            this.cb_LockY.Location = new System.Drawing.Point(9, 305);
            this.cb_LockY.Name = "cb_LockY";
            this.cb_LockY.Size = new System.Drawing.Size(115, 17);
            this.cb_LockY.TabIndex = 11;
            this.cb_LockY.Text = "Lock Y (Ctrl+Alt+Y)";
            this.cb_LockY.UseVisualStyleBackColor = true;
            this.cb_LockY.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cb_LockY_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Refresh (Lower is Better)";
            // 
            // num_Refresh
            // 
            this.num_Refresh.Location = new System.Drawing.Point(142, 222);
            this.num_Refresh.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_Refresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Refresh.Name = "num_Refresh";
            this.num_Refresh.Size = new System.Drawing.Size(52, 20);
            this.num_Refresh.TabIndex = 8;
            this.num_Refresh.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cb_IgnoreScope
            // 
            this.cb_IgnoreScope.AutoSize = true;
            this.cb_IgnoreScope.Location = new System.Drawing.Point(9, 328);
            this.cb_IgnoreScope.Name = "cb_IgnoreScope";
            this.cb_IgnoreScope.Size = new System.Drawing.Size(120, 17);
            this.cb_IgnoreScope.TabIndex = 12;
            this.cb_IgnoreScope.Text = "Ignore SickScope™";
            this.cb_IgnoreScope.UseVisualStyleBackColor = true;
            // 
            // pan_HorizontalColor
            // 
            this.pan_HorizontalColor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pan_HorizontalColor.Location = new System.Drawing.Point(142, 61);
            this.pan_HorizontalColor.Name = "pan_HorizontalColor";
            this.pan_HorizontalColor.Size = new System.Drawing.Size(52, 20);
            this.pan_HorizontalColor.TabIndex = 2;
            this.pan_HorizontalColor.TabStop = true;
            this.pan_HorizontalColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pan_HorizontalColor_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Horizontal Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vertical Color";
            // 
            // pan_VerticalColor
            // 
            this.pan_VerticalColor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pan_VerticalColor.Location = new System.Drawing.Point(142, 139);
            this.pan_VerticalColor.Name = "pan_VerticalColor";
            this.pan_VerticalColor.Size = new System.Drawing.Size(52, 20);
            this.pan_VerticalColor.TabIndex = 5;
            this.pan_VerticalColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pan_VerticalColor_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pan_VerticalColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pan_HorizontalColor);
            this.Controls.Add(this.cb_IgnoreScope);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_Refresh);
            this.Controls.Add(this.cb_LockY);
            this.Controls.Add(this.cb_LockX);
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
            this.Text = "SickScope™";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHThick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVThick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Refresh)).EndInit();
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
        private System.Windows.Forms.CheckBox cb_LockX;
        private System.Windows.Forms.CheckBox cb_LockY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_Refresh;
        private System.Windows.Forms.CheckBox cb_IgnoreScope;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pan_HorizontalColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pan_VerticalColor;
    }
}

