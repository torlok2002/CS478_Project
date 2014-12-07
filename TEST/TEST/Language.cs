using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TEST
{
    class Language
    {
        String assignmentStatement = "", branchStatement = "", loopStatement = "", inputStatement = "", outputStatement = "", variableStatement = "";
        
        public Language(String Name)
        {
            //Load Language Structure
            String[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\Languages\\" + Name + ".Language");
            foreach (String line in lines)
            {
                switch (line.Split(',').ElementAt(1))
                {
                    //case "Variable":
                    //    variableStatement = line;
                    //    break;
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
        
        public string getAssignStatement(AssignStatement Assign)
        {
            String tempString = assignmentStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Var>", Assign.getVar());
            tempString = tempString.Replace("<Exp>", Assign.getExp());
            return tempString;
        }
        public string getBranchStatement(IfStatement Branch)
        {
            String tempString = branchStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Con>", Branch.getCon());
            tempString = tempString.Replace("<Sta>", Branch.getStatements());
            return tempString;
        }
        public string getLoopStatement(WhileStatement Loop)
        {
            String tempString = loopStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Con>", Loop.getCon());
            tempString = tempString.Replace("<Sta>", Loop.getStatements());
            return tempString;
        }
        public string getInputStatement(InputStatement Input)
        {
            String tempString = inputStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Var>", Input.getVar());
            return tempString;
        }
        public string getOutputStatement(OutputStatement Output)
        {
            String tempString = outputStatement.Split(',').ElementAt(2);
            tempString = tempString.Replace("<Var>", Output.getVar());
            return tempString;
        }
        public String[] getHotkeys()
        {
            String[] aHotkeys = new String[4];
            if (assignmentStatement != "") { aHotkeys[0] = assignmentStatement.Split(',').ElementAt(0); }
            if (branchStatement     != "") { aHotkeys[1] = branchStatement.Split(',').ElementAt(0);     }
            if (loopStatement       != "") { aHotkeys[2] = loopStatement.Split(',').ElementAt(0);       }
            if (inputStatement      != "") { aHotkeys[3] = inputStatement.Split(',').ElementAt(0);      }
            if (outputStatement     != "") { aHotkeys[4] = outputStatement.Split(',').ElementAt(0);     }
            return aHotkeys;
        }
    }
}
