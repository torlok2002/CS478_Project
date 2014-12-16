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
    public partial class AssignmentForm : Form
    {
        //fields
        private bool boolDelete = false;
        private bool boolCancel = true;

        public Expression express;
        string[,] existvarlist;
        private AssignStatement statIn;

        //constructor
        public AssignmentForm(string[,] ExistVarList)
        {
            InitializeComponent();
            for (int i = 0; i < ExistVarList.GetLength(0); i++)
            {
                this.comboBox1.Items.Add(ExistVarList[i, 0]);
                this.comboBox2.Items.Add(ExistVarList[i, 0]);
            }
            this.AcceptButton = buttonAccept;
            this.existvarlist = ExistVarList;
            //express = new Expression("");
            
        }

        //constructor to modify an existing statement
        public AssignmentForm(string[,] ExistingVarList, AssignStatement statIn)
        {
            InitializeComponent();
            this.DeleteButton.Visible = true;
            for (int i = 0; i < ExistingVarList.GetLength(0); i++)
            {
                this.comboBox1.Items.Add(ExistingVarList[i, 0]);
                this.comboBox2.Items.Add(ExistingVarList[i, 0]);
            }
            this.existvarlist = ExistingVarList;
            this.statIn = statIn;
            this.comboBox1.Text = statIn.express;
            this.comboBox2.Text = statIn.assignTo;

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            to = comboBox2.Text;

            if (checkBox1.Checked == false)
            {
                expressString = comboBox1.Text;
            }
            else
            {
                expressString = express.ToString();
            }
            this.boolCancel = false;
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
                ExpressionForm expform = new ExpressionForm(existvarlist);
                expform.ShowDialog();
                express = expform.expression;
                
            }
            else 
            {
                comboBox1.Text = "";
                comboBox1.Enabled = true;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.boolDelete = true;
            this.Close();
        }
        public string to
        {
            get { return comboBox2.Text; }
            set { comboBox2.Text = to; }
        }

        public string expressString
        {
            get 
            {
                if (checkBox1.Checked == false) { return comboBox1.Text; }
                else { return express.ToString(); }
            }
            set { comboBox1.Text = expressString; }
        }
        public bool Canceled
        {
            get
            {
                return boolCancel;
            }
        }
        public bool Deleted
        {
            get
            {
                return boolDelete;
            }
        }
    }
}
