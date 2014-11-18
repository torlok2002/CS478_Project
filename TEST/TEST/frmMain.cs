using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TEST
{
    public partial class frmMain : Form
    {
        bool bChanged = false;
        public frmMain()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //ProgramDir.Load(treeDirectory);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            txtCodeBox.Text += "\u2610 = \u2610\r\n";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txtCodeBox.Text += "If \u2610 Then \u2610\r\n";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtCodeBox.Text += "While \u2610 Loop \u2610\r\n";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtCodeBox.Text += "\u2610 = Input\r\n";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            txtCodeBox.Text += "Output = \u2610\r\n";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bChanged == true)
            {
                DialogResult Dr = MessageBox.Show("Would you like to save the project?", "Save Project", MessageBoxButtons.YesNoCancel);
                if (Dr == DialogResult.Yes || Dr == DialogResult.No)
                {
                    if (Dr == DialogResult.Yes)
                    {
                        //Save program
                    }
                    //Clear code box and exit program
                    //Either add empty program to program list or clear program object
                    txtCodeBox.Text = "";

                    //Get new program name
                    string NewProgName = Microsoft.VisualBasic.Interaction.InputBox("New Program", "Enter new program name:");
                    txtOutputBox.Text = NewProgName;
                }
            } 
            else
            {
                //Clear code box and exit program
                //Either add empty program to program list or clear program object
                txtCodeBox.Text = "";

                //Get new program name
                string NewProgName = Microsoft.VisualBasic.Interaction.InputBox("New Program", "Enter new program name:");
                txtOutputBox.Text = NewProgName;
            }

        }

        private void txtCodeBox_TextChanged(object sender, EventArgs e)
        {
            bChanged = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load Program object from serialized file
            //txtCodeBox.Text = Language.Parse(Program);
            //treeDirectory.Select? select correct node
        }

        private void treeDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Bring up menu? Load Object?
            if (bChanged == true)
            {
                DialogResult Dr = MessageBox.Show("Would you like to save the project?", "Save Project", MessageBoxButtons.YesNoCancel);
                if (Dr == DialogResult.Yes || Dr == DialogResult.No)
                {
                    if (Dr == DialogResult.Yes)
                    {
                        //Save program
                    }
                    //Load Object
                }
            }
            else
            {
                //Load Object
            }
        }

        private void btnRunProg_Click(object sender, EventArgs e)
        {
            //Compiler.Compile(Program.ToJava());
            //if (Compiler.Error() == "0") {
                //txtOutputBox.Text += Compiler.Result + "\r\nRUN COMPELETED SUCCESSFULLY"
            //}
            //else
            //{
            //txtOutPutBox.Text += "RUN FAILED\r\n" + Compiler.Error() + "\r\n"

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
