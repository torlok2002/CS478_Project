namespace TEST
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRunProg = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tlsStatementStrip = new System.Windows.Forms.ToolStrip();
            this.VariableButton = new System.Windows.Forms.ToolStripButton();
            this.AssignButton = new System.Windows.Forms.ToolStripButton();
            this.IfButton = new System.Windows.Forms.ToolStripButton();
            this.WhileButton = new System.Windows.Forms.ToolStripButton();
            this.OutputButton = new System.Windows.Forms.ToolStripButton();
            this.InputButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtCodeBox = new System.Windows.Forms.RichTextBox();
            this.tvTreeDirectory = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnUp = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.txtOutputBox = new System.Windows.Forms.TextBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tlsStatementStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            this.fIleToolStripMenuItem.Click += new System.EventHandler(this.fIleToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnRunProg
            // 
            this.btnRunProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunProg.Enabled = false;
            this.btnRunProg.Location = new System.Drawing.Point(635, 1);
            this.btnRunProg.Name = "btnRunProg";
            this.btnRunProg.Size = new System.Drawing.Size(42, 23);
            this.btnRunProg.TabIndex = 1;
            this.btnRunProg.Text = "Run";
            this.btnRunProg.UseVisualStyleBackColor = true;
            this.btnRunProg.Click += new System.EventHandler(this.btnRunProg_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(677, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel1.Text = "New Program Started";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 278);
            this.textBox1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 0);
            this.textBox1.TabIndex = 4;
            // 
            // tlsStatementStrip
            // 
            this.tlsStatementStrip.Enabled = false;
            this.tlsStatementStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VariableButton,
            this.AssignButton,
            this.IfButton,
            this.WhileButton,
            this.OutputButton,
            this.InputButton});
            this.tlsStatementStrip.Location = new System.Drawing.Point(0, 24);
            this.tlsStatementStrip.Name = "tlsStatementStrip";
            this.tlsStatementStrip.Size = new System.Drawing.Size(677, 25);
            this.tlsStatementStrip.TabIndex = 2;
            this.tlsStatementStrip.Text = "tlsStatementStrip";
            // 
            // VariableButton
            // 
            this.VariableButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.VariableButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VariableButton.Name = "VariableButton";
            this.VariableButton.Size = new System.Drawing.Size(53, 22);
            this.VariableButton.Text = "Variable";
            this.VariableButton.ToolTipText = "Initialize a Variable\r\n(Ctrl+V)";
            this.VariableButton.Click += new System.EventHandler(this.VariableButton_Click);
            // 
            // AssignButton
            // 
            this.AssignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AssignButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(74, 22);
            this.AssignButton.Text = "Assignment";
            this.AssignButton.ToolTipText = "Assign a variable the result of an expression\r\n(Ctrl+A)";
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // IfButton
            // 
            this.IfButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.IfButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IfButton.Name = "IfButton";
            this.IfButton.Size = new System.Drawing.Size(23, 22);
            this.IfButton.Text = "If";
            this.IfButton.ToolTipText = "Execute statements if a conditional is met\r\n(Ctrl+F)";
            this.IfButton.Click += new System.EventHandler(this.IfButton_Click);
            // 
            // WhileButton
            // 
            this.WhileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WhileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WhileButton.Name = "WhileButton";
            this.WhileButton.Size = new System.Drawing.Size(41, 22);
            this.WhileButton.Text = "While";
            this.WhileButton.ToolTipText = "Continue to execute statements until a conditional is met.\r\n(Ctrl+W)";
            this.WhileButton.Click += new System.EventHandler(this.WhileButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OutputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(49, 22);
            this.OutputButton.Text = "Output";
            this.OutputButton.ToolTipText = "Output to user\r\n(Ctrl+O)";
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // InputButton
            // 
            this.InputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(39, 22);
            this.InputButton.Text = "Input";
            this.InputButton.ToolTipText = "Prompt user to input a value and assign it to a variable\r\n(Ctrl+I)";
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblClear);
            this.splitContainer1.Panel2.Controls.Add(this.txtOutputBox);
            this.splitContainer1.Size = new System.Drawing.Size(677, 473);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtCodeBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tvTreeDirectory);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer2.Size = new System.Drawing.Size(677, 316);
            this.splitContainer2.SplitterDistance = 519;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtCodeBox
            // 
            this.txtCodeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodeBox.Location = new System.Drawing.Point(0, 0);
            this.txtCodeBox.Name = "txtCodeBox";
            this.txtCodeBox.ReadOnly = true;
            this.txtCodeBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCodeBox.Size = new System.Drawing.Size(519, 316);
            this.txtCodeBox.TabIndex = 0;
            this.txtCodeBox.Text = "";
            this.txtCodeBox.TextChanged += new System.EventHandler(this.txtCodeBox_TextChanged);
            this.txtCodeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCodeBox_MouseDown);
            // 
            // tvTreeDirectory
            // 
            this.tvTreeDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvTreeDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTreeDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tvTreeDirectory.ImageIndex = 0;
            this.tvTreeDirectory.ImageList = this.imageList1;
            this.tvTreeDirectory.Location = new System.Drawing.Point(0, 27);
            this.tvTreeDirectory.Name = "tvTreeDirectory";
            this.tvTreeDirectory.SelectedImageIndex = 0;
            this.tvTreeDirectory.Size = new System.Drawing.Size(154, 289);
            this.tvTreeDirectory.TabIndex = 0;
            this.tvTreeDirectory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDirectory_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "file.png");
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnUp,
            this.btnHome,
            this.toolStripButton7});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(154, 27);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.Text = "toolStripButton8";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUp
            // 
            this.btnUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 24);
            this.btnUp.Text = "toolStripButton7";
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(24, 24);
            this.btnHome.Text = "toolStripButton7";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // txtOutputBox
            // 
            this.txtOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOutputBox.Location = new System.Drawing.Point(0, 0);
            this.txtOutputBox.Multiline = true;
            this.txtOutputBox.Name = "txtOutputBox";
            this.txtOutputBox.ReadOnly = true;
            this.txtOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputBox.Size = new System.Drawing.Size(677, 153);
            this.txtOutputBox.TabIndex = 0;
            this.txtOutputBox.TextChanged += new System.EventHandler(this.txtOutputBox_TextChanged);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClear.Location = new System.Drawing.Point(632, 5);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(31, 13);
            this.lblClear.TabIndex = 1;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(677, 544);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tlsStatementStrip);
            this.Controls.Add(this.btnRunProg);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "CS487 IDE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlsStatementStrip.ResumeLayout(false);
            this.tlsStatementStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnRunProg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ToolStrip tlsStatementStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox txtCodeBox;
        private System.Windows.Forms.TreeView tvTreeDirectory;
        private System.Windows.Forms.TextBox txtOutputBox;
        private System.Windows.Forms.ToolStripButton VariableButton;
        private System.Windows.Forms.ToolStripButton AssignButton;
        private System.Windows.Forms.ToolStripButton IfButton;
        private System.Windows.Forms.ToolStripButton WhileButton;
        private System.Windows.Forms.ToolStripButton OutputButton;
        private System.Windows.Forms.ToolStripButton InputButton;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnUp;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Label lblClear;

    }
}

