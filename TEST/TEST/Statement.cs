using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
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

    class OutputStatement : Statement
    {
        //Fields
        private String outputString;

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
    }

    class InputStatement : Statement
    {
        //Fields
        private string messageString;
        private string varTo;


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

        
    }

    class AssignStatement : Statement
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

       /* //Constructor for progObject assigned from progObject - Can this be used for example to do a=b?
        public AssignStatement(string AssignTo, string AssignFrom)
        {
            aFrom = AssignFrom;
            aTo = AssignTo;
        }*/

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
    }

    class CalcStatement : Statement
    {
        //Fields
        private Expression express;
        private String assignTo;

        //Constructor - Overrides parent class
        public CalcStatement(string assignTo, Expression assignFrom)
        {
            express = assignFrom;
            this.assignTo = assignTo;
        }


        public override String getUserCode()
        {
            String Code;
            Code = "Calculate [" + express.ToString() +"] and store the result as [" + assignTo +"]";
            return Code;
        }

        public override String getJCode()
        {
            String Code;
            Code = assignTo +" = " + express.ToString() + ";";
            return Code;
        }
    }

    class IfStatement : Statement
    {
        //Fields
        private Expression conditional;
        private Statement ifTrue;
 
        //Constructor
        public IfStatement ()
        {

        }

        public string getJCode()
        {
            return "If \u2610 Do \u2610\r\n";
        }

        public string getCCode()
        {
            return "If \u2610 Do \u2610\r\n";
        }

        public string getUserCode()
        {
            return "If \u2610 Do \u2610\r\n";

        }
    }

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
    }

    class Variable
    {

        //Fields
        private int type; //type of datatype this object is. 1=int, 2=char, 3=string
        private String name;
        private String value;


        //constructor
        public Variable(int type, string name, String value)
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

        public int getType()
        {
            return type;
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
    
    class Expression  //Class used to create any expressions
    {
        // Fields
        string left;
        string right;
        string operation;


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
    }


}
