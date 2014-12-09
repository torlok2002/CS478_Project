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
    public partial class NewOutputForm : Form
    {
        //fields
        public string outtext
        {
            get { return this.textBoxStr.Text; }
            set { }
        }
        
        public NewOutputForm()
        {
            InitializeComponent();
        }

        private void textBoxStr_TextChanged(object sender, EventArgs e)
        {
            this.buttonAccept.Enabled = true;
        }

        private void radioButtonStr_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxStr.Enabled = true;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (this.textBoxStr.Text != "") { this.Close(); }
            else this.buttonAccept.Enabled = false;

        }
    }
}
