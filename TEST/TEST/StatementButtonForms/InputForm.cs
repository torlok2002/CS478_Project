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
    public partial class InputForm : Form
    {
        //fields
        public string VarName
        {
            get { return comboBoxVarName.Text; }
            set { }
        }

        public string message 
        {
            get { return "\"" + textBox1.Text + "\""; }
            set { } 
        }

        public InputForm(string[] ExistingVarList)
        {
            
            InitializeComponent();
            foreach (string VarName in ExistingVarList)
            {
                this.comboBoxVarName.Items.Add(VarName);
            }
            this.AcceptButton = buttonAccept;
        }

        private void comboBoxVarName_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = false;
            if (comboBoxVarName.Text != "") { this.buttonAccept.Enabled = true; }
        }


        private void buttonAccept_Click(object sender, EventArgs e)
        {
            VarName = this.comboBoxVarName.Text;
            this.Close();
        }

        
    }
}
