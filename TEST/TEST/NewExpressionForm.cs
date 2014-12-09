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
    public partial class NewExpressionForm : Form
    {
        //fields
        public string left
        {
            get { return textBox1.Text; }
            set { }
        }

        public string oper
        {
            get { return comboBox1.Text; }
            set { }
        }

        public string right
        {
            get { return textBox2.Text; }
            set { }
        }

        //constructor
        public NewExpressionForm()
        {
            InitializeComponent();
            this.AcceptButton = btnAccept;
            this.CancelButton = btnCancel;
        }

        private void NewExpressionForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
        }

 
        private void btnAccept_Click(object sender, EventArgs e)
        {
            //code to return values
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.left = "";
            this.oper = "";
            this.right = "";
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //disable unused controls
            this.comboBox1.Text = "";
            this.comboBox1.Enabled = false;
            this.textBox2.Text = "";
            this.textBox2.Enabled = false;
            
            //Enable Accept button
            this.btnAccept.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //enable used controls
            this.comboBox1.Enabled = true;
            this.textBox2.Enabled = true;

            //enable Accept Button
            this.btnAccept.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.btnAccept.Enabled = true;
        }
    }
}

