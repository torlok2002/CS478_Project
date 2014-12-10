namespace TEST
{
    partial class VariableSelection
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
            this.comboBoxVarName = new System.Windows.Forms.ComboBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxVarName
            // 
            this.comboBoxVarName.FormattingEnabled = true;
            this.comboBoxVarName.Location = new System.Drawing.Point(29, 30);
            this.comboBoxVarName.Name = "comboBoxVarName";
            this.comboBoxVarName.Size = new System.Drawing.Size(170, 21);
            this.comboBoxVarName.TabIndex = 0;
            this.comboBoxVarName.SelectedIndexChanged += new System.EventHandler(this.comboBoxVarName_SelectedIndexChanged);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Enabled = false;
            this.buttonAccept.Location = new System.Drawing.Point(155, 71);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(70, 22);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // VariableSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 105);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.comboBoxVarName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VariableSelection";
            this.Text = "Select Variable";
            this.Load += new System.EventHandler(this.VariableSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVarName;
        private System.Windows.Forms.Button buttonAccept;
    }
}