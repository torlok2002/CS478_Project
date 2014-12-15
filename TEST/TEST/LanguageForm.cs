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
    public partial class LanguageForm : Form
    {
        public LanguageForm(Language oLanguage)
        {
            InitializeComponent();
            char[] aHotKeys = oLanguage.getHotkeys();
            string[] aTemplates = oLanguage.getTemplates();
            if (aHotKeys[5] != '\u20E0') { HotKey1.Text = aHotKeys[5] + ""; }
            Template1.Text = aTemplates[5];
            if (aHotKeys[0] != '\u20E0') { HotKey2.Text = aHotKeys[0] + ""; }
            Template2.Text = aTemplates[0];
            if (aHotKeys[1] != '\u20E0') { HotKey3.Text = aHotKeys[1] + ""; }
            Template3.Text = aTemplates[1];
            if (aHotKeys[2] != '\u20E0') { HotKey4.Text = aHotKeys[2] + ""; }
            Template4.Text = aTemplates[2];
            if (aHotKeys[3] != '\u20E0') { HotKey5.Text = aHotKeys[3] + ""; }
            Template5.Text = aTemplates[3];
            if (aHotKeys[4] != '\u20E0') { HotKey6.Text = aHotKeys[4] + ""; }
            Template6.Text = aTemplates[4];
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                HotKey1.Enabled = true;
                Template1.Enabled = true;
            }
            else
            {
                HotKey1.Enabled = false;
                Template1.Enabled = false;
                HotKey1.Text = "";
                Template1.Text = "";
            }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                HotKey2.Enabled = true;
                Template2.Enabled = true;
            }
            else
            {
                HotKey2.Enabled = false;
                Template2.Enabled = false;
                HotKey2.Text = "";
                Template2.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                HotKey3.Enabled = true;
                Template3.Enabled = true;
            }
            else
            {
                HotKey3.Enabled = false;
                Template3.Enabled = false;
                HotKey3.Text = "";
                Template3.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                HotKey4.Enabled = true;
                Template4.Enabled = true;
            }
            else
            {
                HotKey4.Enabled = false;
                Template4.Enabled = false;
                HotKey4.Text = "";
                Template4.Text = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                HotKey5.Enabled = true;
                Template5.Enabled = true;
            }
            else
            {
                HotKey5.Enabled = false;
                Template5.Enabled = false;
                HotKey5.Text = "";
                Template5.Text = "";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                HotKey6.Enabled = true;
                Template6.Enabled = true;
            }
            else
            {
                HotKey6.Enabled = false;
                Template6.Enabled = false;
                HotKey6.Text = "";
                Template6.Text = "";
            }
        }
        public string[] Result
        {
            get
            {
                string[] temp = new string[] 
                {
                    HotKey1.Text + ",Variable," + Template1.Text,
                    HotKey2.Text + ",Assignment," + Template2.Text,
                    HotKey3.Text + ",Branch," + Template3.Text,
                    HotKey4.Text + ",Loop," + Template4.Text,
                    HotKey5.Text + ",Input," + Template5.Text,
                    HotKey6.Text + ",Output," + Template6.Text
                };
                return temp;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LanguageForm_Load(object sender, EventArgs e)
        {
            if (HotKey1.Text == "" && Template1.Text == "") { HotKey1.Enabled = false; Template1.Enabled = false; checkBox1.Checked = false; }
            if (HotKey2.Text == "" && Template2.Text == "") { HotKey2.Enabled = false; Template2.Enabled = false; checkBox2.Checked = false; }
            if (HotKey3.Text == "" && Template3.Text == "") { HotKey3.Enabled = false; Template3.Enabled = false; checkBox3.Checked = false; }
            if (HotKey4.Text == "" && Template4.Text == "") { HotKey4.Enabled = false; Template4.Enabled = false; checkBox4.Checked = false; }
            if (HotKey5.Text == "" && Template5.Text == "") { HotKey5.Enabled = false; Template5.Enabled = false; checkBox5.Checked = false; }
            if (HotKey6.Text == "" && Template6.Text == "") { HotKey6.Enabled = false; Template6.Enabled = false; checkBox6.Checked = false; }
        }
    }
}
