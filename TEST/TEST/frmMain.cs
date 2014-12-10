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
        StudentProgram IDEProgram = new StudentProgram("Language1", "NewProg", "NewProg");
        String codeString;
        string[] varlist;

        private void Form1_Load(object sender, EventArgs e)
        {
            IDEDir = new ProgramDir(tvTreeDirectory);
        }


        private void VariableButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            VarInitStatement stat1 = new VarInitStatement(varlist);
            Variable var1 = stat1.GetVar();
            IDEProgram.AddVariable(var1);
            IDEProgram.AddStatement(stat1);

            refreshUI();
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            if (varlist.Count() == 0)
            {
                toolStripStatusLabel1.Text = "No Variables defined: Unable to create assignment statement";
                statusStrip1.Refresh();
            }
            else
            {
                AssignStatement stat1 = new AssignStatement(varlist);
                IDEProgram.AddStatement(stat1);

                refreshUI();
            }
        }

        private void IfButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            IfStatement stat1 = new IfStatement(varlist);
            IDEProgram.AddStatement(stat1);

            refreshUI();
        }

        

        private void WhileButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            WhileStatement stat1 = new WhileStatement(varlist);
            IDEProgram.AddStatement(stat1);

            refreshUI();
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            OutputStatement stat1 = new OutputStatement(varlist); //New Output Statement
            IDEProgram.AddStatement(stat1);

            refreshUI();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            InputStatement stat1 = new InputStatement(); //New Input Statement
            IDEProgram.AddStatement(stat1);

            refreshUI();
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
            if (e.Node.ImageIndex == -1)
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
            Application.Exit();
        }

        private void txtOutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_codeOutputBox() //iterate through linked list and get user statement code.
        {
            codeString = "START\r\n";

            //get temp sting array in order to grab each individual line
            string[] stmtArray;
            stmtArray = IDEProgram.getUserCode();
            foreach (string s in stmtArray)
            {
                codeString += s;
                codeString += "\r\n";
            }
            
            codeString += "END";

            txtCodeBox.Text = "";
            txtCodeBox.Text = codeString;
        }

        private void update_txtOutputBox() //iterate through linked list and get java statement code.

        {
            codeString = "class "+ IDEProgram.getName() + "\r\n {\r\n";
            
            //get temp sting array in order to grab each individual line
            string[] stmtArray;
            stmtArray = IDEProgram.getCCode();
            foreach (string s in stmtArray)
            {
                codeString += s;
                codeString += "\r\n";
            }

            codeString += "}";

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

        //method to refresh UI
        private void refreshUI()
        {
            toolStripStatusLabel1.Text = "";
            statusStrip1.Refresh();
            update_codeOutputBox();
            update_txtOutputBox();
        }

        //hotkey controls
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V)){VariableButton_Click(null, null);}
            if (keyData == (Keys.Control | Keys.A)){AssignButton_Click(null, null);}
            if (keyData == (Keys.Control | Keys.F)) {IfButton_Click(null, null); }
            if (keyData == (Keys.Control | Keys.W)) { WhileButton_Click(null, null); }
            if (keyData == (Keys.Control | Keys.O)) {OutputButton_Click(null, null); }
            if (keyData == (Keys.Control | Keys.I)) {InputButton_Click(null, null); }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
