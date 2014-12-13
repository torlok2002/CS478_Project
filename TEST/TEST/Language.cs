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
        
        public Language(String Name)
        {
            //Load Language Structure
            String[] lines;
            try
            {
                 lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\Languages\\" + Name + ".Language");
            }
            catch
            {
                lines = new string[] { };
            }
            foreach (String line in lines)
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
        public String[] getHotkeys()
        {
            String[] aHotkeys = new String[5];
            if (assignmentStatement != "") { aHotkeys[0] = assignmentStatement.Split(',').ElementAt(0); }
            if (branchStatement     != "") { aHotkeys[1] = branchStatement.Split(',').ElementAt(0);     }
            if (loopStatement       != "") { aHotkeys[2] = loopStatement.Split(',').ElementAt(0);       }
            if (inputStatement      != "") { aHotkeys[3] = inputStatement.Split(',').ElementAt(0);      }
            if (outputStatement     != "") { aHotkeys[4] = outputStatement.Split(',').ElementAt(0);     }
            if (variableStatement   != "") { aHotkeys[5] = outputStatement.Split(',').ElementAt(0);     }
            return aHotkeys;
        }
    }
}
