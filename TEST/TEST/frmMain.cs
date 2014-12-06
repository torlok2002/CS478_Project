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
        ProgramDir IDEDir;
        StudentProgram IDEProgram;
        //Instantiate linked list of Statements which can add statement objects to it. 
        LinkedList<Statement> list1 = new LinkedList<Statement>();
        String codeString;


        private void Form1_Load(object sender, EventArgs e)
        {
            IDEDir = new ProgramDir(tvTreeDirectory);
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
            //string varVal = Microsoft.VisualBasic.Interaction.InputBox("Enter varible value:", "Variable Value");
            Variable varObject = new Variable(varType,varName);
            VarInitStatement varStatement = new VarInitStatement(varObject);
            list1.AddLast(varStatement);
            //IDEProgram.AddStatement(varStatement);
            update_codeOutputBox();
            update_txtOutputBox();
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            string left = Microsoft.VisualBasic.Interaction.InputBox("Enter left side of expression: ", "Enter left");
            string operation = Microsoft.VisualBasic.Interaction.InputBox("Enter arithmetic operator: \r\n (+, -, *,or  /", "Enter operator");
            string right = Microsoft.VisualBasic.Interaction.InputBox("Enter right side of expression: ", "Enter right");
            string toVar = Microsoft.VisualBasic.Interaction.InputBox("Enter variable to assign it to:\r\n", "Enter assignment");
            Expression express = new Expression(left, operation, right);
            AssignStatement stat1 = new AssignStatement(toVar, express);
            list1.AddLast(stat1);

            update_codeOutputBox();
            update_txtOutputBox();
        }

        private void IfButton_Click(object sender, EventArgs e)
        {
            txtCodeBox.Text += "If \u2610 Do \u2610\r\n";



        }

        private void WhileButton_Click(object sender, EventArgs e)
        {
            txtCodeBox.Text += "while \u2610 loop \u2610\r\n";
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
            NewProgram frmNew = new NewProgram();
            frmNew.sInitialPath = IDEDir.Path;
            if (frmNew.ShowDialog(this) == DialogResult.OK)
            {

                if (bChanged == true)
                {
                    DialogResult Dr = MessageBox.Show("Would you like to save the project?", "Save Project", MessageBoxButtons.YesNoCancel);
                    if (Dr == DialogResult.Yes || Dr == DialogResult.No)
                    {
                        if (Dr == DialogResult.Yes)
                        {
                            //Save the file
                            IDEDir.SaveFile(IDEProgram);
                            bChanged = false;
                        }
                        //Clear code box and exit program
                        update_codeOutputBox();
                        update_txtOutputBox();
                        IDEProgram = new StudentProgram(frmNew.ChoosenLanguage, frmNew.ProgramName, frmNew.Path);
                    }
                }
                else
                {
                    //Clear code box and exit program
                    //Either add empty program to program list or clear program object
                    //list1.Clear();
                    update_codeOutputBox();
                    update_txtOutputBox();
                    IDEProgram = new StudentProgram(frmNew.ChoosenLanguage, frmNew.ProgramName, frmNew.Path);
                    txtOutputBox.Text = "";
                }
            }

        }

        private void txtCodeBox_TextChanged(object sender, EventArgs e)
        {
            bChanged = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fb = new OpenFileDialog();
            fb.InitialDirectory = IDEDir.Path;
            fb.Filter = ".prog";
            fb.Multiselect = false;
            fb.Title = "Open Program";
            fb.AddExtension = true;
            fb.ShowDialog();

            IDEProgram = IDEDir.LoadFile(fb.FileName);
            tlsStatementStrip.Enabled = true;
            //Load Program object from serialized file
            //txtCodeBox.Text = Language.Parse(Program);
            //treeDirectory.Select? select correct node
        }

        private void treeDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.ImageIndex == 1)
            {
                //Bring up menu? Load Object?
                if (bChanged == true)
                {
                    DialogResult Dr = MessageBox.Show("Would you like to save the project?", "Save Project", MessageBoxButtons.YesNoCancel);
                    if (Dr == DialogResult.Yes || Dr == DialogResult.No)
                    {
                        if (Dr == DialogResult.Yes)
                        {
                            IDEDir.SaveFile(IDEProgram);
                            bChanged = false;
                        }
                        //Load Object
                        IDEDir.LoadFile(IDEDir.ParentPath + "\\" + e.Node.FullPath);
                        tlsStatementStrip.Enabled = true;
                    }
                }
                else
                {
                    //Load Object
                    IDEDir.LoadFile(IDEDir.ParentPath + "\\" + e.Node.FullPath);
                    tlsStatementStrip.Enabled = true;
                }
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
            IDEDir.SaveFile(IDEProgram);
            bChanged = false;
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

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            IDEDir.moveUp();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            IDEDir.LoadTree();
        }




    }
}
