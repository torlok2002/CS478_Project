namespace TEST
{
    partial class If_WhileForm
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
            this.tlsStatementStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.txtCodeBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCond = new System.Windows.Forms.Button();
            this.label_ifwhile = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsStatementStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsStatementStrip
            // 
            this.tlsStatementStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10});
            this.tlsStatementStrip.Location = new System.Drawing.Point(0, 0);
            this.tlsStatementStrip.Name = "tlsStatementStrip";
            this.tlsStatementStrip.Size = new System.Drawing.Size(745, 25);
            this.tlsStatementStrip.TabIndex = 3;
            this.tlsStatementStrip.Text = "tlsStatementStrip";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton5.Text = "Variable";
            this.toolStripButton5.ToolTipText = "Initialize a Variable\r\n(Ctrl+V)";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(74, 22);
            this.toolStripButton6.Text = "Assignment";
            this.toolStripButton6.ToolTipText = "Assign a variable the result of an expression\r\n(Ctrl+A)";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "If";
            this.toolStripButton7.ToolTipText = "Execute statements if a conditional is met\r\n(Ctrl+F)";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(41, 22);
            this.toolStripButton8.Text = "While";
            this.toolStripButton8.ToolTipText = "Continue to execute statements until a conditional is met.\r\n(Ctrl+W)";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton9.Text = "Output";
            this.toolStripButton9.ToolTipText = "Output to user\r\n(Ctrl+O)";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton10.Text = "Input";
            this.toolStripButton10.ToolTipText = "Prompt user to input a value and assign it to a variable\r\n(Ctrl+I)";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // txtCodeBox
            // 
            this.txtCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCodeBox.Location = new System.Drawing.Point(0, 0);
            this.txtCodeBox.Name = "txtCodeBox";
            this.txtCodeBox.ReadOnly = true;
            this.txtCodeBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtCodeBox.Size = new System.Drawing.Size(745, 150);
            this.txtCodeBox.TabIndex = 4;
            this.txtCodeBox.TabStop = false;
            this.txtCodeBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.buttonAccept);
            this.panel1.Controls.Add(this.txtCodeBox);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 175);
            this.panel1.TabIndex = 5;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(667, 127);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCond
            // 
            this.buttonCond.Location = new System.Drawing.Point(271, 53);
            this.buttonCond.Name = "buttonCond";
            this.buttonCond.Size = new System.Drawing.Size(129, 23);
            this.buttonCond.TabIndex = 0;
            this.buttonCond.Text = "Define Conditional";
            this.buttonCond.UseVisualStyleBackColor = true;
            this.buttonCond.Click += new System.EventHandler(this.buttonCond_Click);
            // 
            // label_ifwhile
            // 
            this.label_ifwhile.AutoSize = true;
            this.label_ifwhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ifwhile.Location = new System.Drawing.Point(12, 37);
            this.label_ifwhile.Name = "label_ifwhile";
            this.label_ifwhile.Size = new System.Drawing.Size(46, 15);
            this.label_ifwhile.TabIndex = 7;
            this.label_ifwhile.Text = "if-while";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Do:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 153);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // If_WhileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_ifwhile);
            this.Controls.Add(this.buttonCond);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlsStatementStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "If_WhileForm";
            this.Text = "Statements to Execute";
            this.tlsStatementStrip.ResumeLayout(false);
            this.tlsStatementStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsStatementStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.RichTextBox txtCodeBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCond;
        private System.Windows.Forms.Label label_ifwhile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    }
}