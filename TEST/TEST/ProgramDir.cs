using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace TEST
{
    class ProgramDir
    {
        private TreeView tvTreeDirectory;
        private String sCurDirectory;

        public ProgramDir(TreeView tvControl)
        {
            sCurDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\Programs";
            tvTreeDirectory = tvControl;
            LoadTree();
        }

        public StudentProgram LoadFile(String sFileName)
        {
            String temp = sCurDirectory;
            sCurDirectory = sFileName.Substring(0,sFileName.LastIndexOf('\\'));
            LoadTree();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(sFileName,
                                        FileMode.Open,
                                        FileAccess.Read,
                                        FileShare.Read);
            StudentProgram oFile = (StudentProgram)formatter.Deserialize(stream);
            stream.Close();
            return oFile;
            
        }
        public void SaveFile(StudentProgram oFile)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(oFile.FilePath, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, oFile);
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            
        }
        public void moveUp()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sCurDirectory);
            sCurDirectory = directoryInfo.Parent.FullName;
            LoadTree();
        }
        public void LoadTree()
        {
            tvTreeDirectory.Nodes.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(sCurDirectory);
            TreeNode rootNode;

            if (directoryInfo.Exists == false)
            {
                sCurDirectory = AppDomain.CurrentDomain.BaseDirectory;
                directoryInfo = new DirectoryInfo(sCurDirectory);
            }
            rootNode = new TreeNode(directoryInfo.Name);
            rootNode.Tag = directoryInfo;
            GetDirectories(directoryInfo, rootNode);
            tvTreeDirectory.Nodes.Add(rootNode);
            rootNode.ImageIndex = rootNode.SelectedImageIndex = 0;
            rootNode.Expand();
        }
        private void GetDirectories(DirectoryInfo rootDirectory, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            foreach (DirectoryInfo subDir in rootDirectory.GetDirectories())
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder.png";
                if (subDir.GetDirectories().Length != 0 || subDir.GetFiles().Length != 0)
                {
                    GetDirectories(subDir, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
                
            }
            foreach (FileInfo file in rootDirectory.GetFiles())
                {
                    if (file.Exists && file.Extension == ".prog")
                    {
                        aNode = new TreeNode(file.Name, 0, 1);
                        aNode.Tag = file.Name;
                        aNode.ImageKey = "file.png";
                        nodeToAddTo.Nodes.Add(aNode);
                    }
                }
        }
        public void moveHome()
        {
            sCurDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\Programs";
            LoadTree();
        }
        public String Path
        {
            get
            {
                return sCurDirectory;
            }
        }
        public String ParentPath
        {
            get
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(sCurDirectory);
                return directoryInfo.Parent.FullName; 
            }
        }

        public String ProgramName
        {
            get
            {
                string[] nameAr = sCurDirectory.Split('\\');
                string name = nameAr[nameAr.Length];
                
                return name.Substring(0,name.Length-5);
            }
        }
        
    }
}
