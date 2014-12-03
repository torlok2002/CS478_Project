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
            
            int varType = 0;
            while (varType == 0 || varType > 3)
            {
                int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Enter varible type:\r\n 1 = integer\r\n 2 = character\r\n 3 = string", "Variable type"), out varType);
                //display to user that selection didnt match 1, 2, or 3
            }
            string varName = Microsoft.VisualBasic.Interaction.InputBox("Enter varible name:", "Variable Name");
            string varVal = Microsoft.VisualBasic.Interaction.InputBox("Enter varible value:", "Variable Value");
            Variable varObject = new Variable(varType,varName, varVal);
            list1.AddLast(varObject.getStatement());

            update_codeOutputBox();
            update_txtOutputBox();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string left = Microsoft.VisualBasic.Interaction.InputBox("Enter left side of calculation: ", "Enter left");
            string operation = Microsoft.VisualBasic.Interaction.InputBox("Enter arithmetic operator: \r\n (+, -, *,or  /", "Enter operator");
            string right = Microsoft.VisualBasic.Interaction.InputBox("Enter right side of calculation: ", "Enter right");
            string toVar = Microsoft.VisualBasic.Interaction.InputBox("Enter variable to assign it to:\r\n", "Enter assignment");
            Expression express = new Expression(left, operation, right);
            CalcStatement stat1 = new CalcStatement(toVar, express);
            list1.AddLast(stat1);

            update_codeOutputBox();
            update_txtOutputBox();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtCodeBox.Text += "While \u2610 Loop \u2610\r\n";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            txtCodeBox.Text += "\u2610 = Input\r\n";
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter value to output to user", "Output Value");
            OutputStatement stmtA = new OutputStatement(input); //New Output Statement
            list1.AddLast(stmtA);
            update_txtOutputBox();
            update_codeOutputBox();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            string message = Microsoft.VisualBasic.Interaction.InputBox("Enter message to prompt user for input", "Message for user");
            string varTo = Microsoft.VisualBasic.Interaction.InputBox("Which Variable would you like to assign user's response to?", "Variable");
            InputStatement stmtA = new InputStatement(message, varTo); //New Input Statement
            list1.AddLast(stmtA);
            update_txtOutputBox();
            update_codeOutputBox();
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
                    list1.Clear();
                    update_codeOutputBox();
                    update_txtOutputBox();

                    //Get new program name
                    string NewProgName = Microsoft.VisualBasic.Interaction.InputBox( "Enter new program name:","New Program");
                    update_StatusBar("New Program " + NewProgName + " started.");
                }
            } 
            /*else
            {
                //Clear code box and exit program
                //Either add empty program to program list or clear program object
                list1.Clear();
                update_codeOutputBox();
                update_txtOutputBox();

                //Get new program name
                string NewProgName = Microsoft.VisualBasic.Interaction.InputBox("New Program", "Enter new program name:");
                txtOutputBox.Text = NewProgName;
            }*/

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

        private void update_StatusBar(string s)
        {
            toolStripStatusLabel1.Text = s;
        }




    }
}
