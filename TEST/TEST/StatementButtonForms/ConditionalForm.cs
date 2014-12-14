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
        public Conditional conditional;
        public string left { get; set; }
        public string right { get; set; }
        public string oper { get; set; }
        public string type { get; set; }

        //generic constructor
        public ConditionalForm(string[,] ExistingVarList)
        {
            InitializeComponent();
            for (int i = 0; i < ExistingVarList.GetLength(0); i++)
            {
                this.comboBoxLeft.Items.Add(ExistingVarList[i, 0]);
                this.comboBoxRight.Items.Add(ExistingVarList[i, 0]);
            }
            this.AcceptButton = button1;
        }

        //constructor to modify existing object
        public ConditionalForm(string[,] ExistingVarList, Conditional ExistCond)
        {
            InitializeComponent();
            for (int i = 0; i < ExistingVarList.GetLength(0); i++)
            {
                this.comboBoxLeft.Items.Add(ExistingVarList[i, 0]);
                this.comboBoxRight.Items.Add(ExistingVarList[i, 0]);
            }
            this.conditional = ExistCond;
            this.AcceptButton = button1;
            this.left = ExistCond.left;
            this.oper = ExistCond.comparator;
            this.right = ExistCond.right;
            this.comboBoxLeft.Text = left;
            this.comboBoxEqual.Text = oper;
            this.comboBoxRight.Text = right;

            this.button1.Enabled = true;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.left = comboBoxLeft.Text;
            this.oper = comboBoxEqual.Text;
            this.right = comboBoxRight.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
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

        private void comboBoxRight_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBoxLeft.Text != "" && this.comboBoxRight.Text != "" && this.comboBoxEqual.Text != "")
                this.button1.Enabled = true;
        }
    }
}
