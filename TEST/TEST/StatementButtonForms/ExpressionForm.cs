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
    public partial class ExpressionForm : Form
    {
        //fields
        private string[] existvarlist;

        public string left
        {
            get {return comboBoxLVar.Text;}
            set { }
        }

        public string oper
        {
            get { return comboBox2.Text; }
            set { comboBox2.Text = oper; }
        }

        public string right
        {
            get {return comboBoxRVar.Text;}
            set {  }
        }
         public Expression expression
         {
             get 
             {
                 Expression tempexp = new Expression(left, oper, right);
                 return tempexp;
             }
             set { }
         }

        //constructor
        public ExpressionForm(string[] ExistVarList)
        {
            InitializeComponent();
            this.AcceptButton = btnAccept;
            foreach (string VarName in ExistVarList)
            {
                this.comboBoxLVar.Items.Add(VarName);
                this.comboBoxRVar.Items.Add(VarName);
            }
            existvarlist = ExistVarList;
            

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //code and return values
            this.Close();

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
            if (comboBoxLVar.Text != "" && comboBox2.Text != "" && comboBoxRVar.Text != "")
            {
                this.btnAccept.Enabled = true;
            }

            this.btnAccept.Enabled = true;          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBoxLVar.Enabled = false;
                ExpressionForm lexpressform = new ExpressionForm(existvarlist);
                //set child form to another location to avoid user confusion
                Point point = this.Location;
                point.X = point.X + 10;
                point.Y = point.Y + 10;
                lexpressform.Location = point;
                lexpressform.ShowDialog();

                
                
                comboBoxLVar.Text = lexpressform.expression.ToString();
                checkAcceptButtonEnable();
            }
            else
            {
                comboBoxLVar.Enabled = true;
                left = "";
                comboBoxLVar.Text = left;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                comboBoxRVar.Enabled = false;
                ExpressionForm rexpressform = new ExpressionForm(existvarlist);
                //set child form to another location to avoid user confusion
                Point point = this.Location;
                point.X = point.X + 10;
                point.Y = point.Y + 10;
                rexpressform.Location = point;
                rexpressform.ShowDialog();
                                

                comboBoxRVar.Text = rexpressform.expression.ToString();
                checkAcceptButtonEnable();
            }
            else
            {
                comboBoxRVar.Enabled = true;
                right = "";
                comboBoxRVar.Text = right;
            }
        }


        
    }
}

