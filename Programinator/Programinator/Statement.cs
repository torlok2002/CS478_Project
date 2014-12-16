using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programinator
{
    [Serializable]
    public abstract class Statement
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
    public class OutputStatement : Statement
    {
        //Fields
        private String outputString;
        private bool boolCancel = true;
        private bool boolDelete = false;
        //generic constructor
        public OutputStatement(string[,] ExistingVarList)
        {
            NewOutputForm outform = new NewOutputForm(ExistingVarList);
            outform.ShowDialog();
            boolCancel = outform.Canceled;
            outputString = outform.outtext;
        }

        //Constructor - Overrides parent class
        public OutputStatement(string input)
        {
            outputString = input;
        }
        //constructor for editing an existing object
        public OutputStatement(string[,] ExistingVarList, OutputStatement statin)
        {
            this.outputString = statin.outputString;
            NewOutputForm outform = new NewOutputForm(ExistingVarList, statin);
            outform.ShowDialog();
            this.boolCancel = outform.Canceled;
            this.boolDelete = outform.Deleted;
            outputString = outform.outtext;
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
        public bool Deleted
        {
            get
            {
                return boolDelete;
            }
        }
        public bool Canceled
        {
            get
            {
                return boolCancel;
            }
        }
    }

    [Serializable]
    public class InputStatement : Statement
    {
        //Fields
        public string messageString;
        private string varTo;
        private string varType="";
        private bool boolCancel = true;
        private bool boolDelete = false;
        //generic constructor
        public InputStatement(string[,] existvarlist)
        {
            InputForm inform = new InputForm(existvarlist);
            inform.ShowDialog();
            messageString = inform.message;
            varTo = inform.VarName;
            for (int i = 0; i < existvarlist.GetLength(0); i++)
            {
                if (existvarlist[i, 0] == varTo)
                {
                    varType = existvarlist[i, 1];
                    break;
                }
            }
            boolCancel = inform.Canceled;
            
        }
        //Constructor - Overrides parent class
        public InputStatement(string message, string varTo)
        {
            messageString = message;
            this.varTo = varTo;
        }
        //constructor for editing an existing Statement
        public InputStatement(string[,] ExistingVarList, InputStatement Temp)
        {
            InputForm inform = new InputForm(ExistingVarList, Temp);
            inform.ShowDialog();
            boolCancel = inform.Canceled;
            boolDelete = inform.Deleted;
            messageString = inform.message;
            varTo = inform.VarName;
        }
        public override String getCCode()
        {
            String Code;
            Code = @"IDEQueue.Send("""",""InputRequest" + varType + @""");";
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

        public string getVar()
        {
            return varTo;
        }
        public bool Deleted
        {
            get
            {
                return boolDelete;
            }
        }
        public bool Canceled
        {
            get
            {
                return boolCancel;
            }
        }
    }
     
    [Serializable]
    public class AssignStatement : Statement
    {
        //Fields
        //private Expression express;
        public string express;
        public string assignTo;
        private bool boolCancel = true;
        private bool boolDelete = false;
        //generic Constructor
        public AssignStatement(string[,] ExistingVarList)
        {
            AssignmentForm assignform = new AssignmentForm(ExistingVarList);
            assignform.ShowDialog();
            assignTo = assignform.to;
            //express = assignform.express;//used for passing object
            express = assignform.expressString;//used for passing string
            boolCancel = assignform.Canceled;
        }

        //Constructor - Overrides parent class
        public AssignStatement(string assignTo, Expression assignFrom)
        {
            express = assignFrom.ToString();
            this.assignTo = assignTo;
        }

        //constructor for editing an existing Statement
        public AssignStatement(string[,] ExistingVarList, AssignStatement statIn)
        {
            assignTo = statIn.assignTo;
            express = statIn.express;
            AssignmentForm assform = new AssignmentForm(ExistingVarList, statIn);
            assform.ShowDialog();
            this.boolCancel = assform.Canceled;
            this.boolDelete = assform.Deleted;
            assignTo = assform.to;
            express = assform.expressString;
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
        public bool Deleted
        {
            get
            {
                return boolDelete;
            }
        }
        public bool Canceled
        {
            get
            {
                return boolCancel;
            }
        }

    }

    [Serializable]
    public class IfStatement : Statement
    {
        //Fields
        private string codeString;
        private Conditional conditional;
        private List<Statement> stmtlist;
        private bool boolCancel = true;
        private bool boolDelete = false;
        //Generic constructor
        public IfStatement(string[,] ExistingVarList,Language oLanguage)
        {
            If_WhileForm ifform = new If_WhileForm(ExistingVarList, "If",oLanguage);
            ifform.ShowDialog();
            stmtlist = ifform.getStatlist();
            conditional = ifform.condition;
            boolCancel = ifform.Canceled;
        }
        //constructor for editing an existing Statement
        public IfStatement(string[,] ExistingVarList, Language oLanguage, IfStatement statIn)
        {
            If_WhileForm ifform = new If_WhileForm(ExistingVarList, "If", oLanguage, statIn);
            ifform.ShowDialog();
            stmtlist = ifform.getStatlist();
            conditional = ifform.condition;
            this.boolCancel = ifform.Canceled;
            this.boolDelete = ifform.Deleted;
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
            return conditional.ToString();
        }

        internal Conditional getCon()
        {
            return conditional;
        }
        internal List<Statement> getStatementList()
        {
            return stmtlist;
        }
        public bool Deleted
        {
            get
            {
                return boolDelete;
            }
        }
        public bool Canceled
        {
            get
            {
                return boolCancel;
            }
        }
    }

    [Serializable]
    public class WhileStatement : Statement
    {
        //Fields
        private string codeString;
        private Conditional conditional;
        private List<Statement> stmtlist;
        private bool boolCancel = true;
        private bool boolDelete = false;
        //Generic constructor
        public WhileStatement(string[,] ExistingVarList, Language oLanguage)
        {
            If_WhileForm whileform = new If_WhileForm(ExistingVarList, "While", oLanguage);
            whileform.ShowDialog();
            stmtlist = whileform.getStatlist();
            conditional = whileform.condition;
            boolCancel = whileform.Canceled;
        }
        //constructor for editing an existing Statement
        public WhileStatement(string[,] ExistingVarList, Language oLanguage, WhileStatement statIn)
        {
            If_WhileForm whileform = new If_WhileForm(ExistingVarList, "while", oLanguage, statIn);
            whileform.ShowDialog();
            stmtlist = whileform.getStatlist();
            conditional = whileform.condition;
            this.boolCancel = whileform.Canceled;
            this.boolDelete = whileform.Deleted;
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
            try
            {
                return oLanguage.getLoopStatement(conditional.ToString());
            }
            catch
            {
                return "";
            }

        }
        public override string getStatementType()
        {
            return "while";
        }

        internal Conditional getCon()
        {
            return conditional;
        }

        internal List<Statement> getStatementList()
        {
            return stmtlist;
        }

        internal string getConditonal()
        {
            return conditional.ToString();
        }
        public bool Deleted
        {
            get
            {
                return boolDelete;
            }
        }
        public bool Canceled
        {
            get
            {
                return boolCancel;
            }
        }
    }
    
    [Serializable]
    public class VarInitStatement : Statement
    {
        //fields 
        private Variable var;
        private bool boolCancel = true;
        private bool boolDelete = false;
        //generic constructor
        public VarInitStatement(string[,] ExistingVarList)
        {
            VariableForm varform = new VariableForm(ExistingVarList);
            varform.ShowDialog();
            //if (varform.DialogResult == System.Windows.Forms.DialogResult.OK)
            //{
                var = new Variable(varform.type, varform.name);
            //}
                boolCancel = varform.Canceled;
            
        }

        //constructor
        public VarInitStatement(Variable varin)
        {
            var = varin;
        }

        //constructor for editing an existing object
        public VarInitStatement(string[,] ExistingVarList, VarInitStatement varin)
        {
            //var = varin;
            VariableForm varform = new VariableForm(ExistingVarList, varin);
            
            varform.ShowDialog();
            this.boolCancel = varform.Canceled;
            this.boolDelete = varform.Deleted;
            var = new Variable(varform.type, varform.name);
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
            string varname = var.getName;
            string code = "";
            if (vartype == "int") { code = vartype + " " + varname + " = 0;"; }
            else if (vartype == "string") { code = vartype + " " + varname + " = \"\";"; }
            else if (vartype == "char") { code = vartype + " " + varname + " = ' ';"; }
            
            return code;
        }

        public override String getUserCode(Language oLanguage)
        {
            return oLanguage.getVariableStatement(var.getName, var.getType());
        }
        public override string getStatementType()
        {
            return "variable";
        }
        public bool Deleted
        {
            get
            {
                return boolDelete;
            }
        }
        public bool Canceled
        {
            get
            {
                return boolCancel;
            }
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

        public String getName
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
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
        public Expression(string[,] ExistingVarList)
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
        public string left;
        public string right;
        public string comparator;


        //Constructor for one string
        public Conditional(string[,] ExistingVarList)
        {
            ConditionalForm condform = new ConditionalForm(ExistingVarList);
            condform.ShowDialog();
            left = condform.left;
            comparator = condform.oper;
            right = condform.right;

        }
        //Constructor to Modify an Existing Conditional
        public Conditional(string[,] ExistingVarList, Conditional ExistCond)
        {
            ConditionalForm condform = new ConditionalForm(ExistingVarList, ExistCond);
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
