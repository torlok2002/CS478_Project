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
        
        public NewVariableform()
        {
            
            InitializeComponent();
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
            if (typesetflag == true) { this.button1.Enabled = true; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            this.radioButton3.Checked = false;
            this.Close();
        }
    }
}
