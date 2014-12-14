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
        String codeString;
        string[,] varlist;

        private void Form1_Load(object sender, EventArgs e)
        {
            IDEDir = new ProgramDir(tvTreeDirectory);
        }


        private void VariableButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            VarInitStatement stat1 = new VarInitStatement(varlist);
            Variable var1 = stat1.GetVar();
            if (stat1.Canceled == false)
            {
                IDEProgram.AddVariable(var1);
                IDEProgram.AddStatement(stat1);
            }

            refreshUI();
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            if (varlist.GetLength(0) == 0)
            {
                toolStripStatusLabel1.Text = "No Variables defined: Unable to create assignment statement";
                statusStrip1.Refresh();
            }
            else
            {
                AssignStatement stat1 = new AssignStatement(varlist);
                if (stat1.Canceled == false)
                {
                    IDEProgram.AddStatement(stat1);
                }
                refreshUI();
            }
        }

        private void IfButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            IfStatement stat1 = new IfStatement(varlist,IDEProgram.ProgramLanguage);
            if (stat1.Canceled == false)
            {
                IDEProgram.AddStatement(stat1);
            }
            statusStrip1.Refresh();
            refreshUI();
        }

        private void WhileButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            WhileStatement stat1 = new WhileStatement(varlist,IDEProgram.ProgramLanguage);
            if (stat1.Canceled == false)
            {
                IDEProgram.AddStatement(stat1);
            }
            refreshUI();
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            OutputStatement stat1 = new OutputStatement(varlist); //New Output Statement
            if (stat1.Canceled == false)
            {
                IDEProgram.AddStatement(stat1);
            }

            refreshUI();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            varlist = IDEProgram.Variables;
            if (varlist.GetLength(0) == 0)
            {
                toolStripStatusLabel1.Text = "No Variables defined: Unable to create assignment statement";
                statusStrip1.Refresh();
            }
            else
            {
                InputStatement stat1 = new InputStatement(varlist);
                if (stat1.Canceled == false)
                {
                    IDEProgram.AddStatement(stat1);
                }
                refreshUI();
            }
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

                    if (Dr == DialogResult.Yes)
                    {
                        //Save the file
                        IDEDir.SaveFile(IDEProgram);

                        //Create the file
                        IDEProgram = new StudentProgram(frmNew.ChoosenLanguage, frmNew.ProgramName, frmNew.Path);
                        tlsStatementStrip.Enabled = true;
                        refreshUI();
                        bChanged = false;
                    }
                    else if (Dr == DialogResult.No)
                    {
                        //Just create the file
                        IDEProgram = new StudentProgram(frmNew.ChoosenLanguage, frmNew.ProgramName, frmNew.Path);
                        tlsStatementStrip.Enabled = true;
                        refreshUI();
                        bChanged = false;
                    }
                    else { }

                }
                else
                {
                    //Clear code box and exit program
                    //Either add empty program to program list or clear program object
                    //list1.Clear();
                    IDEProgram = new StudentProgram(frmNew.ChoosenLanguage, frmNew.ProgramName, frmNew.Path);
                    tlsStatementStrip.Enabled = true;
                    refreshUI();
                    bChanged = false;
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
            fb.Filter = "Program Files(.prog)|*.prog";
            fb.Multiselect = false;
            fb.Title = "Open Program";
            fb.AddExtension = true;
            fb.ShowDialog();

            try
            {
                IDEProgram = IDEDir.LoadFile(fb.FileName);
                IDEProgram.FilePath = fb.FileName;
                tlsStatementStrip.Enabled = true;
                refreshUI();
                bChanged = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void treeDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.ImageIndex == -1)
            {
                //Bring up menu? Load Object?
                if (bChanged == true)
                {
                    DialogResult Dr = MessageBox.Show("Would you like to save the project?", "Save Project", MessageBoxButtons.YesNoCancel);

                    if (Dr == DialogResult.Yes)
                    {
                        IDEDir.SaveFile(IDEProgram);
                        bChanged = false;
                        //Load Object
                        try
                        {
                            IDEProgram = IDEDir.LoadFile(IDEDir.ParentPath + "\\" + e.Node.FullPath);
                            IDEProgram.FilePath = IDEDir.ParentPath + "\\" + e.Node.FullPath;
                            tlsStatementStrip.Enabled = true;
                            refreshUI();
                            bChanged = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (Dr == DialogResult.No)
                    {
                        //Load Object
                        try
                        {
                            IDEProgram = IDEDir.LoadFile(IDEDir.ParentPath + "\\" + e.Node.FullPath);
                            IDEProgram.FilePath = IDEDir.ParentPath + "\\" + e.Node.FullPath;
                            tlsStatementStrip.Enabled = true;
                            refreshUI();
                            bChanged = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    //Load Object
                    try
                    {
                        IDEProgram = IDEDir.LoadFile(IDEDir.ParentPath + "\\" + e.Node.FullPath);
                        IDEProgram.FilePath = IDEDir.ParentPath + "\\" + e.Node.FullPath;
                        tlsStatementStrip.Enabled = true;
                        refreshUI();
                        bChanged = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }

        private void btnRunProg_Click(object sender, EventArgs e)
        {

            try
            {
                btnRunProg.Enabled = false;
                ProgramHandler RUNPROG = new ProgramHandler(IDEProgram, txtOutputBox);
                RUNPROG.Run();
                btnRunProg.Enabled = true;
                RUNPROG = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEDir.SaveFile(IDEProgram);
            bChanged = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_codeOutputBox() //iterate through linked list and get user statement code.
        {
           txtCodeBox.Text =  IDEProgram.getUserCode();
        }

        private void update_txtOutputBox() //iterate through linked list and get java statement code.

        {
            codeString = "class "+ IDEProgram.getName() + "\r\n {\r\n";
            
            //get temp sting array in order to grab each individual line
            codeString += IDEProgram.getCCode();
            

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
            if (IDEProgram != null)
            {
                char[] temp = IDEProgram.ProgramLanguage.getHotkeys();
                if (temp[0] == '\u20E0') { AssignButton.Enabled = false; } else AssignButton.Enabled = true;
                if (temp[1] == '\u20E0') { IfButton.Enabled = false; } else IfButton.Enabled = true;
                if (temp[2] == '\u20E0') { WhileButton.Enabled = false; } else WhileButton.Enabled = true;
                if (temp[3] == '\u20E0') { InputButton.Enabled = false; } else InputButton.Enabled = true;
                if (temp[4] == '\u20E0') { OutputButton.Enabled = false; } else OutputButton.Enabled = true;
                if (temp[5] == '\u20E0') { VariableButton.Enabled = false; } else VariableButton.Enabled = true;
                btnRunProg.Enabled = true;
            }
            else
            {
                btnRunProg.Enabled = false;
            }
            //update_txtOutputBox();
        }

        //hotkey controls
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (tlsStatementStrip.Enabled)
            {
                if (keyData == (Keys.Control | (Keys)char.ToUpper(IDEProgram.ProgramLanguage.getHotkeys().ElementAt(0))) && IDEProgram.ProgramLanguage.getHotkeys().ElementAt(0) != '\u20E0' && AssignButton.Enabled) { AssignButton_Click(null, null); }
                if (keyData == (Keys.Control | (Keys)char.ToUpper(IDEProgram.ProgramLanguage.getHotkeys().ElementAt(1))) && IDEProgram.ProgramLanguage.getHotkeys().ElementAt(1) != '\u20E0' && IfButton.Enabled) { IfButton_Click(null, null); }
                if (keyData == (Keys.Control | (Keys)char.ToUpper(IDEProgram.ProgramLanguage.getHotkeys().ElementAt(2))) && IDEProgram.ProgramLanguage.getHotkeys().ElementAt(2) != '\u20E0' && WhileButton.Enabled) { WhileButton_Click(null, null); }
                if (keyData == (Keys.Control | (Keys)char.ToUpper(IDEProgram.ProgramLanguage.getHotkeys().ElementAt(3))) && IDEProgram.ProgramLanguage.getHotkeys().ElementAt(3) != '\u20E0' && InputButton.Enabled) { InputButton_Click(null, null); }
                if (keyData == (Keys.Control | (Keys)char.ToUpper(IDEProgram.ProgramLanguage.getHotkeys().ElementAt(4))) && IDEProgram.ProgramLanguage.getHotkeys().ElementAt(4) != '\u20E0' && OutputButton.Enabled) { OutputButton_Click(null, null); }
                if (keyData == (Keys.Control | (Keys)char.ToUpper(IDEProgram.ProgramLanguage.getHotkeys().ElementAt(5))) && IDEProgram.ProgramLanguage.getHotkeys().ElementAt(5) != '\u20E0' && VariableButton.Enabled) { VariableButton_Click(null, null); }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtCodeBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtCodeBox.Text != "") { IDEProgram.editStatement(txtCodeBox.GetLineFromCharIndex(txtCodeBox.GetCharIndexFromPosition(new Point(e.X, e.Y)))); }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (tvTreeDirectory.SelectedNode.ImageIndex == -1)
            {
                //Add folder at this document level
            }
            else
            {
                //Add folder under this folder 
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtOutputBox.Text = "";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bChanged == true) 
            {
                DialogResult Dr = MessageBox.Show("Would you like to save the project?", "Save Project", MessageBoxButtons.YesNoCancel);

                if (Dr == DialogResult.Yes)
                {
                    IDEDir.SaveFile(IDEProgram);
                }
                else if (Dr == DialogResult.No) { }
                else
                {
                    e.Cancel = true;
                }
            } 
        }

       


    }
}
