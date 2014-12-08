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
        public string left;
        public string oper;
        public string right;


        public NewExpressionForm()
        {
            InitializeComponent();
            left = "";
            oper = "";
            right = "";
            
        }

        private void NewExpressionForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Set controls for simple expression
            //Enable Accept button

            //return values
            left = textBox1.Text;
            oper = comboBox1.Text;
            right = textBox2.Text;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //set controls for Complex expression
            //enable Accept Button

            //enable operator and right side
            
        }
    }
}

