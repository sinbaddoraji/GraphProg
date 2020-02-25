namespace GraphProg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rightangledTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.canvas1 = new GraphProg.Canvas();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.noShapeRadioButton = new System.Windows.Forms.RadioButton();
            this.squareRadioButton = new System.Windows.Forms.RadioButton();
            this.circleRadioButton = new System.Windows.Forms.RadioButton();
            this.triangleRadioButton = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.diamondRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rTriangleRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.pentagonRadioButton = new System.Windows.Forms.RadioButton();
            this.hepatagonRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.heptagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noShapeToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.triangleToolStripMenuItem,
            this.toolStripSeparator1,
            this.rightangledTriangleToolStripMenuItem,
            this.diamondToolStripMenuItem,
            this.pentagonToolStripMenuItem,
            this.heptagonToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // noShapeToolStripMenuItem
            // 
            this.noShapeToolStripMenuItem.Checked = true;
            this.noShapeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noShapeToolStripMenuItem.Name = "noShapeToolStripMenuItem";
            this.noShapeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noShapeToolStripMenuItem.Text = "No Shape";
            this.noShapeToolStripMenuItem.Click += new System.EventHandler(this.noShapeToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // rightangledTriangleToolStripMenuItem
            // 
            this.rightangledTriangleToolStripMenuItem.Name = "rightangledTriangleToolStripMenuItem";
            this.rightangledTriangleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rightangledTriangleToolStripMenuItem.Text = "Right-angled Triangle";
            this.rightangledTriangleToolStripMenuItem.Click += new System.EventHandler(this.rightangledTriangleToolStripMenuItem_Click);
            // 
            // diamondToolStripMenuItem
            // 
            this.diamondToolStripMenuItem.Name = "diamondToolStripMenuItem";
            this.diamondToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diamondToolStripMenuItem.Text = "Diamond";
            this.diamondToolStripMenuItem.Click += new System.EventHandler(this.diamondToolStripMenuItem_Click);
            // 
            // pentagonToolStripMenuItem
            // 
            this.pentagonToolStripMenuItem.Name = "pentagonToolStripMenuItem";
            this.pentagonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pentagonToolStripMenuItem.Text = "Pentagon";
            this.pentagonToolStripMenuItem.Click += new System.EventHandler(this.pentagonToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transformToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.imageToolStripMenuItem.Text = "Edit";
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.transformToolStripMenuItem.Text = "Transform";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.canvas1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 470);
            this.panel2.TabIndex = 2;
            // 
            // canvas1
            // 
            this.canvas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas1.Image = ((System.Drawing.Image)(resources.GetObject("canvas1.Image")));
            this.canvas1.IsDrawing = false;
            this.canvas1.Location = new System.Drawing.Point(112, -3);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(796, 511);
            this.canvas1.TabIndex = 0;
            this.canvas1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.noShapeRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.squareRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.circleRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.triangleRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.diamondRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.rTriangleRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.radioButton6);
            this.flowLayoutPanel1.Controls.Add(this.pentagonRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.hepatagonRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.radioButton7);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(102, 387);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.MaximumSize = new System.Drawing.Size(95, 13);
            this.panel5.MinimumSize = new System.Drawing.Size(95, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 13);
            this.panel5.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "   Basic Shapes     ";
            // 
            // noShapeRadioButton
            // 
            this.noShapeRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.noShapeRadioButton.AutoSize = true;
            this.noShapeRadioButton.BackColor = System.Drawing.Color.White;
            this.noShapeRadioButton.Checked = true;
            this.noShapeRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.noShapeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noShapeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noShapeRadioButton.Image = global::GraphProg.Properties.Resources.Template1;
            this.noShapeRadioButton.Location = new System.Drawing.Point(3, 37);
            this.noShapeRadioButton.Name = "noShapeRadioButton";
            this.noShapeRadioButton.Size = new System.Drawing.Size(44, 43);
            this.noShapeRadioButton.TabIndex = 1;
            this.noShapeRadioButton.TabStop = true;
            this.noShapeRadioButton.Text = "None";
            this.noShapeRadioButton.UseVisualStyleBackColor = false;
            this.noShapeRadioButton.Click += new System.EventHandler(this.noShapeToolStripMenuItem_Click);
            // 
            // squareRadioButton
            // 
            this.squareRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.squareRadioButton.AutoSize = true;
            this.squareRadioButton.BackColor = System.Drawing.Color.White;
            this.squareRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.squareRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareRadioButton.Image = global::GraphProg.Properties.Resources.Square;
            this.squareRadioButton.Location = new System.Drawing.Point(53, 37);
            this.squareRadioButton.Name = "squareRadioButton";
            this.squareRadioButton.Size = new System.Drawing.Size(43, 43);
            this.squareRadioButton.TabIndex = 2;
            this.squareRadioButton.Text = "    ";
            this.squareRadioButton.UseVisualStyleBackColor = false;
            this.squareRadioButton.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // circleRadioButton
            // 
            this.circleRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.circleRadioButton.AutoSize = true;
            this.circleRadioButton.BackColor = System.Drawing.Color.White;
            this.circleRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.circleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleRadioButton.Image = global::GraphProg.Properties.Resources.Circle;
            this.circleRadioButton.Location = new System.Drawing.Point(3, 86);
            this.circleRadioButton.Name = "circleRadioButton";
            this.circleRadioButton.Size = new System.Drawing.Size(43, 43);
            this.circleRadioButton.TabIndex = 3;
            this.circleRadioButton.Text = "    ";
            this.circleRadioButton.UseVisualStyleBackColor = false;
            this.circleRadioButton.CheckedChanged += new System.EventHandler(this.circleToolStripMenuItem_Click);
            this.circleRadioButton.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // triangleRadioButton
            // 
            this.triangleRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.triangleRadioButton.AutoSize = true;
            this.triangleRadioButton.BackColor = System.Drawing.Color.White;
            this.triangleRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.triangleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleRadioButton.Image = global::GraphProg.Properties.Resources.Triangle;
            this.triangleRadioButton.Location = new System.Drawing.Point(52, 86);
            this.triangleRadioButton.Name = "triangleRadioButton";
            this.triangleRadioButton.Size = new System.Drawing.Size(43, 43);
            this.triangleRadioButton.TabIndex = 4;
            this.triangleRadioButton.Text = "    ";
            this.triangleRadioButton.UseVisualStyleBackColor = false;
            this.triangleRadioButton.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(3, 135);
            this.panel4.MaximumSize = new System.Drawing.Size(95, 13);
            this.panel4.MinimumSize = new System.Drawing.Size(95, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(95, 13);
            this.panel4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "   Other Shapes";
            // 
            // diamondRadioButton
            // 
            this.diamondRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.diamondRadioButton.AutoSize = true;
            this.diamondRadioButton.BackColor = System.Drawing.Color.White;
            this.diamondRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.diamondRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diamondRadioButton.Image = global::GraphProg.Properties.Resources.Diamond;
            this.diamondRadioButton.Location = new System.Drawing.Point(3, 169);
            this.diamondRadioButton.Name = "diamondRadioButton";
            this.diamondRadioButton.Size = new System.Drawing.Size(43, 43);
            this.diamondRadioButton.TabIndex = 2;
            this.diamondRadioButton.TabStop = true;
            this.diamondRadioButton.Text = "    ";
            this.diamondRadioButton.UseVisualStyleBackColor = false;
            this.diamondRadioButton.Click += new System.EventHandler(this.diamondToolStripMenuItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Image = global::GraphProg.Properties.Resources._6Star;
            this.radioButton1.Location = new System.Drawing.Point(52, 169);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 43);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "    ";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // rTriangleRadioButton
            // 
            this.rTriangleRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rTriangleRadioButton.AutoSize = true;
            this.rTriangleRadioButton.BackColor = System.Drawing.Color.White;
            this.rTriangleRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.rTriangleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rTriangleRadioButton.Image = global::GraphProg.Properties.Resources.rTriangle;
            this.rTriangleRadioButton.Location = new System.Drawing.Point(3, 218);
            this.rTriangleRadioButton.Name = "rTriangleRadioButton";
            this.rTriangleRadioButton.Size = new System.Drawing.Size(43, 43);
            this.rTriangleRadioButton.TabIndex = 1;
            this.rTriangleRadioButton.TabStop = true;
            this.rTriangleRadioButton.Text = "    ";
            this.rTriangleRadioButton.UseVisualStyleBackColor = false;
            this.rTriangleRadioButton.Click += new System.EventHandler(this.rightangledTriangleToolStripMenuItem_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.White;
            this.radioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton6.Image = global::GraphProg.Properties.Resources.Star;
            this.radioButton6.Location = new System.Drawing.Point(52, 218);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(43, 43);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "    ";
            this.radioButton6.UseVisualStyleBackColor = false;
            // 
            // pentagonRadioButton
            // 
            this.pentagonRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pentagonRadioButton.AutoSize = true;
            this.pentagonRadioButton.BackColor = System.Drawing.Color.White;
            this.pentagonRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.pentagonRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pentagonRadioButton.Image = global::GraphProg.Properties.Resources.Pentagon;
            this.pentagonRadioButton.Location = new System.Drawing.Point(3, 267);
            this.pentagonRadioButton.Name = "pentagonRadioButton";
            this.pentagonRadioButton.Size = new System.Drawing.Size(43, 43);
            this.pentagonRadioButton.TabIndex = 5;
            this.pentagonRadioButton.TabStop = true;
            this.pentagonRadioButton.Text = "    ";
            this.pentagonRadioButton.UseVisualStyleBackColor = false;
            this.pentagonRadioButton.Click += new System.EventHandler(this.pentagonToolStripMenuItem_Click);
            // 
            // hepatagonRadioButton
            // 
            this.hepatagonRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.hepatagonRadioButton.AutoSize = true;
            this.hepatagonRadioButton.BackColor = System.Drawing.Color.White;
            this.hepatagonRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.hepatagonRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hepatagonRadioButton.Image = global::GraphProg.Properties.Resources.Heptagon;
            this.hepatagonRadioButton.Location = new System.Drawing.Point(52, 267);
            this.hepatagonRadioButton.Name = "hepatagonRadioButton";
            this.hepatagonRadioButton.Size = new System.Drawing.Size(43, 43);
            this.hepatagonRadioButton.TabIndex = 6;
            this.hepatagonRadioButton.TabStop = true;
            this.hepatagonRadioButton.Text = "    ";
            this.hepatagonRadioButton.UseVisualStyleBackColor = false;
            this.hepatagonRadioButton.Click += new System.EventHandler(this.heptagonToolStripMenuItem_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton7.AutoSize = true;
            this.radioButton7.BackColor = System.Drawing.Color.White;
            this.radioButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton7.Image = global::GraphProg.Properties.Resources.Octagon;
            this.radioButton7.Location = new System.Drawing.Point(3, 316);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(43, 43);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "    ";
            this.radioButton7.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(3, 365);
            this.panel3.MaximumSize = new System.Drawing.Size(95, 13);
            this.panel3.MinimumSize = new System.Drawing.Size(95, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 13);
            this.panel3.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(3, 384);
            this.panel6.MaximumSize = new System.Drawing.Size(95, 13);
            this.panel6.MinimumSize = new System.Drawing.Size(95, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(95, 13);
            this.panel6.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 470);
            this.panel1.TabIndex = 4;
            // 
            // heptagonToolStripMenuItem
            // 
            this.heptagonToolStripMenuItem.Name = "heptagonToolStripMenuItem";
            this.heptagonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.heptagonToolStripMenuItem.Text = "Heptagon";
            this.heptagonToolStripMenuItem.Click += new System.EventHandler(this.heptagonToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton noShapeRadioButton;
        private System.Windows.Forms.RadioButton squareRadioButton;
        private System.Windows.Forms.RadioButton circleRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rTriangleRadioButton;
        private System.Windows.Forms.RadioButton diamondRadioButton;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton triangleRadioButton;
        private System.Windows.Forms.ToolStripMenuItem noShapeToolStripMenuItem;
        private Canvas canvas1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton pentagonRadioButton;
        private System.Windows.Forms.RadioButton hepatagonRadioButton;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.ToolStripMenuItem rightangledTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem diamondToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem pentagonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heptagonToolStripMenuItem;
    }
}

