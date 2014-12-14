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
        public string VarType
        {
            get { return comboBoxVarName.Text; }
            set { }
        }
        public string message 
        {
            get { return "\"" + textBox1.Text + "\""; }
            set { } 
        }
        private bool boolCancel = true;
        public bool Canceled
        {
            get
            {
                return boolCancel;
            }
        }
        private bool boolDelete = false;
        public bool Deleted
        {
            get
            {
                return boolDelete;
            }
        }
        public InputForm(string[,] ExistingVarList)
        {
            
            InitializeComponent();
            for (int i = 0; i < ExistingVarList.GetLength(0); i++)
            {
                this.comboBoxVarName.Items.Add(ExistingVarList[i,0]);
            }
        }
        //construtor for editing an existing statement
        public InputForm(string[,] ExistingVarList, InputStatement Temp)
        {
            InitializeComponent();
            for (int i = 0; i < ExistingVarList.GetLength(0); i++)
            {
                this.comboBoxVarName.Items.Add(ExistingVarList[i, 0]);
            }
            comboBoxVarName.Text = Temp.getVar();
            textBox1.Text = Temp.messageString;
            this.buttonAccept.Enabled = true;
            this.DeleteButton.Visible = true;

        }
        private void comboBoxVarName_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAccept.Enabled = false;
            if (comboBoxVarName.Text != "") { this.buttonAccept.Enabled = true; }
        }


        private void buttonAccept_Click(object sender, EventArgs e)
        {
            VarName = this.comboBoxVarName.Text;
            this.DialogResult = DialogResult.Yes;
            this.boolCancel = false;
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.boolDelete = true;
            this.Close();
        }

        
    }
}
