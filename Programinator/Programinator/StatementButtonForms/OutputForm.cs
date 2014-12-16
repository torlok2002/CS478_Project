using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programinator
{
    public partial class NewOutputForm : Form
    {
        private bool boolCancel = true;
        private bool boolDelete = false;
        //fields
        //Constructors
        public NewOutputForm(string[,] ExistingVarList)
        {
            InitializeComponent();
            for (int i = 0; i < ExistingVarList.GetLength(0); i++)
            {
                this.comboBox1.Items.Add(ExistingVarList[i, 0]);
            }
            this.AcceptButton = buttonAccept;

        }
        //Constructor for edit form
        public NewOutputForm(string[,] ExistingVarList, OutputStatement statin)
        {
            InitializeComponent();
            for (int i = 0; i < ExistingVarList.GetLength(0); i++)
            {
                this.comboBox1.Items.Add(ExistingVarList[i, 0]);
            }
            this.AcceptButton = buttonAccept;
            this.DeleteButton.Visible = true;
            this.buttonAccept.Enabled = true;
            if (statin.getOutput().ToCharArray()[0] == '"')
            {
                this.textBoxStr.Text = statin.getOutput();
                this.textBoxStr.Enabled = true;
                this.radioButtonStr.Checked = true;
            }
            else
            {
                this.comboBox1.Text = statin.getOutput();
                this.comboBox1.Visible = true;
                this.radioButtonVar.Checked = true;
            }
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
            boolCancel = false;
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.boolDelete = true;
            this.Close();
        }
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
        public bool Deleted
        {
            get
            {
                return boolDelete;
            }
        }
        public bool Canceled
        {
            get
            {
                return boolCancel;
            }
        }
    }
}
