using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    [Serializable]
    class Statement
    {
        //Fields
        private String Name;
        private String Icon;	//change to image/icon/shape

        //Constructor method
        public Statement()
        {
            
        }

        //Methods	
        public String GetIcon()
        {//change to image/icon/shape
            return Icon;
        }

        public virtual String getJCode()
        {
            String Code;
            Code = "There should be real code here...This is a generic Java Statement object and something needs fixed.";
            return Code;
        }

        public virtual String getCCode()
        {
            String Code;
            Code = "There should be real code here...This is a generic C# Statement object and something needs fixed.";
            return Code;
        }

        public virtual String getUserCode()
        {
            String Code;
            Code = "There should be real user code here...This is a generic user Statement object and something needs fixed.";
            return Code;
        }
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

        public override String getJCode()
        {
            String Code;
            Code = "System.out.println(" + outputString + ");";
            return Code;
        }

        public override String getCCode()
        {
            String Code;
            Code = "System.out.println(" + outputString + ");";
            return Code;
        }

        public override String getUserCode()
        {
            String Code;
            Code = "Display to user [" + outputString + "]";
            return Code;
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

        //generic constructor
        public InputStatement()
        {
            messageString = Microsoft.VisualBasic.Interaction.InputBox("Enter message to prompt user for input", "Message for user");
            varTo = Microsoft.VisualBasic.Interaction.InputBox("Which Variable would you like to assign user's response to?", "Variable");
        }
        //Constructor - Overrides parent class
        public InputStatement(string message, string varTo)
        {
            messageString = message;
            this.varTo = varTo;
        }

                public override String getJCode()
        {
            String Code;
            Code = "System.out.println(\"" + messageString + "\"); Scanner in = new Scanner(System.in); String " + varTo + " = in.next();";
            return Code;
        }

        public override String getCCode()
        {
            String Code;
            Code = "string input = Microsoft.VisualBasic.Interaction.InputBox(" + messageString + ", \"Input\");";
            return Code;
        }

        public override String getUserCode()
        {
            String Code;
            Code = "Ask user for input with message [" + messageString + "] and store result as [ " + varTo + " ]";
            return Code;
        }



        internal string getVar()
        {
            throw new NotImplementedException();
        }
    }
    
    /*
     [serializable]
     class badAssignStatement : Statement
    {

        //Fields
        private string aTo;
        private Expression aFrom;

        //Constructor for progObject assigned from expression
        public AssignStatement(string AssignTo, Expression AssignFrom)
        {
            aFrom = AssignFrom;
            aTo = AssignTo;
        }



        public override String getJCode()
        {
            String Code;
            Code = aTo + " = " + aFrom.ToString() + ";";
            return Code;
        }

        public override String getUserCode()
        {
            String Code;
            Code = "Declare variable [" + aTo.ToString() + "] to be equal to [" + aFrom.GetLeft()+ "]";
            return Code;
        }
    }*/

     
    [Serializable]
    class AssignStatement : Statement
    {
        //Fields
        private Expression express;
        private String assignTo;

        //generic Constructor
        public AssignStatement(string[] ExistingVarList)
        {
            
            //assignTo = Microsoft.VisualBasic.Interaction.InputBox("Enter variable to assign expression to:\r\n", "Enter assignment");
            
            //VariableSelection Varform = new VariableSelection(ExistingVarList);
            //Varform.ShowDialog();
            NewExpressionForm expressform = new NewExpressionForm(ExistingVarList);
            expressform.ShowDialog();
            express = new Expression(expressform.left, expressform.oper, expressform.right);
            assignTo = expressform.varTo;
        }

        //Constructor - Overrides parent class
        public AssignStatement(string assignTo, Expression assignFrom)
        {
            express = assignFrom;
            this.assignTo = assignTo;
        }


        public override String getUserCode()
        {
            String Code;
            Code = "Calculate [ " + express.ToString() +" ] and store the result as [ " + assignTo +" ]";
            return Code;
        }

        public override String getJCode()
        {
            String Code;
            Code = assignTo +" = " + express.ToString() + ";";
            return Code;
        }

        public override String getCCode()
        {
            String Code;
            Code = assignTo + " = " + express.ToString() + ";";
            return Code;
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
        private Conditional bob;
 
        //Generic constructor
        public IfStatement(string[] ExistingVarList)
        {
            conditional = new Conditional(ExistingVarList);
            stmtlist = new List<Statement>();
            VarInitStatement stat1 = new VarInitStatement(ExistingVarList);
            stmtlist.Add(stat1);

        }
        
        public override string getJCode()
        {

            codeString = "if " + conditional.ToString() + " do {";
            foreach (Statement stat in stmtlist)
            {
                codeString += stat.GetType();
            }
            codeString += "}";

            return codeString;
        }

        public override string getCCode()
        {
            codeString = "if " + conditional.ToString() +  " do {";
            foreach (Statement stat in stmtlist)
            {
                codeString += stat.GetType();
            }
            codeString += "}";

            return codeString;
        }

        public override string getUserCode()
        {
            codeString = "if " + conditional.ToString() + " do {";
            foreach (Statement stat in stmtlist)
            {
                codeString += stat.GetType();
            }
            codeString += "}";

            return codeString;
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
        private Conditional conditional;
        private Statement ifTrue;
 
        //Fields
        private Conditional cond;
        //private Statement iftrue;
        private List<Statement> stmtlist;

        //Generic constructor
        public WhileStatement(string[] ExistingVarList)
        {
            cond = new Conditional(ExistingVarList);
            //Statement tempstat = new Statement();
            // Ask user which type of statment they want to create and create one based on that.
            string statType = Microsoft.VisualBasic.Interaction.InputBox("Enter the type of statement you would like to add\r\n (V)ariable initialization\r\n(A)ssignment\r\n(I)nput\r\n(O)utput\r\n(If)\r\n(W)hile", "Statement Type");
            if (statType == "v" || statType == "V")
            {
                VarInitStatement varStat = new VarInitStatement(ExistingVarList);
                stmtlist.Add(varStat);
            }
            else if (statType == "a" || statType == "A")
            {
                AssignStatement assignstat = new AssignStatement(ExistingVarList);
                stmtlist.Add(assignstat);
            }
            else if (statType == "i" || statType == "I")
            {
                AssignStatement instat = new AssignStatement(ExistingVarList);
                stmtlist.Add(instat);
            }
            else if (statType == "o" || statType == "O")
            {
                AssignStatement outstat = new AssignStatement(ExistingVarList);
                stmtlist.Add(outstat);
            }
            else if (statType == "if" || statType == "IF" || statType == "If")
            {
                AssignStatement ifstat = new AssignStatement(ExistingVarList);
                stmtlist.Add(ifstat);
            }
            else if (statType == "w" || statType == "W")
            {
                AssignStatement whilestat = new AssignStatement(ExistingVarList);
                stmtlist.Add(whilestat);
            }

        }
        
        //Constructor
        public WhileStatement (Conditional cond, AssignStatement statements)
        {
            this.conditional = cond;
            this.ifTrue = statements;
        }

        public string getJCode()
        {
            return "if (" + conditional.ToString() + ") {" + ifTrue.getJCode() + "};\r\n";
        }

        public string getCCode()
        {
            return "if (" + conditional.ToString() + ") {" + ifTrue.getCCode() + "};\r\n";
        }

        public string getUserCode()
        {
            return "If [ " + conditional.ToString() + " ] Do [ " + ifTrue.getCCode() + " ]\r\n";

        }

        internal string getConditional()
        {
            return cond.ToString();
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
            NewVariableform varform = new NewVariableform(ExistingVarList);
            varform.ShowDialog();
            var = new Variable(varform.type, varform.name);
            
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

        public override String getJCode()
        {
            string vartype = var.getType();
            string varname = var.getName();
            string code = vartype + " " + varname + ";"; 
            return code;
        }

        public override String getCCode()
        {
            string vartype = var.getType();
            string varname = var.getName();
            string code = vartype + " " + varname + ";";
            return code;
        }

        public override String getUserCode()
        {
            string vartype = var.getType();
            string varname = var.getName();
            string code = "Declare variable named [ " + varname + " ] as type [ " + vartype + " ]";
            return code;
        }
    }
    
    [Serializable]
    class Variable
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
    
    [Serializable]
    class Expression  //Class used to create any expressions
    {
        // Fields
        string left;
        string right;
        string operation;

        //generic constructor
        public Expression(string[] ExistingVarList)
        {
            
            
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

        public string ToString()
        {
            //string s = "(" + left + " " + operation + " " + right + ")";
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

    [Serializable]
    class Conditional
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

        public string ToString()
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
