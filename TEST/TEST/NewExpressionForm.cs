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
            get 
            {
                if (this.checkBoxVarLeft.Checked) { return comboBoxLVar.Text; }
                else return textBox1.Text; 
            }
            set { }
        }

        public string oper
        {
            get { return comboBox2.Text; }
            set { }
        }

        public string right
        {
            get 
            {
                if (this.checkBoxVarRight.Checked) { return comboBoxRVar.Text; }
                else return textBox2.Text; 
            }
            set { }
        }

        public string varTo
        {
            get { return comboBox1.Text; }
            set {}
        }

        //constructor
        public NewExpressionForm(string[] ExistVarList)
        {
            InitializeComponent();
            this.AcceptButton = btnAccept;
            foreach (string VarName in ExistVarList)
            {
                this.comboBoxLVar.Items.Add(VarName);
                this.comboBoxRVar.Items.Add(VarName);
                this.comboBox1.Items.Add(VarName);
            }


        }

        private void NewExpressionForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox2.Text = "";
            textBox2.Text = "";
        }

 
        private void btnAccept_Click(object sender, EventArgs e)
        {
            //code and return values
            this.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //disable unused controls
            this.comboBox2.Text = "";
            this.comboBox2.Enabled = false;
            this.comboBoxRVar.Enabled = false;
            this.textBox2.Text = "";
            this.textBox2.Enabled = false;
            this.checkBoxVarRight.Enabled = false;
            this.checkBoxVarRight.Checked = false;

            this.checkAcceptButtonEnable();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //enable used controls
            this.comboBox2.Enabled = true;
            this.textBox2.Enabled = true;
            this.checkBoxVarRight.Enabled = true;
            //this.checkBoxVarLeft.Enabled = true;

            this.checkAcceptButtonEnable();
        }


        private void checkBoxVarLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVarLeft.Checked)
            {
                this.comboBoxLVar.Enabled = true;
                this.comboBoxLVar.Visible = true;
                this.textBox1.Enabled = false;
                this.textBox1.Visible = false;

            }
            else
            {
                this.comboBoxLVar.Enabled = false;
                this.comboBoxLVar.Visible = false;
                this.textBox1.Enabled = true;
                this.textBox1.Visible = true;
            }
            this.checkAcceptButtonEnable();

        }

        private void checkBoxVarRight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVarRight.Checked)
            {
                comboBoxRVar.Enabled = true;
                comboBoxRVar.Visible = true;
                this.textBox2.Enabled = false;
                this.textBox2.Visible = false;
            }
            else
            {
                comboBoxRVar.Enabled = false;
                comboBoxRVar.Visible = false;
                this.textBox2.Enabled = true;
                this.textBox2.Visible = true;
            }
            this.checkAcceptButtonEnable();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkAcceptButtonEnable();
        }

        private void comboBoxLVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkAcceptButtonEnable();
        }

        private void checkAcceptButtonEnable()
        {
            this.btnAccept.Enabled = false;
            if (radioButton1.Checked && comboBox1.Text != "")//simple expr
            {
                if (checkBoxVarLeft.Checked && comboBoxLVar.Text != "")
                {
                    this.btnAccept.Enabled = true;
                }
                else if(!checkBoxVarLeft.Checked && textBox1.Text != "")
                {
                    this.btnAccept.Enabled = true;
                }
            }
            else if (radioButton2.Checked && comboBox1.Text != "" && comboBox2.Text != "")//complex expr
            {
                if (checkBoxVarLeft.Checked && comboBoxLVar.Text != "")//var for left
                {
                    if (checkBoxVarRight.Checked && comboBoxLVar.Text != "")
                    {
                        this.btnAccept.Enabled = true;
                    }
                    else if (!checkBoxVarRight.Checked && textBox2.Text != "")
                    {
                        this.btnAccept.Enabled = true;
                    }
                    
                }
                else if (!checkBoxVarLeft.Checked && textBox1.Text != "")
                {
                    if (checkBoxVarRight.Checked && comboBoxLVar.Text != "")
                    {
                        this.btnAccept.Enabled = true;
                    }
                    else if (!checkBoxVarRight.Checked && textBox2.Text != "")
                    {
                        this.btnAccept.Enabled = true;
                    }
                }
            }
            

        }

        
    }
}

