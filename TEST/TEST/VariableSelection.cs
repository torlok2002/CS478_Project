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
    public partial class VariableSelection : Form
    {
        //fields
        public string VarName
        {
            get { return comboBoxVarName.Text; }
            set { }
        }
        
        public VariableSelection(string[] ExistingVarList)
        {
            
            InitializeComponent();
            foreach (string VarName in ExistingVarList)
            {
                this.comboBoxVarName.Items.Add(VarName);
            }
            
            
        }

        private void comboBoxVarName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buttonAccept.Enabled = true;
        }

        private void VariableSelection_Load(object sender, EventArgs e)
        {

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            VarName = this.comboBoxVarName.Text;
            this.Close();
        }
    }
}
