namespace GraphProg
{
    partial class Transform
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
            this.shapeTypeLabel = new System.Windows.Forms.Label();
            this.currentSizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.lineThicknessTrackBar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fillCheckBox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.rotateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineThicknessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeTypeLabel
            // 
            this.shapeTypeLabel.AutoSize = true;
            this.shapeTypeLabel.Location = new System.Drawing.Point(16, 31);
            this.shapeTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shapeTypeLabel.Name = "shapeTypeLabel";
            this.shapeTypeLabel.Size = new System.Drawing.Size(89, 17);
            this.shapeTypeLabel.TabIndex = 2;
            this.shapeTypeLabel.Text = "Shape Type:";
            // 
            // currentSizeLabel
            // 
            this.currentSizeLabel.AutoSize = true;
            this.currentSizeLabel.Location = new System.Drawing.Point(16, 68);
            this.currentSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentSizeLabel.Name = "currentSizeLabel";
            this.currentSizeLabel.Size = new System.Drawing.Size(48, 17);
            this.currentSizeLabel.TabIndex = 9;
            this.currentSizeLabel.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Line Thickness";
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Location = new System.Drawing.Point(115, 27);
            this.shapeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.Size = new System.Drawing.Size(181, 24);
            this.shapeComboBox.TabIndex = 14;
            this.shapeComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // widthTextbox
            // 
            this.widthTextbox.Location = new System.Drawing.Point(77, 68);
            this.widthTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(119, 23);
            this.widthTextbox.TabIndex = 15;
            this.widthTextbox.TextChanged += new System.EventHandler(this.WidthTextbox_TextChanged);
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(77, 100);
            this.heightTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(119, 23);
            this.heightTextbox.TabIndex = 16;
            this.heightTextbox.TextChanged += new System.EventHandler(this.HeightTextbox_TextChanged);
            // 
            // lineThicknessTrackBar
            // 
            this.lineThicknessTrackBar.Location = new System.Drawing.Point(131, 164);
            this.lineThicknessTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.lineThicknessTrackBar.Maximum = 100;
            this.lineThicknessTrackBar.Minimum = 1;
            this.lineThicknessTrackBar.Name = "lineThicknessTrackBar";
            this.lineThicknessTrackBar.Size = new System.Drawing.Size(219, 45);
            this.lineThicknessTrackBar.TabIndex = 17;
            this.lineThicknessTrackBar.Value = 2;
            this.lineThicknessTrackBar.ValueChanged += new System.EventHandler(this.LineThicknessTrackBar_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 220);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Line Colour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 220);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Fill Colour";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // fillCheckBox
            // 
            this.fillCheckBox.AutoSize = true;
            this.fillCheckBox.Location = new System.Drawing.Point(19, 225);
            this.fillCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.fillCheckBox.Name = "fillCheckBox";
            this.fillCheckBox.Size = new System.Drawing.Size(44, 21);
            this.fillCheckBox.TabIndex = 20;
            this.fillCheckBox.Text = "Fill";
            this.fillCheckBox.UseVisualStyleBackColor = true;
            this.fillCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(393, 169);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 22;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button9_MouseUp);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(357, 169);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 23;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button9_MouseUp);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(180, 268);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 24;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(205, 97);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 28);
            this.button7.TabIndex = 26;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button7_Click);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button9_MouseUp);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(241, 97);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 28);
            this.button8.TabIndex = 25;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button8_Click);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button9_MouseUp);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(205, 65);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(28, 28);
            this.button9.TabIndex = 28;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button9_Click);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button9_MouseUp);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(241, 65);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(28, 28);
            this.button10.TabIndex = 27;
            this.button10.Text = "+";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button10_Click);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button9_MouseUp);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(317, 28);
            this.num.Margin = new System.Windows.Forms.Padding(4);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(43, 23);
            this.num.TabIndex = 29;
            this.num.Text = "6";
            this.num.Visible = false;
            this.num.TextChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sides:";
            this.label3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 28);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 32;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(405, 28);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(28, 28);
            this.button11.TabIndex = 31;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(169, 133);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(28, 28);
            this.button12.TabIndex = 36;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button12_MouseDown);
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button9_MouseUp);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(205, 133);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(28, 28);
            this.button13.TabIndex = 35;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button13_MouseDown);
            this.button13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button9_MouseUp);
            // 
            // rotateTextBox
            // 
            this.rotateTextBox.Location = new System.Drawing.Point(77, 133);
            this.rotateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rotateTextBox.Name = "rotateTextBox";
            this.rotateTextBox.Size = new System.Drawing.Size(83, 23);
            this.rotateTextBox.TabIndex = 34;
            this.rotateTextBox.Text = "0";
            this.rotateTextBox.TextChanged += new System.EventHandler(this.RotateTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Rotate:";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(288, 220);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(152, 28);
            this.button14.TabIndex = 37;
            this.button14.Text = "Highlight Colour";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.HighlightColour_Click);
            // 
            // Transform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 311);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.rotateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.fillCheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineThicknessTrackBar);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.widthTextbox);
            this.Controls.Add(this.shapeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentSizeLabel);
            this.Controls.Add(this.shapeTypeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(503, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(503, 350);
            this.Name = "Transform";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Transform_FormClosing);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Transform_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.lineThicknessTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label shapeTypeLabel;
        private System.Windows.Forms.Label currentSizeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.TrackBar lineThicknessTrackBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox fillCheckBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox rotateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button14;
    }
}