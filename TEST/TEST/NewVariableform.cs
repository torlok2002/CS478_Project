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
    public partial class NewVariableform : Form
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
        private int temptype;
        private bool typesetflag;
        private bool namesetflag;
        private string[] varlist;
        
        //constructor
        public NewVariableform(string[] ExistingVarList)
        {
            varlist = ExistingVarList;
            InitializeComponent();
            this.AcceptButton = button1;
            this.radioButton1.Checked = true;
            this.temptype = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            typesetflag = true;
            if (namesetflag == true)
            {
                this.button1.Enabled = true;
                this.temptype = 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            typesetflag = true;
            if (namesetflag == true)
            {
                this.button1.Enabled = true;
                this.temptype = 2;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            typesetflag = true;
            if (namesetflag == true)
            {
                this.button1.Enabled = true;
                this.temptype = 3;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            namesetflag = true;
            if (typesetflag == true && !varlist.Contains(this.textBox1.Text)) 
            {
                this.button1.Enabled = true;
                toolStripStatusLabel1.Text = "";
            }
            else if(varlist.Contains(this.textBox1.Text))
            {
                toolStripStatusLabel1.Text = "Variable already defined";
                this.button1.Enabled = false;
                namesetflag = false;
            }
            statusStrip1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                toolStripStatusLabel1.Text = "No variable name entered";
                namesetflag = false;
                this.button1.Enabled = false;
            }           
            else this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            this.radioButton3.Checked = false;
            this.Close();
        }

        private void NewVariableform_Load(object sender, EventArgs e)
        {

        }
    }
}
