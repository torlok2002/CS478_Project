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
    public partial class AssignmentForm : Form
    {
        //fields

        public string to
        {
            get { return comboBox2.Text; }
            set { comboBox2.Text = to; }
        }

        public string expressString
        {
            get { return express.ToString(); }
            set { comboBox1.Text = expressString; }
        }
        public Expression express;
        string[] existvarlist;
        
        //constructor
        public AssignmentForm(string[] ExistVarList)
        {
            InitializeComponent();
            foreach (string str in ExistVarList)
            {
                this.comboBox1.Items.Add(str);
                this.comboBox2.Items.Add(str);
            }
            this.AcceptButton = buttonAccept;
            this.existvarlist = ExistVarList;
            //express = new Expression("");
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            to = comboBox2.Text;
            expressString = express.ToString();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "") buttonAccept.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "") buttonAccept.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if( checkBox1.Checked == true)
            {
                comboBox1.Text = "(Expression)";
                comboBox1.Enabled = false; 
                NewExpressionForm expform = new NewExpressionForm(existvarlist);
                expform.ShowDialog();
                express = expform.expression;
                
            }
            else 
            {
                comboBox1.Text = "";
                comboBox1.Enabled = true;
            }
        }
    }
}
