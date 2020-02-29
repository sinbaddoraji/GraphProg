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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noShapeRadioButton = new System.Windows.Forms.RadioButton();
            this.selectRadioButton = new System.Windows.Forms.RadioButton();
            this.squareRadioButton = new System.Windows.Forms.RadioButton();
            this.circleRadioButton = new System.Windows.Forms.RadioButton();
            this.triangleRadioButton = new System.Windows.Forms.RadioButton();
            this.diamondRadioButton = new System.Windows.Forms.RadioButton();
            this.rTriangleRadioButton = new System.Windows.Forms.RadioButton();
            this.TrapezoidRadioButton = new System.Windows.Forms.RadioButton();
            this.pentagonRadioButton = new System.Windows.Forms.RadioButton();
            this.hexagonRadioButton = new System.Windows.Forms.RadioButton();
            this.heptagonRadioButton = new System.Windows.Forms.RadioButton();
            this.octagonRadioButton = new System.Windows.Forms.RadioButton();
            this.varPolygonRadioButton = new System.Windows.Forms.RadioButton();
            this.threeRadioButton = new System.Windows.Forms.RadioButton();
            this.fourRadioButton = new System.Windows.Forms.RadioButton();
            this.fiveStarRadioButton = new System.Windows.Forms.RadioButton();
            this.SixRadioButton = new System.Windows.Forms.RadioButton();
            this.VarStarRadioButton = new System.Windows.Forms.RadioButton();
            this.canvas1 = new GraphProg.Canvas();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightangledTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heptagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapezoidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableSidedPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threePointStarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourPointStarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fivePointStarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sixPointedStarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablePointedStarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).BeginInit();
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
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noShapeToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.triangleToolStripMenuItem,
            this.rightangledTriangleToolStripMenuItem,
            this.diamondToolStripMenuItem,
            this.toolStripSeparator1,
            this.pentagonToolStripMenuItem,
            this.hexagonToolStripMenuItem,
            this.heptagonToolStripMenuItem,
            this.trapezoidToolStripMenuItem,
            this.octagonToolStripMenuItem,
            this.variableSidedPolygonToolStripMenuItem,
            this.toolStripSeparator2,
            this.threePointStarToolStripMenuItem,
            this.fourPointStarToolStripMenuItem,
            this.fivePointStarToolStripMenuItem,
            this.sixPointedStarToolStripMenuItem,
            this.variablePointedStarToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // noShapeToolStripMenuItem
            // 
            this.noShapeToolStripMenuItem.Checked = true;
            this.noShapeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noShapeToolStripMenuItem.Name = "noShapeToolStripMenuItem";
            this.noShapeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.noShapeToolStripMenuItem.Text = "No Shape";
            this.noShapeToolStripMenuItem.Click += new System.EventHandler(this.noShapeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
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
            this.panel2.Size = new System.Drawing.Size(800, 604);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.noShapeRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.selectRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.squareRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.circleRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.triangleRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.diamondRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.rTriangleRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.TrapezoidRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.pentagonRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.hexagonRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.heptagonRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.octagonRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.varPolygonRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.threeRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.fourRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.fiveStarRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.SixRadioButton);
            this.flowLayoutPanel1.Controls.Add(this.VarStarRadioButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(102, 592);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(95, 39);
            this.panel6.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Shape settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(3, 48);
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
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "    Basic Shapes     ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(3, 278);
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
            this.label2.Location = new System.Drawing.Point(3, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "       Polygons";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(3, 459);
            this.panel3.MaximumSize = new System.Drawing.Size(95, 13);
            this.panel3.MinimumSize = new System.Drawing.Size(95, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 13);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "          Stars";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 604);
            this.panel1.TabIndex = 4;
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
            this.noShapeRadioButton.Location = new System.Drawing.Point(3, 82);
            this.noShapeRadioButton.Name = "noShapeRadioButton";
            this.noShapeRadioButton.Size = new System.Drawing.Size(44, 43);
            this.noShapeRadioButton.TabIndex = 1;
            this.noShapeRadioButton.TabStop = true;
            this.noShapeRadioButton.Tag = "No Shape";
            this.noShapeRadioButton.Text = "None";
            this.noShapeRadioButton.UseVisualStyleBackColor = false;
            this.noShapeRadioButton.Click += new System.EventHandler(this.noShapeToolStripMenuItem_Click);
            // 
            // selectRadioButton
            // 
            this.selectRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectRadioButton.AutoSize = true;
            this.selectRadioButton.BackColor = System.Drawing.Color.White;
            this.selectRadioButton.Checked = true;
            this.selectRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.selectRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRadioButton.Image = global::GraphProg.Properties.Resources.Hand_Touch_2_icon;
            this.selectRadioButton.Location = new System.Drawing.Point(53, 82);
            this.selectRadioButton.Name = "selectRadioButton";
            this.selectRadioButton.Size = new System.Drawing.Size(40, 40);
            this.selectRadioButton.TabIndex = 21;
            this.selectRadioButton.TabStop = true;
            this.selectRadioButton.Tag = "Select";
            this.selectRadioButton.UseVisualStyleBackColor = false;
            this.selectRadioButton.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // squareRadioButton
            // 
            this.squareRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.squareRadioButton.AutoSize = true;
            this.squareRadioButton.BackColor = System.Drawing.Color.White;
            this.squareRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.squareRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareRadioButton.Image = global::GraphProg.Properties.Resources.Square;
            this.squareRadioButton.Location = new System.Drawing.Point(3, 131);
            this.squareRadioButton.Name = "squareRadioButton";
            this.squareRadioButton.Size = new System.Drawing.Size(43, 43);
            this.squareRadioButton.TabIndex = 2;
            this.squareRadioButton.Tag = "Square";
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
            this.circleRadioButton.Location = new System.Drawing.Point(52, 131);
            this.circleRadioButton.Name = "circleRadioButton";
            this.circleRadioButton.Size = new System.Drawing.Size(43, 43);
            this.circleRadioButton.TabIndex = 3;
            this.circleRadioButton.Tag = "Circle";
            this.circleRadioButton.Text = "    ";
            this.circleRadioButton.UseVisualStyleBackColor = false;
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
            this.triangleRadioButton.Location = new System.Drawing.Point(3, 180);
            this.triangleRadioButton.Name = "triangleRadioButton";
            this.triangleRadioButton.Size = new System.Drawing.Size(43, 43);
            this.triangleRadioButton.TabIndex = 4;
            this.triangleRadioButton.Tag = "Triangle";
            this.triangleRadioButton.Text = "    ";
            this.triangleRadioButton.UseVisualStyleBackColor = false;
            this.triangleRadioButton.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // diamondRadioButton
            // 
            this.diamondRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.diamondRadioButton.AutoSize = true;
            this.diamondRadioButton.BackColor = System.Drawing.Color.White;
            this.diamondRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.diamondRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diamondRadioButton.Image = global::GraphProg.Properties.Resources.Diamond;
            this.diamondRadioButton.Location = new System.Drawing.Point(52, 180);
            this.diamondRadioButton.Name = "diamondRadioButton";
            this.diamondRadioButton.Size = new System.Drawing.Size(43, 43);
            this.diamondRadioButton.TabIndex = 2;
            this.diamondRadioButton.TabStop = true;
            this.diamondRadioButton.Tag = "Diamond";
            this.diamondRadioButton.Text = "    ";
            this.diamondRadioButton.UseVisualStyleBackColor = false;
            this.diamondRadioButton.Click += new System.EventHandler(this.diamondToolStripMenuItem_Click);
            // 
            // rTriangleRadioButton
            // 
            this.rTriangleRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rTriangleRadioButton.AutoSize = true;
            this.rTriangleRadioButton.BackColor = System.Drawing.Color.White;
            this.rTriangleRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.rTriangleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rTriangleRadioButton.Image = global::GraphProg.Properties.Resources.rTriangle;
            this.rTriangleRadioButton.Location = new System.Drawing.Point(3, 229);
            this.rTriangleRadioButton.Name = "rTriangleRadioButton";
            this.rTriangleRadioButton.Size = new System.Drawing.Size(43, 43);
            this.rTriangleRadioButton.TabIndex = 1;
            this.rTriangleRadioButton.TabStop = true;
            this.rTriangleRadioButton.Tag = "Right angled triangle";
            this.rTriangleRadioButton.Text = "    ";
            this.rTriangleRadioButton.UseVisualStyleBackColor = false;
            this.rTriangleRadioButton.Click += new System.EventHandler(this.rightangledTriangleToolStripMenuItem_Click);
            // 
            // TrapezoidRadioButton
            // 
            this.TrapezoidRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.TrapezoidRadioButton.AutoSize = true;
            this.TrapezoidRadioButton.BackColor = System.Drawing.Color.White;
            this.TrapezoidRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.TrapezoidRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrapezoidRadioButton.Image = global::GraphProg.Properties.Resources.Trapezoid;
            this.TrapezoidRadioButton.Location = new System.Drawing.Point(3, 312);
            this.TrapezoidRadioButton.Name = "TrapezoidRadioButton";
            this.TrapezoidRadioButton.Size = new System.Drawing.Size(43, 43);
            this.TrapezoidRadioButton.TabIndex = 3;
            this.TrapezoidRadioButton.TabStop = true;
            this.TrapezoidRadioButton.Tag = "Trapezoid";
            this.TrapezoidRadioButton.Text = "    ";
            this.TrapezoidRadioButton.UseVisualStyleBackColor = false;
            this.TrapezoidRadioButton.Click += new System.EventHandler(this.trapezoidToolStripMenuItem_Click);
            // 
            // pentagonRadioButton
            // 
            this.pentagonRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pentagonRadioButton.AutoSize = true;
            this.pentagonRadioButton.BackColor = System.Drawing.Color.White;
            this.pentagonRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.pentagonRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pentagonRadioButton.Image = global::GraphProg.Properties.Resources.Pentagon;
            this.pentagonRadioButton.Location = new System.Drawing.Point(52, 312);
            this.pentagonRadioButton.Name = "pentagonRadioButton";
            this.pentagonRadioButton.Size = new System.Drawing.Size(43, 43);
            this.pentagonRadioButton.TabIndex = 5;
            this.pentagonRadioButton.TabStop = true;
            this.pentagonRadioButton.Tag = "Pentagon";
            this.pentagonRadioButton.Text = "    ";
            this.pentagonRadioButton.UseVisualStyleBackColor = false;
            this.pentagonRadioButton.Click += new System.EventHandler(this.pentagonToolStripMenuItem_Click);
            // 
            // hexagonRadioButton
            // 
            this.hexagonRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.hexagonRadioButton.AutoSize = true;
            this.hexagonRadioButton.BackColor = System.Drawing.Color.White;
            this.hexagonRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.hexagonRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hexagonRadioButton.Image = global::GraphProg.Properties.Resources.Hexagon;
            this.hexagonRadioButton.Location = new System.Drawing.Point(3, 361);
            this.hexagonRadioButton.Name = "hexagonRadioButton";
            this.hexagonRadioButton.Size = new System.Drawing.Size(43, 43);
            this.hexagonRadioButton.TabIndex = 6;
            this.hexagonRadioButton.TabStop = true;
            this.hexagonRadioButton.Tag = "Hexagon";
            this.hexagonRadioButton.Text = "    ";
            this.hexagonRadioButton.UseVisualStyleBackColor = false;
            this.hexagonRadioButton.Click += new System.EventHandler(this.heptagonToolStripMenuItem_Click);
            // 
            // heptagonRadioButton
            // 
            this.heptagonRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.heptagonRadioButton.AutoSize = true;
            this.heptagonRadioButton.BackColor = System.Drawing.Color.White;
            this.heptagonRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.heptagonRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.heptagonRadioButton.Image = global::GraphProg.Properties.Resources.Heptagon;
            this.heptagonRadioButton.Location = new System.Drawing.Point(52, 361);
            this.heptagonRadioButton.Name = "heptagonRadioButton";
            this.heptagonRadioButton.Size = new System.Drawing.Size(43, 43);
            this.heptagonRadioButton.TabIndex = 13;
            this.heptagonRadioButton.TabStop = true;
            this.heptagonRadioButton.Tag = "Heptagon";
            this.heptagonRadioButton.Text = "    ";
            this.heptagonRadioButton.UseVisualStyleBackColor = false;
            this.heptagonRadioButton.Click += new System.EventHandler(this.heptagonToolStripMenuItem_Click_1);
            // 
            // octagonRadioButton
            // 
            this.octagonRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.octagonRadioButton.AutoSize = true;
            this.octagonRadioButton.BackColor = System.Drawing.Color.White;
            this.octagonRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.octagonRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.octagonRadioButton.Image = global::GraphProg.Properties.Resources.Octagon;
            this.octagonRadioButton.Location = new System.Drawing.Point(3, 410);
            this.octagonRadioButton.Name = "octagonRadioButton";
            this.octagonRadioButton.Size = new System.Drawing.Size(43, 43);
            this.octagonRadioButton.TabIndex = 7;
            this.octagonRadioButton.TabStop = true;
            this.octagonRadioButton.Tag = "Octagon";
            this.octagonRadioButton.Text = "    ";
            this.octagonRadioButton.UseVisualStyleBackColor = false;
            this.octagonRadioButton.Click += new System.EventHandler(this.octagonToolStripMenuItem_Click);
            // 
            // varPolygonRadioButton
            // 
            this.varPolygonRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.varPolygonRadioButton.AutoSize = true;
            this.varPolygonRadioButton.BackColor = System.Drawing.Color.White;
            this.varPolygonRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.varPolygonRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.varPolygonRadioButton.Image = global::GraphProg.Properties.Resources.CustomPolygon;
            this.varPolygonRadioButton.Location = new System.Drawing.Point(52, 410);
            this.varPolygonRadioButton.Name = "varPolygonRadioButton";
            this.varPolygonRadioButton.Size = new System.Drawing.Size(43, 43);
            this.varPolygonRadioButton.TabIndex = 18;
            this.varPolygonRadioButton.TabStop = true;
            this.varPolygonRadioButton.Tag = "Variable sized polygon";
            this.varPolygonRadioButton.Text = "    ";
            this.varPolygonRadioButton.UseVisualStyleBackColor = false;
            this.varPolygonRadioButton.Click += new System.EventHandler(this.varPolygonRadioButton_CheckedChanged);
            // 
            // threeRadioButton
            // 
            this.threeRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.threeRadioButton.AutoSize = true;
            this.threeRadioButton.BackColor = System.Drawing.Color.White;
            this.threeRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.threeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeRadioButton.Image = global::GraphProg.Properties.Resources._3Star;
            this.threeRadioButton.Location = new System.Drawing.Point(3, 493);
            this.threeRadioButton.Name = "threeRadioButton";
            this.threeRadioButton.Size = new System.Drawing.Size(43, 43);
            this.threeRadioButton.TabIndex = 17;
            this.threeRadioButton.TabStop = true;
            this.threeRadioButton.Tag = "3-pointed star";
            this.threeRadioButton.Text = "    ";
            this.threeRadioButton.UseVisualStyleBackColor = false;
            this.threeRadioButton.Click += new System.EventHandler(this.threePointStarToolStripMenuItem_Click);
            // 
            // fourRadioButton
            // 
            this.fourRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.fourRadioButton.AutoSize = true;
            this.fourRadioButton.BackColor = System.Drawing.Color.White;
            this.fourRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.fourRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourRadioButton.Image = global::GraphProg.Properties.Resources._4Star;
            this.fourRadioButton.Location = new System.Drawing.Point(52, 493);
            this.fourRadioButton.Name = "fourRadioButton";
            this.fourRadioButton.Size = new System.Drawing.Size(43, 43);
            this.fourRadioButton.TabIndex = 15;
            this.fourRadioButton.TabStop = true;
            this.fourRadioButton.Tag = "4-pointed star";
            this.fourRadioButton.Text = "    ";
            this.fourRadioButton.UseVisualStyleBackColor = false;
            this.fourRadioButton.Click += new System.EventHandler(this.fourPointStarToolStripMenuItem_Click);
            // 
            // fiveStarRadioButton
            // 
            this.fiveStarRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.fiveStarRadioButton.AutoSize = true;
            this.fiveStarRadioButton.BackColor = System.Drawing.Color.White;
            this.fiveStarRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.fiveStarRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveStarRadioButton.Image = global::GraphProg.Properties.Resources.Star;
            this.fiveStarRadioButton.Location = new System.Drawing.Point(3, 542);
            this.fiveStarRadioButton.Name = "fiveStarRadioButton";
            this.fiveStarRadioButton.Size = new System.Drawing.Size(43, 43);
            this.fiveStarRadioButton.TabIndex = 14;
            this.fiveStarRadioButton.TabStop = true;
            this.fiveStarRadioButton.Tag = "5-pointed star";
            this.fiveStarRadioButton.Text = "    ";
            this.fiveStarRadioButton.UseVisualStyleBackColor = false;
            this.fiveStarRadioButton.Click += new System.EventHandler(this.fivePointStarToolStripMenuItem_Click);
            // 
            // SixRadioButton
            // 
            this.SixRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SixRadioButton.AutoSize = true;
            this.SixRadioButton.BackColor = System.Drawing.Color.White;
            this.SixRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.SixRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixRadioButton.Image = global::GraphProg.Properties.Resources._6Star;
            this.SixRadioButton.Location = new System.Drawing.Point(52, 542);
            this.SixRadioButton.Name = "SixRadioButton";
            this.SixRadioButton.Size = new System.Drawing.Size(43, 43);
            this.SixRadioButton.TabIndex = 4;
            this.SixRadioButton.TabStop = true;
            this.SixRadioButton.Tag = "6-pointed star";
            this.SixRadioButton.Text = "    ";
            this.SixRadioButton.UseVisualStyleBackColor = false;
            this.SixRadioButton.Click += new System.EventHandler(this.sixPointedStarToolStripMenuItem_Click);
            // 
            // VarStarRadioButton
            // 
            this.VarStarRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.VarStarRadioButton.AutoSize = true;
            this.VarStarRadioButton.BackColor = System.Drawing.Color.White;
            this.VarStarRadioButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.VarStarRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VarStarRadioButton.Image = global::GraphProg.Properties.Resources.CustomStar;
            this.VarStarRadioButton.Location = new System.Drawing.Point(3, 591);
            this.VarStarRadioButton.Name = "VarStarRadioButton";
            this.VarStarRadioButton.Size = new System.Drawing.Size(43, 43);
            this.VarStarRadioButton.TabIndex = 19;
            this.VarStarRadioButton.TabStop = true;
            this.VarStarRadioButton.Tag = "Variable pointed star ";
            this.VarStarRadioButton.Text = "    ";
            this.VarStarRadioButton.UseVisualStyleBackColor = false;
            this.VarStarRadioButton.Click += new System.EventHandler(this.VarStarRadioButton_CheckedChanged);
            // 
            // canvas1
            // 
            this.canvas1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas1.Image = ((System.Drawing.Image)(resources.GetObject("canvas1.Image")));
            this.canvas1.IsDrawing = false;
            this.canvas1.Location = new System.Drawing.Point(107, -1);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(802, 645);
            this.canvas1.TabIndex = 0;
            this.canvas1.TabStop = false;
            this.canvas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseDown);
            this.canvas1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseUp);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Square;
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Circle;
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Triangle;
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
            // 
            // rightangledTriangleToolStripMenuItem
            // 
            this.rightangledTriangleToolStripMenuItem.Image = global::GraphProg.Properties.Resources.rTriangle;
            this.rightangledTriangleToolStripMenuItem.Name = "rightangledTriangleToolStripMenuItem";
            this.rightangledTriangleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rightangledTriangleToolStripMenuItem.Text = "Right-angled Triangle";
            this.rightangledTriangleToolStripMenuItem.Click += new System.EventHandler(this.rightangledTriangleToolStripMenuItem_Click);
            // 
            // diamondToolStripMenuItem
            // 
            this.diamondToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Diamond;
            this.diamondToolStripMenuItem.Name = "diamondToolStripMenuItem";
            this.diamondToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.diamondToolStripMenuItem.Text = "Diamond";
            this.diamondToolStripMenuItem.Click += new System.EventHandler(this.diamondToolStripMenuItem_Click);
            // 
            // pentagonToolStripMenuItem
            // 
            this.pentagonToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Pentagon;
            this.pentagonToolStripMenuItem.Name = "pentagonToolStripMenuItem";
            this.pentagonToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.pentagonToolStripMenuItem.Text = "Pentagon";
            this.pentagonToolStripMenuItem.Click += new System.EventHandler(this.pentagonToolStripMenuItem_Click);
            // 
            // hexagonToolStripMenuItem
            // 
            this.hexagonToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Hexagon;
            this.hexagonToolStripMenuItem.Name = "hexagonToolStripMenuItem";
            this.hexagonToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.hexagonToolStripMenuItem.Text = "Hexagon";
            this.hexagonToolStripMenuItem.Click += new System.EventHandler(this.heptagonToolStripMenuItem_Click);
            // 
            // heptagonToolStripMenuItem
            // 
            this.heptagonToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Heptagon;
            this.heptagonToolStripMenuItem.Name = "heptagonToolStripMenuItem";
            this.heptagonToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.heptagonToolStripMenuItem.Text = "Heptagon";
            this.heptagonToolStripMenuItem.Click += new System.EventHandler(this.heptagonToolStripMenuItem_Click_1);
            // 
            // trapezoidToolStripMenuItem
            // 
            this.trapezoidToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Trapezoid;
            this.trapezoidToolStripMenuItem.Name = "trapezoidToolStripMenuItem";
            this.trapezoidToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.trapezoidToolStripMenuItem.Text = "Trapezoid";
            this.trapezoidToolStripMenuItem.Click += new System.EventHandler(this.trapezoidToolStripMenuItem_Click);
            // 
            // octagonToolStripMenuItem
            // 
            this.octagonToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Octagon;
            this.octagonToolStripMenuItem.Name = "octagonToolStripMenuItem";
            this.octagonToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.octagonToolStripMenuItem.Text = "Octagon";
            this.octagonToolStripMenuItem.Click += new System.EventHandler(this.octagonToolStripMenuItem_Click);
            // 
            // variableSidedPolygonToolStripMenuItem
            // 
            this.variableSidedPolygonToolStripMenuItem.Image = global::GraphProg.Properties.Resources.CustomPolygon;
            this.variableSidedPolygonToolStripMenuItem.Name = "variableSidedPolygonToolStripMenuItem";
            this.variableSidedPolygonToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.variableSidedPolygonToolStripMenuItem.Text = "Variable-Sided Polygon";
            this.variableSidedPolygonToolStripMenuItem.Click += new System.EventHandler(this.varPolygonRadioButton_CheckedChanged);
            // 
            // threePointStarToolStripMenuItem
            // 
            this.threePointStarToolStripMenuItem.Image = global::GraphProg.Properties.Resources._3Star;
            this.threePointStarToolStripMenuItem.Name = "threePointStarToolStripMenuItem";
            this.threePointStarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.threePointStarToolStripMenuItem.Text = "Three-Point Star";
            this.threePointStarToolStripMenuItem.Click += new System.EventHandler(this.threePointStarToolStripMenuItem_Click);
            // 
            // fourPointStarToolStripMenuItem
            // 
            this.fourPointStarToolStripMenuItem.Image = global::GraphProg.Properties.Resources._4Star;
            this.fourPointStarToolStripMenuItem.Name = "fourPointStarToolStripMenuItem";
            this.fourPointStarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.fourPointStarToolStripMenuItem.Text = "Four-Point Star";
            this.fourPointStarToolStripMenuItem.Click += new System.EventHandler(this.fourPointStarToolStripMenuItem_Click);
            // 
            // fivePointStarToolStripMenuItem
            // 
            this.fivePointStarToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Star;
            this.fivePointStarToolStripMenuItem.Name = "fivePointStarToolStripMenuItem";
            this.fivePointStarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.fivePointStarToolStripMenuItem.Text = "Five-Point Star";
            this.fivePointStarToolStripMenuItem.Click += new System.EventHandler(this.fivePointStarToolStripMenuItem_Click);
            // 
            // sixPointedStarToolStripMenuItem
            // 
            this.sixPointedStarToolStripMenuItem.Image = global::GraphProg.Properties.Resources._6Star;
            this.sixPointedStarToolStripMenuItem.Name = "sixPointedStarToolStripMenuItem";
            this.sixPointedStarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sixPointedStarToolStripMenuItem.Text = "Six-Pointed Star";
            this.sixPointedStarToolStripMenuItem.Click += new System.EventHandler(this.sixPointedStarToolStripMenuItem_Click);
            // 
            // variablePointedStarToolStripMenuItem
            // 
            this.variablePointedStarToolStripMenuItem.Image = global::GraphProg.Properties.Resources.CustomStar;
            this.variablePointedStarToolStripMenuItem.Name = "variablePointedStarToolStripMenuItem";
            this.variablePointedStarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.variablePointedStarToolStripMenuItem.Text = "Variable-Pointed Star";
            this.variablePointedStarToolStripMenuItem.Click += new System.EventHandler(this.VarStarRadioButton_CheckedChanged);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Image = global::GraphProg.Properties.Resources.Hand_Touch_2_icon;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas1)).EndInit();
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
        private System.Windows.Forms.RadioButton TrapezoidRadioButton;
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
        private System.Windows.Forms.RadioButton SixRadioButton;
        private System.Windows.Forms.RadioButton pentagonRadioButton;
        private System.Windows.Forms.RadioButton hexagonRadioButton;
        private System.Windows.Forms.RadioButton octagonRadioButton;
        private System.Windows.Forms.ToolStripMenuItem rightangledTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem diamondToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem pentagonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexagonToolStripMenuItem;
        private System.Windows.Forms.RadioButton heptagonRadioButton;
        private System.Windows.Forms.ToolStripMenuItem heptagonToolStripMenuItem;
        private System.Windows.Forms.RadioButton fiveStarRadioButton;
        private System.Windows.Forms.ToolStripMenuItem trapezoidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octagonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fivePointStarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sixPointedStarToolStripMenuItem;
        private System.Windows.Forms.RadioButton fourRadioButton;
        private System.Windows.Forms.ToolStripMenuItem fourPointStarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton threeRadioButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem threePointStarToolStripMenuItem;
        private System.Windows.Forms.RadioButton varPolygonRadioButton;
        private System.Windows.Forms.RadioButton VarStarRadioButton;
        private System.Windows.Forms.ToolStripMenuItem variableSidedPolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variablePointedStarToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton selectRadioButton;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
    }
}

