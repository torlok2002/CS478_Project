using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    [Serializable]
    abstract class Statement
    {

        //Constructor method
        public Statement()
        {
            
        }


        //Methods	
        public abstract String getCCode();

        public abstract String getUserCode(Language oLanguage);

        public abstract String getStatementType();
    }

    [Serializable]
    class OutputStatement : Statement
    {
        //Fields
        private String outputString;

        //generic constructor
        public OutputStatement(string[] ExistingVarList)
        {
            NewOutputForm outform = new NewOutputForm(ExistingVarList);
            outform.ShowDialog();
            outputString = outform.outtext;
        }

        //Constructor - Overrides parent class
        public OutputStatement(string input)
        {
            outputString = input;
        }

        public override String getCCode()
        {
            String Code;
            Code = "IDEQueue.Send(" + outputString + @"+"""",""Output"");";
            return Code;
        }

        public override String getUserCode(Language oLanguage)
        {
            return oLanguage.getOutputStatement(outputString);
        }

        public override string getStatementType()
        {
            return "output";
        }

        public String getOutput()
        {
            return outputString;
        }

        internal string getVar()
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    class InputStatement : Statement
    {
        //Fields
        private string messageString;
        private string varTo;
        private string varType="";

        //generic constructor
        public InputStatement(string[] existvarlist)
        {
            InputForm inform = new InputForm(existvarlist);
            inform.ShowDialog();
            messageString = inform.message;
            varTo = inform.VarName;
            
        }
        //Constructor - Overrides parent class
        public InputStatement(string message, string varTo, string varType)
        {
            messageString = message;
            this.varTo = varTo;
        }

        public override String getCCode()
        {
            String Code;
            Code = @"IDEQueue.Send("""",""InputRequest" + varType + @""");\n";
            if (varType == "int") { Code += varTo + @" = int.Parse(GetMessage().Body.ToString()); "; }
            else if (varType == "string") { Code += varTo + @" = GetMessage().Body.ToString(); "; }
            else if (varType == "char") { Code += varTo + @" = GetMessage().Body.ToString().ToCharArray().ElementAt(0); "; }
            return Code;
        }

        public override String getUserCode(Language oLanguage)
        {
            return oLanguage.getInputStatement(varTo);
        }

        public override string getStatementType()
        {
            return "input";
        }

        internal string getVar()
        {
            throw new NotImplementedException();
        }
    }
     
    [Serializable]
    class AssignStatement : Statement
    {
        //Fields
        //private Expression express;
        private string express;
        private string assignTo;

        //generic Constructor
        public AssignStatement(string[] ExistingVarList)
        {
            AssignmentForm assignform = new AssignmentForm(ExistingVarList);
            assignform.ShowDialog();
            assignTo = assignform.to;
            //express = assignform.express;//used for passing object
            express = assignform.expressString;//used for passing string
        }

        //Constructor - Overrides parent class
        public AssignStatement(string assignTo, Expression assignFrom)
        {
            express = assignFrom.ToString();
            this.assignTo = assignTo;
        }


        public override String getUserCode(Language oLanguage)
        {
            return oLanguage.getAssignStatement(assignTo,express);
        }

        public override String getCCode()
        {
            String Code;
            Code = assignTo + " = " + express.ToString() + ";";
            return Code;
        }

        public override string getStatementType()
        {
            return "assign";
        }

        internal string getVar()
        {
            throw new NotImplementedException();
        }

        internal string getExp()
        {
            throw new NotImplementedException();
        }


    }

    [Serializable]
    class IfStatement : Statement
    {
        //Fields
        private string codeString;
        private Conditional conditional;
        private List<Statement> stmtlist;
 
        //Generic constructor
        public IfStatement(string[] ExistingVarList,Language oLanguage)
        {
            If_WhileForm ifform = new If_WhileForm(ExistingVarList, "If",oLanguage);
            ifform.ShowDialog();
            stmtlist = ifform.getStatlist();
            conditional = ifform.condition;

        }

        public override string getCCode()
        {
            codeString = "if " + conditional.ToString() +  " {";
            foreach (Statement stat in stmtlist)
            {
                codeString += stat.getCCode();
            }
            codeString += "}";

            return codeString;
        }

        public override string getUserCode(Language oLanguage)
        {
            return oLanguage.getBranchStatement(conditional.ToString());
        }
        public override string getStatementType()
        {
            return "if";
        }
        internal string getConditonal()
        {
            throw new NotImplementedException();
        }

        internal string getStatements()
        {
            throw new NotImplementedException();
        }

        internal string getCon()
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    class WhileStatement : Statement
    {
        //Fields
        private string codeString;
        private Conditional conditional;
        private List<Statement> stmtlist;

        //Generic constructor
        public WhileStatement(string[] ExistingVarList, Language oLanguage)
        {
            If_WhileForm whileform = new If_WhileForm(ExistingVarList, "While", oLanguage);
            whileform.ShowDialog();
            stmtlist = whileform.getStatlist();
            conditional = whileform.condition;

        }
        
        public override string getCCode()
        {
            codeString = "while " + conditional.ToString() + " {";
            foreach (Statement stat in stmtlist)
            {
                codeString += stat.getCCode();
            }
            codeString += "}";

            return codeString;
        }

        public override string getUserCode(Language oLanguage)
        {
            return oLanguage.getLoopStatement(conditional.ToString());

        }
        public override string getStatementType()
        {
            return "while";
        }

        internal string getConditional()
        {
            throw new NotImplementedException();
        }

        internal string getStatements()
        {
            throw new NotImplementedException();
        }


        internal string getCon()
        {
            throw new NotImplementedException();
        }
    }
    
    [Serializable]
    class VarInitStatement : Statement
    {
        //fields 
        private Variable var;
        

        //generic constructor
        public VarInitStatement(string[] ExistingVarList)
        {
            VariableForm varform = new VariableForm(ExistingVarList);
            varform.ShowDialog();
            //if (varform.DialogResult == System.Windows.Forms.DialogResult.OK)
            //{
                var = new Variable(varform.type, varform.name);
            //}
            
            
        }

        //constructor
        public VarInitStatement(Variable varin)
        {
            var = varin;
        }

        public Variable GetVar()
        {
            return var;
        }

        public void SetVar(Variable varin)
        {
            var = varin;
        } 

        public override String getCCode()
        {
            string vartype = var.getType();
            string varname = var.getName();
            string code = vartype + " " + varname + ";";
            return code;
        }

        public override String getUserCode(Language oLanguage)
        {
            return oLanguage.getVariableStatement(var.getName(), var.getType());
        }
        public override string getStatementType()
        {
            return "variable";
        }
    }
    
    [Serializable]
    public class Variable
    {

        //Fields
        private int type; //type of datatype this object is. 1=int, 2=char, 3=string
        private String name;
        private String value;


        //constructor
        public Variable(int type, string nam)
        {
            this.name = nam;
            this.type = type;
        }

        public String getJCode()
        {
            return name;
        }

        public String getCCode()
        {
            return name;
        }

        public string getType()
        {
            string typestr;
            if (type == 1) { typestr = "int";}
            else if(type == 2){typestr = "char";}
            else { typestr = "string"; }
            return typestr;
        }

        public String getName()
        {
            return name;
        }

        public void setValue(String value)
        {
            this.value = value;
        }

        public String getValue()
        {
            return value;
        }

    }

    //Class used to create any expressions
    [Serializable]
    public class Expression  
    {
        // Fields
        string left;
        string right;
        string operation;

        //generic constructor
        public Expression(string[] ExistingVarList)
        {
            ExpressionForm expform = new ExpressionForm(ExistingVarList);
            expform.ShowDialog();
            left = expform.left;
            operation = expform.oper;
            right = expform.right;
            
        }

        //Constructor for one string
        public Expression(string only)
        {
            this.left = only;
        }


        //Constructor for left expression
        public Expression(Expression left, string operation, string right)
        {
            this.left = left.ToString();
            this.right = right;
            this.operation = operation;
        }

        //Constructor for right expression
        public Expression(string left, string operation, Expression right)
        {
            this.left = left;
            this.right = right.ToString();
            this.operation = operation;
        }

        //Constructor for both expression
        public Expression(Expression left, string operation, Expression right)
        {
            this.left = left.ToString();
            this.right = right.ToString();
            this.operation = operation;
        }

        //Constructor for both Strings
        public Expression(string left, string operation, string right)
        {
            this.left = left;
            this.right = right;
            this.operation = operation;
        }

        public override string ToString()
        {
            string s = "(" + left + operation + right + ")";
            return s;
        }

        public string GetLeft()
        {
            string s = left.ToString();
            return s;
        }

        public string GetRight()
        {
            string s = right.ToString();
            return s;
        }

        public string GetOperation()
        {
            return operation;
        }


    }

    //Class used to create conditionals used for if/while statements
    [Serializable]
    public class Conditional
    {
        // Fields
        string left;
        string right;
        string comparator;


        //Constructor for one string
        public Conditional(string[] ExistingVarList)
        {
            ConditionalForm condform = new ConditionalForm(ExistingVarList);
            condform.ShowDialog();
            left = condform.left;
            comparator = condform.oper;
            right = condform.right;

        }


        /*//Constructor for left expression
        public Conditional(Expression left, string comparator, string right)
        {
            this.left = left.ToString();
            this.right = right;
            this.comparator = comparator;
        }

        //Constructor for right expression
        public Conditional(string left, string comparator, Expression right)
        {
            this.left = left;
            this.right = right.ToString();
            this.comparator = comparator;
        }

        //Constructor for both expression
        public Conditional(Expression left, string comparator, Expression right)
        {
            this.left = left.ToString();
            this.right = right.ToString();
            this.comparator = comparator;
        }

        //Constructor for both Strings
        public Conditional(string left, string comparator, string right)
        {
            this.left = left;
            this.right = right;
            this.comparator = comparator;
        }*/

        public override string ToString()
        {
            string s = "(" + left + " " + comparator + " " + right + ")";
            return s;
        }

        public string GetLeft()
        {
            string s = left.ToString();
            return s;
        }

        public void SetLeft(string l)
        {
            left = l;
        }

        public string GetRight()
        {
            string s = right.ToString();
            return s;
        }

        public void SetRight(string r)
        {
            right = r;
        }

        public string GetComparator()
        {
            string s = comparator;
            return s;
        }
    } 


}
