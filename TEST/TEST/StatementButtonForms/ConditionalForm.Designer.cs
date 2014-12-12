namespace TEST
{
    partial class ConditionalForm
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
            this.groupBoxCond = new System.Windows.Forms.GroupBox();
            this.comboBoxRight = new System.Windows.Forms.ComboBox();
            this.comboBoxLeft = new System.Windows.Forms.ComboBox();
            this.comboBoxEqual = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxCond.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCond
            // 
            this.groupBoxCond.Controls.Add(this.comboBoxRight);
            this.groupBoxCond.Controls.Add(this.comboBoxLeft);
            this.groupBoxCond.Controls.Add(this.comboBoxEqual);
            this.groupBoxCond.Location = new System.Drawing.Point(53, 12);
            this.groupBoxCond.Name = "groupBoxCond";
            this.groupBoxCond.Size = new System.Drawing.Size(146, 108);
            this.groupBoxCond.TabIndex = 0;
            this.groupBoxCond.TabStop = false;
            this.groupBoxCond.Text = "Condition";
            // 
            // comboBoxRight
            // 
            this.comboBoxRight.FormattingEnabled = true;
            this.comboBoxRight.Location = new System.Drawing.Point(6, 73);
            this.comboBoxRight.Name = "comboBoxRight";
            this.comboBoxRight.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRight.TabIndex = 2;
            this.comboBoxRight.SelectedIndexChanged += new System.EventHandler(this.comboBoxRight_SelectedIndexChanged);
            // 
            // comboBoxLeft
            // 
            this.comboBoxLeft.FormattingEnabled = true;
            this.comboBoxLeft.Location = new System.Drawing.Point(6, 19);
            this.comboBoxLeft.Name = "comboBoxLeft";
            this.comboBoxLeft.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLeft.TabIndex = 0;
            this.comboBoxLeft.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeft_SelectedIndexChanged);
            // 
            // comboBoxEqual
            // 
            this.comboBoxEqual.FormattingEnabled = true;
            this.comboBoxEqual.Items.AddRange(new object[] {
            "==",
            "!=",
            "<",
            "<=",
            ">",
            ">="});
            this.comboBoxEqual.Location = new System.Drawing.Point(6, 46);
            this.comboBoxEqual.Name = "comboBoxEqual";
            this.comboBoxEqual.Size = new System.Drawing.Size(64, 21);
            this.comboBoxEqual.TabIndex = 1;
            this.comboBoxEqual.SelectedIndexChanged += new System.EventHandler(this.comboBoxEqual_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(123, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConditionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 158);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxCond);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConditionalForm";
            this.Text = "Define Conditional";
            this.groupBoxCond.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCond;
        private System.Windows.Forms.ComboBox comboBoxRight;
        private System.Windows.Forms.ComboBox comboBoxLeft;
        private System.Windows.Forms.ComboBox comboBoxEqual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}