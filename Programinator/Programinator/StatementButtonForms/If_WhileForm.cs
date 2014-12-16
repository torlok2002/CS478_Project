using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programinator
{
    public partial class If_WhileForm : Form
    {
        //fields
        private List<Statement> statlist;
        private string[,] varlist;
        private string codeString;
        public Conditional condition { get; set; }
        private Language oLanguage;
        private bool boolCancel = true;
        private bool boolDelete = false;
        public If_WhileForm(string[,] ExistVarList, string if_while, Language oLanguage)
        {

            InitializeComponent();
            AcceptButton = buttonAccept;
            label_ifwhile.Text = if_while;
            varlist = ExistVarList;
            statlist = new List<Statement>();
            this.oLanguage = oLanguage;

        }
        //constructor to modify existing existing conditional  for if statements
        public If_WhileForm(string[,] ExistVarList, string if_while, Language oLanguage, IfStatement statIn)
        {
            InitializeComponent();
            AcceptButton = buttonAccept;
            label_ifwhile.Text = if_while;
            varlist = ExistVarList;
            this.condition = statIn.getCon();
            this.oLanguage = oLanguage;
            this.statlist = statIn.getStatementList();
            this.textBox1.Text = statIn.getConditonal();
            this.DeleteButton.Visible = true;
            refreshUI();
        }

        ////constructor to modify existing existing conditional for while statments
        public If_WhileForm(string[,] ExistVarList, string if_while, Language oLanguage, WhileStatement statIn)
        {
            InitializeComponent();
            AcceptButton = buttonAccept;
            label_ifwhile.Text = if_while;
            varlist = ExistVarList;
            this.condition = statIn.getCon();
            this.oLanguage = oLanguage;
            this.statlist = statIn.getStatementList();
            this.condition = statIn.getCon();
            this.textBox1.Text = statIn.getConditonal();
            this.DeleteButton.Visible = true;
            refreshUI();
        }
        private void refreshUI()
        {
            char[] temp = oLanguage.getHotkeys();
            if (temp[0] == '\u20E0') { AssignButton.Enabled = false; } else AssignButton.Enabled = true;
            if (temp[1] == '\u20E0') { IfButton.Enabled = false; } else IfButton.Enabled = true;
            if (temp[2] == '\u20E0') { WhileButton.Enabled = false; } else WhileButton.Enabled = true;
            if (temp[3] == '\u20E0') { InputButton.Enabled = false; } else InputButton.Enabled = true;
            if (temp[4] == '\u20E0') { OutputButton.Enabled = false; } else OutputButton.Enabled = true;
            //if (temp[5] == '\u20E0') { VariableButton.Enabled = false; } else VariableButton.Enabled = true;
            update_codeOutputBox();
        }

        private void update_codeOutputBox() //iterate through linked list and get user statement code.
        {
            

            //get temp sting array in order to grab each individual line
            //string[] stmtArray;
            //stmtArray = IDEProgram.getUserCode();
            codeString = "";
            foreach (Statement s in statlist)
            {
                codeString += s.getUserCode(oLanguage) + "\r\n";
            }

            

            txtCodeBox.Text = "";
            txtCodeBox.Text = codeString.Substring(0,codeString.Length-2);
        }

        

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            AssignStatement stat1 = new AssignStatement(varlist);
            if (stat1.Canceled == false) 
            { 
                statlist.Add(stat1); 
            }

            refreshUI();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            IfStatement stat1 = new IfStatement(varlist, oLanguage);
            if (stat1.Canceled == false)
            { 
                statlist.Add(stat1); 
            }

            refreshUI();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            WhileStatement stat1 = new WhileStatement(varlist, oLanguage);
            if (stat1.Canceled == false)
            { 
                statlist.Add(stat1); 
            }

            refreshUI();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            OutputStatement stat1 = new OutputStatement(varlist);
            if (stat1.Canceled == false)
            { 
                statlist.Add(stat1); 
            }

            refreshUI();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            InputStatement stat1 = new InputStatement(varlist);
            if (stat1.Canceled == false)
            { 
                statlist.Add(stat1); 
            }

            refreshUI();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            this.boolCancel = false;
            this.Close();
        }

        private void buttonCond_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                condition = new Conditional(varlist);
                textBox1.Text = condition.ToString();
            }
            else
            {
                Conditional newcond = new Conditional(varlist, condition);
                textBox1.Text = newcond.ToString();
                condition = newcond;
            }
        }

        internal List<Statement> getStatlist()
        {
            return statlist;
        }

        //hotkey controls
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | (Keys)char.ToUpper(oLanguage.getHotkeys().ElementAt(0))) && oLanguage.getHotkeys().ElementAt(0) != '\u20E0' && AssignButton.Enabled) { toolStripButton6_Click(null, null); }
            if (keyData == (Keys.Control | (Keys)char.ToUpper(oLanguage.getHotkeys().ElementAt(1))) && oLanguage.getHotkeys().ElementAt(1) != '\u20E0' && IfButton.Enabled) { toolStripButton7_Click(null, null); }
            if (keyData == (Keys.Control | (Keys)char.ToUpper(oLanguage.getHotkeys().ElementAt(2))) && oLanguage.getHotkeys().ElementAt(2) != '\u20E0' && WhileButton.Enabled) { toolStripButton8_Click(null, null); }
            if (keyData == (Keys.Control | (Keys)char.ToUpper(oLanguage.getHotkeys().ElementAt(3))) && oLanguage.getHotkeys().ElementAt(3) != '\u20E0' && InputButton.Enabled) { toolStripButton10_Click(null, null); }
            if (keyData == (Keys.Control | (Keys)char.ToUpper(oLanguage.getHotkeys().ElementAt(4))) && oLanguage.getHotkeys().ElementAt(4) != '\u20E0' && OutputButton.Enabled) { toolStripButton9_Click(null, null); }
            //if (keyData == (Keys.Control | (Keys)char.ToUpper(oLanguage.getHotkeys().ElementAt(5))) && oLanguage.getHotkeys().ElementAt(5) != '\u20E0' && VariableButton.Enabled) { VariableButton_Click(null, null); }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            /*VarInitStatement stat1 = new VarInitStatement(varlist);
            Variable var1 = stat1.GetVar();
            if (stat1.Canceled==false) 
            { 
                statlist.Add(stat1); 
            }

            refreshUI(); */
        }

        private void tlsStatementStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.boolDelete = true;
            this.Close();
        }

        private void txtCodeBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtCodeBox.Text != "")
            {
                editStatement(txtCodeBox.GetLineFromCharIndex(txtCodeBox.GetCharIndexFromPosition(new Point(e.X, e.Y))));
                refreshUI();
            }
        }
        public void editStatement(int iIndex)
        {
            if (statlist[iIndex].getStatementType() == "assign")
            {
                AssignStatement Temp = statlist[iIndex] as AssignStatement;
                AssignStatement newstat = new AssignStatement(this.varlist, Temp);
                if (newstat.Deleted == false)
                {
                    if (newstat.Canceled == false)
                    {
                        statlist[iIndex] = newstat;
                    }
                }
                else
                {
                    statlist.RemoveAt(iIndex);
                }
            }
            else if (statlist[iIndex].getStatementType() == "output")
            {
                OutputStatement Temp = statlist[iIndex] as OutputStatement;
                OutputStatement newstat = new OutputStatement(this.varlist, Temp);
                if (newstat.Deleted == false)
                {
                    if (newstat.Canceled == false)
                    {
                        statlist[iIndex] = newstat;
                    }
                }
                else
                {
                    statlist.RemoveAt(iIndex);
                }
            }
            else if (statlist[iIndex].getStatementType() == "input")
            {
                InputStatement Temp = statlist[iIndex] as InputStatement;
                InputStatement newstat = new InputStatement(this.varlist, Temp);
                if (newstat.Deleted == false)
                {
                    if (newstat.Canceled == false)
                    {
                        statlist[iIndex] = newstat;
                    }
                }
                else
                {
                    statlist.RemoveAt(iIndex);
                }
            }
            else if (statlist[iIndex].getStatementType() == "if")
            {
                IfStatement Temp = statlist[iIndex] as IfStatement;
                IfStatement newstat = new IfStatement(this.varlist, oLanguage, Temp);
                if (newstat.Deleted == false)
                {
                    if (newstat.Canceled == false)
                    {
                        statlist[iIndex] = newstat;
                    }
                }
                else
                {
                    statlist.RemoveAt(iIndex);
                }
            }
            else if (statlist[iIndex].getStatementType() == "while")
            {
                WhileStatement Temp = statlist[iIndex] as WhileStatement;
                WhileStatement newstat = new WhileStatement(this.varlist, oLanguage, Temp);
                if (newstat.Deleted == false)
                {
                    if (newstat.Canceled == false)
                    {
                        statlist[iIndex] = newstat;
                    }
                }
                else
                {
                    statlist.RemoveAt(iIndex);
                }
            }

        }

        private void If_WhileForm_Load(object sender, EventArgs e)
        {

        }
        public bool Canceled
        {
            get
            {
                return boolCancel;
            }
        }
        public bool Deleted
        {
            get
            {
                return boolDelete;
            }
        }
    }
}