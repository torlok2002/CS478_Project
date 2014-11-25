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
        //Instantiate linked list of Statements which can add statement objects to it. 
        LinkedList<Statement> list1 = new LinkedList<Statement>();
        String codeString;


        private void Form1_Load(object sender, EventArgs e)
        {
            //ProgramDir.Load(treeDirectory);
        }


        private void VariableButton_Click(object sender, EventArgs e)
        {
            
            string varName = Microsoft.VisualBasic.Interaction.InputBox("Enter varible name:", "Variable Name");
            string varVal = Microsoft.VisualBasic.Interaction.InputBox("Enter varible value:", "Variable Value");
            progObject objectA = new progObject(varName, 1); //new integer type variable
            objectA.setValue(varVal);
            list1.AddLast(objectA.getStatement());

            update_codeOutputBox();
            update_txtOutputBox();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string operA = Microsoft.VisualBasic.Interaction.InputBox("Enter first operand to calculate: ", "Enter operand 1");
            string calculation = Microsoft.VisualBasic.Interaction.InputBox("Enter arithmetic operator: \r\n (+, -, *,or  /", "Enter operator");
            string operB = Microsoft.VisualBasic.Interaction.InputBox("Enter Second operand to calculate: ", "Enter operand 2");
            string toVar = Microsoft.VisualBasic.Interaction.InputBox("Enter variable to assign it to:\r\n (+, -, *,or  /", "Enter assignment");
            progObject objectA = new progObject("A", 1);
            progObject objectB = new progObject("B", 1);
            objectA.setValue(operA);
            objectB.setValue(operB);
            ArithStatement stat1 = new ArithStatement(objectA, objectB, calculation, "statement1");
            list1.AddLast(stat1);

            update_codeOutputBox();
            update_txtOutputBox();
        }

        /*private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtCodeBox.Text += "While \u2610 Loop \u2610\r\n";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtCodeBox.Text += "\u2610 = Input\r\n";
        }*/

        private void OutputButton_Click(object sender, EventArgs e)
        {
            string varOut = Microsoft.VisualBasic.Interaction.InputBox("Enter value to output to user", "Output Value");
            progObject objectA = new progObject(varOut, 1); //new integer type variable
            OutputStatement stmtA = new OutputStatement(objectA, "Output Statement n"); //New Output Statement
            list1.AddLast(stmtA);

            //put visual code in Code Box
            txtCodeBox.Text += "Output: " + stmtA.getOutput() + "\r\n";

            update_txtOutputBox();
            update_codeOutputBox();
            //txtCodeBox.Text += "Output = \u2610\r\n";
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

        private void txtOutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_codeOutputBox() //iterate through linked list and get user statement code.
        {
            codeString = "";
            foreach (var stat in list1)
            {
                codeString += stat.getUserCode() + "\r\n";
            }
            txtCodeBox.Text = "";
            txtCodeBox.Text = codeString;
        }

        private void update_txtOutputBox() //iterate through linked list and get java statement code.

        {
            codeString = "";
            foreach (var stat in list1)
            {
                codeString += stat.getJCode() + "\r\n";
            }
            txtOutputBox.Text = "";
            txtOutputBox.Text = codeString;
        }
    }
}
