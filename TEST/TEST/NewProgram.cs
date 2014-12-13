using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            cboLanguage.DataSource = Languages();
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {

            SaveFileDialog fb = new SaveFileDialog();
            fb.InitialDirectory = sInitialPath;
            fb.Filter = "Program files (*.prog)|*.prog";
            fb.Title = "Open Program";
            fb.AddExtension = true;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = fb.FileName;
            }
            
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

        public List<String> Languages()
        {   
            List<String> lLanguages = new List<String>();
            DirectoryInfo dirInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "\\Languages");
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                if(file.Extension == ".Language")
                {
                    lLanguages.Add(file.Name.Substring(0,file.Name.Length-9));
                }
                
            }
            return lLanguages;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
