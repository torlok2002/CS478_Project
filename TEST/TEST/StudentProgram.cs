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
        private Language oUserLanguage;
        private List<Statement> oStatements;
        private List<Variable> oVariables;

        public StudentProgram(String sLanguage, String sName, String sFilename)
        {
            oStatements = new List<Statement>();
            oVariables = new List<Variable>();
            this.sLanguage = sLanguage;
            oUserLanguage = new Language(sLanguage);
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
        public Language ProgramLanguage
        {
            get
            {
                return oUserLanguage;
            }
        }
        
        public String FilePath
        {
            get
            {
                return sFilename;
            }
            set
            {
                sFilename = value;
                String[] aTempArray = value.Split('\\');
                String aTempString = aTempArray.ElementAt(aTempArray.Length - 1);
                sName = aTempString.Substring(0, aTempString.Length - 5);

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
        public String[,] Variables
        {
            get
            {
                String[,] vars = new String[oVariables.Count,2];
                for (int i = 0; i < oVariables.Count; i++)
                {
                    vars[i,0] = oVariables.ElementAt(i).getName();
                    vars[i,1] = oVariables.ElementAt(i).getType();
                }
                return vars;
            }
        }

        public string getCCode()
        {
            string aCSLines ="";
            
            foreach (Statement oTempObject in oStatements)
            {
                aCSLines += oTempObject.getCCode() + Environment.NewLine;
            }

            return aCSLines;
        }

        public string getUserCode()
        {
            string aCSLines="";
            
            foreach (Statement oTempObject in oStatements)
            {
                aCSLines += oTempObject.getUserCode(oUserLanguage) + Environment.NewLine;

            }

            return aCSLines;
        }

        public string getName()
        {
            return sName;
        }
        public void editStatement(int iIndex)
        {
            if (oStatements[iIndex].getStatementType() == "assign")
            {
                AssignStatement Temp = oStatements[iIndex] as AssignStatement;
                //HERE IS THE FORM EDITING
                oStatements[iIndex] = Temp;
            }
            else if (oStatements[iIndex].getStatementType() == "variable")
            {
                VarInitStatement Temp = oStatements[iIndex] as VarInitStatement;
                //HERE IS THE FORM EDITING
                oStatements[iIndex] = Temp;
            }
            else if (oStatements[iIndex].getStatementType() == "output")
            {
                OutputStatement Temp = oStatements[iIndex] as OutputStatement;
                //HERE IS THE FORM EDITING
                oStatements[iIndex] = Temp;
            }
            else if (oStatements[iIndex].getStatementType() == "input")
            {
                InputStatement Temp = oStatements[iIndex] as InputStatement;
                //HERE IS THE FORM EDITING
                oStatements[iIndex] = Temp;
            }
            else if (oStatements[iIndex].getStatementType() == "if")
            {
                IfStatement Temp = oStatements[iIndex] as IfStatement;
                //HERE IS THE FORM EDITING
                oStatements[iIndex] = Temp;
            }
            else if (oStatements[iIndex].getStatementType() == "while")
            {
                WhileStatement Temp = oStatements[iIndex] as WhileStatement;
                //HERE IS THE FORM EDITING
                oStatements[iIndex] = Temp;
            }

        }
    }
}
