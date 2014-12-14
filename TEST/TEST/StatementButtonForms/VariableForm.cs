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
    public partial class VariableForm : Form
    {
        public string name
        {
            get { return textBox1.Text; }
            set{}
        }

        public int type
        {
            get { return temptype; }
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
        private string[,] ExistingVarList;
        private Variable varin;
        private int temptype;
        private string[,] varlist;
        

        //constructor
        public VariableForm(string[,] ExistingVarList)
        {
            varlist = ExistingVarList;
            InitializeComponent();
            
            this.AcceptButton = button1;
            this.radioButton1.Checked = true;
            this.temptype = 1;

        }
        //constructor to modify existing statement
        public VariableForm(string[,] ExistingVarList, VarInitStatement varin)
        {
            varlist = ExistingVarList;
            InitializeComponent();
            this.ExistingVarList = ExistingVarList;
            this.DeleteButton.Visible = true;
            this.varin = varin.GetVar();
            this.textBox1.Text = varin.GetVar().getName;
            if (varin.GetVar().getType() == "int") { this.radioButton1.Checked = true; }
            else if (varin.GetVar().getType() == "char") { this.radioButton2.Checked = true; }
            else { this.radioButton3.Checked = true; }
            this.button1.Enabled = true;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.temptype = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.temptype = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.temptype = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string[] varnames = new string[varlist.GetLength(0)];
            for (int i = 0; i < varlist.GetLength(0); i++)
            {
                varnames[i] = varlist[i, 0];
            }
            if (varnames.Contains(this.textBox1.Text))
            {
                toolStripStatusLabel1.Text = "Name already defined";
            }
            else if (!String.IsNullOrEmpty(textBox1.Text) && !Char.IsLetter(textBox1.Text[0]))
            {
                toolStripStatusLabel1.Text = "Name must start with a letter";
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z0-9_]*$"))
            {
                toolStripStatusLabel1.Text = "Name cannot contain special characters";
            }
            else //variable name is valid
            {
                button1.Enabled = true;
                toolStripStatusLabel1.Text = "";
            }
            statusStrip1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                toolStripStatusLabel1.Text = "No variable name entered";
                this.button1.Enabled = false;
            }           
            
            else 
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.boolCancel = false;
                this.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.boolDelete = true;
            this.Close();
        }
    }
}
