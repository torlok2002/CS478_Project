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
    public partial class ConditionalForm : Form
    {
        
        //fields
        public string left
        {
            get { return comboBoxLeft.Text; }
            set { comboBoxLeft.Text = left; }
        }
        
        public string right
        {
            get { return comboBoxRight.Text; }
            set { comboBoxRight.Text = right; }
        }

        public string oper
        {
            get { return comboBoxEqual.Text; }
            set { comboBoxEqual.Text = oper; } 
        }

        public string type
        {
            get { return label1.Text; }
            set { label1.Text = type; }
        }

        //constructor
        public ConditionalForm(string[,] ExistingVarList)
        {
            InitializeComponent();
            for (int i = 0; i < ExistingVarList.GetLength(0); i++)
            {
                this.comboBoxLeft.Items.Add(ExistingVarList[i,0]);
                this.comboBoxRight.Items.Add(ExistingVarList[i,0]);
            }
            this.AcceptButton = button1;
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void comboBoxLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxLeft.Text != "" && this.comboBoxRight.Text != "" && this.comboBoxEqual.Text != "")
                this.button1.Enabled = true;
        }

        private void comboBoxEqual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxLeft.Text != "" && this.comboBoxRight.Text != "" && this.comboBoxEqual.Text != "")
                this.button1.Enabled = true;
        }

        private void comboBoxRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxLeft.Text != "" && this.comboBoxRight.Text != "" && this.comboBoxEqual.Text != "")
                this.button1.Enabled = true;
        }


    }
}
