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
           // Name = StatementName;
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
        public OutputStatement()
        {
            outputString = Microsoft.VisualBasic.Interaction.InputBox("Enter value to output to user", "Output Value");
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
        public AssignStatement()
        {
            
            string toVar = Microsoft.VisualBasic.Interaction.InputBox("Enter variable to assign expression to:\r\n", "Enter assignment");
            express = new Expression();
            assignTo = toVar;

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
        private Conditional conditional;
        private AssignStatement ifTrue;
 
        //Generic constructor
        public IfStatement()
        {
            conditional = new Conditional();
            ifTrue = new AssignStatement();

        }
        
        //Constructor
        public IfStatement (Conditional cond, AssignStatement statements)
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
            return "if (" + conditional.ToString() + ") {" + ifTrue.getJCode() + "};\r\n";
        }

        public string getUserCode()
        {
            return "If [ " + conditional.ToString() + " ] Do [ " + ifTrue.getJCode() + " ]\r\n";

        }

        internal string getCon()
        {
            throw new NotImplementedException();
        }

        internal string getStatements()
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    class WhileStatement : Statement
    {
        //Fields
        private Expression conditional;
        private Statement ifTrue;
 
        //Constructor
        public WhileStatement ()
        {

        }

        public string getJCode()
        {
            return "While \u2610 Do \u2610\r\n";
        }

        public string getCCode()
        {
            return "While \u2610 Do \u2610\r\n";
        }

        public string getUserCode()
        {
            return "While \u2610 Do \u2610\r\n";

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
        public VarInitStatement()
        {
            int varType = 0;
            while (varType == 0 || varType > 3)
            {
                int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Enter varible type:\r\n 1 = integer\r\n 2 = character\r\n 3 = string", "Variable type"), out varType);
                //display to user that selection didnt match 1, 2, or 3
            }
            string varName = Microsoft.VisualBasic.Interaction.InputBox("Enter varible name:", "Variable Name");
            //string varVal = Microsoft.VisualBasic.Interaction.InputBox("Enter varible value:", "Variable Value");
            Variable varObject = new Variable(varType, varName);
            var = varObject;
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
        public Variable(int type, string name)
        {
            this.value = value;
            this.name = name;
            this.type = type;

        }

        public String getJCode()
        {
            return name;
            //return String.valueOf(value);
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

        public AssignStatement getStatement()
        {
            //AssignStatement a = new AssignStatement(this, this.getValue(), this.name, i);
            Expression e = new Expression(this.getValue());
            AssignStatement a = new AssignStatement(name, e);
            return a;
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
        public Expression()
        {
            String type = "";
            while(type != "S" && type != "s" && type != "Simple" && type != "C" && type != "c" && type!= "Complex")
            {
             type = Microsoft.VisualBasic.Interaction.InputBox("Enter (S)imple or (C)omplex expression: ", "Enter type");
            }
            if (type == "S" || type == "s" || type == "Simple")
            {
                left = Microsoft.VisualBasic.Interaction.InputBox("Enter simple expression: ", "Enter expression");
            }
            else
            {
                left = Microsoft.VisualBasic.Interaction.InputBox("Enter left side of expression: ", "Enter left");
                operation = Microsoft.VisualBasic.Interaction.InputBox("Enter arithmetic operator: \r\n (+, -, *,or  /", "Enter operator");
                right = Microsoft.VisualBasic.Interaction.InputBox("Enter right side of expression: ", "Enter right");
            }
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
            string s = "(" + left + " " + operation + " " + right + ")";
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
        Expression left;
        Expression right;
        string comparator;


        //Constructor for one string
        public Conditional()
        {
            left = new Expression();
            comparator = Microsoft.VisualBasic.Interaction.InputBox("Enter left side of expression: ", "Enter left");
            right = new Expression();

            
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

        public string GetRight()
        {
            string s = right.ToString();
            return s;
        }

        public string GetComparator()
        {
            string s = comparator;
            return s;
        }
    }
}
