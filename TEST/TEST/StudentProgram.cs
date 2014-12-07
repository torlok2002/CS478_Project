using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    [Serializable]
    class StudentProgram
    {
        [OptionalField] private String sFilename;
        private String sName;
        private String sLanguage;
        private Language oUserLanguage, oCompileLanguage;
        private List<Statement> oStatements;
        private List<Variable> oVariables;

        public StudentProgram(String sLanguage, String sName, String sFilename)
        {
            oStatements = new List<Statement>();
            this.sLanguage = sLanguage;
            this.sName = sName;
            this.sFilename = sFilename;
        }
        public void AddVariable(Variable oVariable)
        {
            oVariables.Add(oVariable);
        }
        public void RemoveVariable(int iIndex)
        {
            oVariables.RemoveAt(iIndex);
        }
        public void AddStatement(Statement oStatement)
        {
            oStatements.Add(oStatement);
        }
        public void DeleteStatement(int iIndex)
        {
            oStatements.RemoveAt(iIndex);
        }
        public void MoveStatement(int iOldIndex, int iNewIndex)
        {
            Statement oStatement = oStatements.ElementAt(iOldIndex);
            oStatements.RemoveAt(iOldIndex);
            if (iNewIndex > iOldIndex) { iNewIndex--; }
            oStatements.Insert(iNewIndex, oStatement);
        }
        public String ProgramLanguage
        {
            get
            {
                return sLanguage;
            }
        }
        public String FilePath
        {
            get
            {
                return sFilename;
            }
        }
        public void newFileName(String sNewFileName)
        {
            this.sFilename = sNewFileName;
        }
        public List<Statement> Statements
        {
            get
            {
                return oStatements;
            }
        }
        public String[] Variables
        {
            get
            {
                String[] vars = new String[oVariables.Count];
                for (int i = 0; i < oVariables.Count; i++)
                {
                    vars[i] = oVariables.ElementAt(i).getName();
                }
                return vars;
            }
        }

        public string[] getCCode()
        {
            string[] aCSLines = new string[oStatements.Count];
            int i=0;
            foreach (Statement oTempObject in oStatements)
            {
                aCSLines[i] = oTempObject.getCCode();
                i++;
            }

            return aCSLines;
        }
    }
}
