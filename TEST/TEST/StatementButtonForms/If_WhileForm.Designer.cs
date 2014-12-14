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
            this.AssignButton = new System.Windows.Forms.ToolStripButton();
            this.IfButton = new System.Windows.Forms.ToolStripButton();
            this.WhileButton = new System.Windows.Forms.ToolStripButton();
            this.OutputButton = new System.Windows.Forms.ToolStripButton();
            this.InputButton = new System.Windows.Forms.ToolStripButton();
            this.txtCodeBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCond = new System.Windows.Forms.Button();
            this.label_ifwhile = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tlsStatementStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsStatementStrip
            // 
            this.tlsStatementStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.AssignButton,
            this.IfButton,
            this.WhileButton,
            this.OutputButton,
            this.InputButton});
            this.tlsStatementStrip.Location = new System.Drawing.Point(0, 0);
            this.tlsStatementStrip.Name = "tlsStatementStrip";
            this.tlsStatementStrip.Size = new System.Drawing.Size(745, 25);
            this.tlsStatementStrip.TabIndex = 3;
            this.tlsStatementStrip.Text = "tlsStatementStrip";
            this.tlsStatementStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlsStatementStrip_ItemClicked);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton5.Text = "Variable";
            this.toolStripButton5.ToolTipText = "Initialize a Variable\r\n(Ctrl+V)";
            this.toolStripButton5.Visible = false;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // AssignButton
            // 
            this.AssignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AssignButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(74, 22);
            this.AssignButton.Text = "Assignment";
            this.AssignButton.ToolTipText = "Assign a variable the result of an expression\r\n(Ctrl+A)";
            this.AssignButton.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // IfButton
            // 
            this.IfButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.IfButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IfButton.Name = "IfButton";
            this.IfButton.Size = new System.Drawing.Size(23, 22);
            this.IfButton.Text = "If";
            this.IfButton.ToolTipText = "Execute statements if a conditional is met\r\n(Ctrl+F)";
            this.IfButton.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // WhileButton
            // 
            this.WhileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WhileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WhileButton.Name = "WhileButton";
            this.WhileButton.Size = new System.Drawing.Size(41, 22);
            this.WhileButton.Text = "While";
            this.WhileButton.ToolTipText = "Continue to execute statements until a conditional is met.\r\n(Ctrl+W)";
            this.WhileButton.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OutputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(49, 22);
            this.OutputButton.Text = "Output";
            this.OutputButton.ToolTipText = "Output to user\r\n(Ctrl+O)";
            this.OutputButton.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // InputButton
            // 
            this.InputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(39, 22);
            this.InputButton.Text = "Input";
            this.InputButton.ToolTipText = "Prompt user to input a value and assign it to a variable\r\n(Ctrl+I)";
            this.InputButton.Click += new System.EventHandler(this.toolStripButton10_Click);
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
            this.txtCodeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCodeBox_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.buttonAccept);
            this.panel1.Controls.Add(this.txtCodeBox);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 175);
            this.panel1.TabIndex = 5;
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
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(586, 127);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
        private System.Windows.Forms.ToolStripButton AssignButton;
        private System.Windows.Forms.ToolStripButton IfButton;
        private System.Windows.Forms.ToolStripButton WhileButton;
        private System.Windows.Forms.ToolStripButton OutputButton;
        private System.Windows.Forms.ToolStripButton InputButton;
        private System.Windows.Forms.RichTextBox txtCodeBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCond;
        private System.Windows.Forms.Label label_ifwhile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button DeleteButton;

    }
}