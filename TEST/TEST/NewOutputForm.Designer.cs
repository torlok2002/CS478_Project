﻿namespace TEST
{
    partial class NewOutputForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonVar = new System.Windows.Forms.RadioButton();
            this.radioButtonStr = new System.Windows.Forms.RadioButton();
            this.textBoxStr = new System.Windows.Forms.TextBox();
            this.radioButtonExp = new System.Windows.Forms.RadioButton();
            this.labelStr = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonExp);
            this.groupBox1.Controls.Add(this.radioButtonStr);
            this.groupBox1.Controls.Add(this.radioButtonVar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Type";
            // 
            // radioButtonVar
            // 
            this.radioButtonVar.AutoSize = true;
            this.radioButtonVar.Location = new System.Drawing.Point(6, 42);
            this.radioButtonVar.Name = "radioButtonVar";
            this.radioButtonVar.Size = new System.Drawing.Size(63, 17);
            this.radioButtonVar.TabIndex = 1;
            this.radioButtonVar.TabStop = true;
            this.radioButtonVar.Text = "Variable";
            this.radioButtonVar.UseVisualStyleBackColor = true;
            this.radioButtonVar.Visible = false;
            // 
            // radioButtonStr
            // 
            this.radioButtonStr.AutoSize = true;
            this.radioButtonStr.Location = new System.Drawing.Point(7, 19);
            this.radioButtonStr.Name = "radioButtonStr";
            this.radioButtonStr.Size = new System.Drawing.Size(52, 17);
            this.radioButtonStr.TabIndex = 0;
            this.radioButtonStr.TabStop = true;
            this.radioButtonStr.Text = "String";
            this.radioButtonStr.UseVisualStyleBackColor = true;
            this.radioButtonStr.CheckedChanged += new System.EventHandler(this.radioButtonStr_CheckedChanged);
            // 
            // textBoxStr
            // 
            this.textBoxStr.Location = new System.Drawing.Point(156, 31);
            this.textBoxStr.Name = "textBoxStr";
            this.textBoxStr.Size = new System.Drawing.Size(216, 20);
            this.textBoxStr.TabIndex = 1;
            this.textBoxStr.TextChanged += new System.EventHandler(this.textBoxStr_TextChanged);
            // 
            // radioButtonExp
            // 
            this.radioButtonExp.AutoSize = true;
            this.radioButtonExp.Location = new System.Drawing.Point(6, 65);
            this.radioButtonExp.Name = "radioButtonExp";
            this.radioButtonExp.Size = new System.Drawing.Size(76, 17);
            this.radioButtonExp.TabIndex = 2;
            this.radioButtonExp.TabStop = true;
            this.radioButtonExp.Text = "Expression";
            this.radioButtonExp.UseVisualStyleBackColor = true;
            this.radioButtonExp.Visible = false;
            // 
            // labelStr
            // 
            this.labelStr.AutoSize = true;
            this.labelStr.Location = new System.Drawing.Point(153, 15);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(95, 13);
            this.labelStr.TabIndex = 2;
            this.labelStr.Text = "Message to output";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Enabled = false;
            this.buttonAccept.Location = new System.Drawing.Point(304, 84);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // NewOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 112);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.labelStr);
            this.Controls.Add(this.textBoxStr);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewOutputForm";
            this.Text = "Text to Output";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonExp;
        private System.Windows.Forms.RadioButton radioButtonStr;
        private System.Windows.Forms.RadioButton radioButtonVar;
        private System.Windows.Forms.TextBox textBoxStr;
        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.Button buttonAccept;
    }
}