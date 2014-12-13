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
    public partial class If_WhileForm : Form
    {
        //fields
        private List<Statement> statlist;
        private string[] varlist;
        private string codeString;
        public Conditional condition { get; set; }
        private Language oLanguage;


        public If_WhileForm(string[] ExistVarList, string if_while, Language oLanguage)
        {

            InitializeComponent();
            AcceptButton = buttonAccept;
            label_ifwhile.Text = if_while;
            varlist = ExistVarList;
            statlist = new List<Statement>();
            this.oLanguage = oLanguage;

        }

        private void refreshUI()
        {
            update_codeOutputBox();
        }

        private void update_codeOutputBox() //iterate through linked list and get user statement code.
        {
            codeString = "START\r\n";

            //get temp sting array in order to grab each individual line
            //string[] stmtArray;
            //stmtArray = IDEProgram.getUserCode();
            foreach (Statement s in statlist)
            {
                codeString += s.getUserCode(oLanguage);
                codeString += "\r\n";
            }

            codeString += "END";

            txtCodeBox.Text = "";
            txtCodeBox.Text = codeString;
        }

        /*private void toolStripButton5_Click(object sender, EventArgs e)
        {

            VarInitStatement stat1 = new VarInitStatement(varlist);
            Variable var1 = stat1.GetVar();
            statlist.Add(stat1);

            refreshUI();
             
        }*/

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            AssignStatement stat1 = new AssignStatement(varlist);
            statlist.Add(stat1);

            refreshUI();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            IfStatement stat1 = new IfStatement(varlist, oLanguage);
            statlist.Add(stat1);

            refreshUI();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            WhileStatement stat1 = new WhileStatement(varlist, oLanguage);
            statlist.Add(stat1);

            refreshUI();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            OutputStatement stat1 = new OutputStatement(varlist);
            statlist.Add(stat1);

            refreshUI();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            InputStatement stat1 = new InputStatement(varlist);
            statlist.Add(stat1);

            refreshUI();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCond_Click(object sender, EventArgs e)
        {
            condition = new Conditional(varlist);
            textBox1.Text = condition.ToString();
        }

        internal List<Statement> getStatlist()
        {
            return statlist;
        }

        //hotkey controls
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //if (keyData == (Keys.Control | Keys.V)) { toolStripButton5_Click(null, null); }
            if (keyData == (Keys.Control | Keys.A)) { toolStripButton6_Click(null, null); }
            if (keyData == (Keys.Control | Keys.F)) { toolStripButton7_Click(null, null); }
            if (keyData == (Keys.Control | Keys.W)) { toolStripButton8_Click(null, null); }
            if (keyData == (Keys.Control | Keys.O)) { toolStripButton9_Click(null, null); }
            if (keyData == (Keys.Control | Keys.I)) { toolStripButton10_Click(null, null); }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}