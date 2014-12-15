using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TEST
{
    [Serializable]
    public class Language
    {
        String assignmentStatement = "", branchStatement = "", loopStatement = "", inputStatement = "", outputStatement = "", variableStatement = "";
        String Name;
        public Language(String Name)
        {
            //Load Language Structure
            this.Name = Name;
            String[] lines;
            try
            {
                 lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\Languages\\" + Name + ".Language");
            }
            catch
            {
                lines = new string[] { };
            }
            SetDefinition(lines);
        }
        public void SetDefinition(String[] lines)
        {
            foreach (String line in lines)
            {
                if (line != "")
                {
                    switch (line.Split(',').ElementAt(1))
                    {
                        case "Variable":
                            variableStatement = line;
                            break;
                        case "Assignment":
                            assignmentStatement = line;
                            break;
                        case "Branch":
                            branchStatement = line;
                            break;
                        case "Loop":
                            loopStatement = line;
                            break;
                        case "Input":
                            inputStatement = line;
                            break;
                        case "Output":
                            outputStatement = line;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void Save()
        {
            String[] lines = new string[] 
            { 
                variableStatement,assignmentStatement,branchStatement,loopStatement,inputStatement,outputStatement
            };
            for (int i = 0; i < lines.Length; i++ )
            {
                if (lines[i].Substring(0, 1) == "," && lines[i].Substring(lines[i].Length-1, 1) == ",")
                {
                    lines[i] = "";
                }
            }
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\Languages\\" + Name + ".Language", lines);
        }
        public string getAssignStatement(string sVar, string sExp)
        {
            String tempString = assignmentStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Var>", sVar);
            tempString = tempString.Replace("<Exp>", sExp);
            return tempString;
        }
        public string getBranchStatement(string sCon)
        {
            String tempString = branchStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Con>", sCon);
            tempString = tempString.Replace("<Sta>", "\u2610");
            return tempString;
        }
        public string getLoopStatement(string sCon)
        {
            String tempString = loopStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Con>", sCon);
            tempString = tempString.Replace("<Sta>", "\u2610");
            return tempString;
        }
        public string getInputStatement(string sVar)
        {
            String tempString = inputStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Var>", sVar);
            return tempString;
        }
        public string getOutputStatement(string sVar)
        {
            String tempString = outputStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Var>", sVar);
            return tempString;
        }
        public string getVariableStatement(string sVar, string sType)
        {
            String tempString = variableStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Var>", sVar);
            tempString = tempString.Replace("<Typ>", sType);
            return tempString;
        }
        public char[] getHotkeys()
        {
            char[] aHotkeys = new char[6];
            if (assignmentStatement != "") { aHotkeys[0] = assignmentStatement.Split(',').ElementAt(0).ToCharArray().ElementAt(0); } else aHotkeys[0] = '\u20E0';
            if (branchStatement != "") { aHotkeys[1] = branchStatement.Split(',').ElementAt(0).ToCharArray().ElementAt(0); } else aHotkeys[1] = '\u20E0';
            if (loopStatement != "") { aHotkeys[2] = loopStatement.Split(',').ElementAt(0).ToCharArray().ElementAt(0); } else aHotkeys[2] = '\u20E0';
            if (inputStatement != "") { aHotkeys[3] = inputStatement.Split(',').ElementAt(0).ToCharArray().ElementAt(0); } else aHotkeys[3] = '\u20E0';
            if (outputStatement != "") { aHotkeys[4] = outputStatement.Split(',').ElementAt(0).ToCharArray().ElementAt(0); } else aHotkeys[4] = '\u20E0';
            if (variableStatement != "") { aHotkeys[5] = variableStatement.Split(',').ElementAt(0).ToCharArray().ElementAt(0); } else aHotkeys[5] = '\u20E0';
            return aHotkeys;
        }
        public string[] getTemplates()
        {
            string[] aTemplates = new string[6];
            if (assignmentStatement != "") { aTemplates[0] = assignmentStatement.Split(',').ElementAt(2); } else aTemplates[0] = "";
            if (branchStatement != "") { aTemplates[1] = branchStatement.Split(',').ElementAt(2); } else aTemplates[1] = "";
            if (loopStatement != "") { aTemplates[2] = loopStatement.Split(',').ElementAt(2); } else aTemplates[2] = "";
            if (inputStatement != "") { aTemplates[3] = inputStatement.Split(',').ElementAt(2); } else aTemplates[3] = "";
            if (outputStatement != "") { aTemplates[4] = outputStatement.Split(',').ElementAt(2); } else aTemplates[4] = "";
            if (variableStatement != "") { aTemplates[5] = variableStatement.Split(',').ElementAt(2); } else aTemplates[5] = "";
            return aTemplates;
        }
    }
}
