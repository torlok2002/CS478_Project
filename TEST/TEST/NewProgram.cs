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
    public partial class NewProgram : Form
    {
        public String sInitialPath;
        public NewProgram()
        {
            InitializeComponent();
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }

        private void NewProgram_Load(object sender, EventArgs e)
        {

        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {

            SaveFileDialog fb = new SaveFileDialog();
            fb.InitialDirectory = sInitialPath;
            fb.Filter = ".prog";
            fb.Title = "Open Program";
            fb.AddExtension = true;
            fb.ShowDialog();
            
        }
        public String ChoosenLanguage
        {
            get
            {
                return cboLanguage.Text;
            }
        }
        public String Path
        {
            get
            {
                return txtFilePath.Text;
            }
        }
        public String ProgramName
        {
            get
            {
                String[] aTempArray = txtFilePath.Text.Split('\\');
                String aTempString = aTempArray.ElementAt(aTempArray.Length - 1);
                return aTempString.Substring(0,aTempString.Length-6);
            }
        }

        
    }
}
