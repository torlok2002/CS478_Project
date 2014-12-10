using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class NewOutputForm : Form
    {
        //fields
        public string outtext
        {
            get 
            {
                if (this.radioButtonStr.Checked) { return "\"" + this.textBoxStr.Text + "\""; }
                else if (this.radioButtonVar.Checked) { return this.comboBox1.Text; }
                else return "no proper box selected";
                
            }
            set { }
        }
        
        public NewOutputForm(string[] ExistingVarList)
        {
            InitializeComponent();
            foreach (string s in ExistingVarList)
            {
                this.comboBox1.Items.Add(s);
            }
            this.AcceptButton = buttonAccept;

        }

        private void textBoxStr_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxStr.Text == "") this.buttonAccept.Enabled = false;
            else this.buttonAccept.Enabled = true;
        }

        private void radioButtonStr_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = false;
            this.comboBox1.Visible = false;
            this.textBoxStr.Enabled = true;
            this.textBoxStr.Visible = true;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonVar_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxStr.Enabled = false;
            this.textBoxStr.Visible = false;
            this.comboBox1.Enabled = true;
            this.comboBox1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "") this.buttonAccept.Enabled = false;
            else this.buttonAccept.Enabled = true;
        }
    }
}
