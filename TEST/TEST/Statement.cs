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
        public Statement(String StatementName)
        {
            Name = StatementName;
        }

        //Methods	
        public String GetIcon()
        {//change to image/icon/shape
            return Icon;
        }

        public String GetName()
        {
            return Name;
        }

        public String toString()
        {
            return Name;
        }

        public virtual String getJCode()
        {
            String Code;
            Code = "There should be real code here...This is a generic Statement object and something needs fixed.";
            return Code;
        }
    }

    class OutputStatement : Statement
    {
        //Fields
        private String outputString;


        //Constructor - Overrides parent class
        public OutputStatement(progObject input, String StatementName)
            : base(StatementName)
        {
            outputString = input.getJCode();
        }

        //Constructor - Overrides parent class
        public OutputStatement(Statement input, String StatementName)
            : base(StatementName)
        {
            outputString = input.getJCode();
        }



        public override String getJCode()
        {
            String Code;
            Code = "System.out.println(" + outputString + ");";
            return Code;
        }

        public String getOutput()
        {
            return outputString;
        }
    }

    class AssignStatement : Statement
    {

        //Fields
        private String aTo;
        private String aFrom;
        private bool varInit = false;
        private String dataType;

        //Constructor for progObject/progObject - Overrides parent class
        public AssignStatement(progObject AssignTo, progObject AssignFrom, String StatementName)
            : base(StatementName)
        {
            //super(StatementName);

            aFrom = AssignFrom.getJCode();
            aTo = AssignTo.getJCode();
        }

        //Constructor for Statement/Statement - Overrides parent class
        public AssignStatement(Statement AssignTo, Statement AssignFrom, String StatementName)
            : base(StatementName)
        {
            aFrom = AssignFrom.getJCode();
            aTo = AssignTo.getJCode();
        }

        //Constructor for Statement/progObject - Overrides parent class
        public AssignStatement(Statement AssignTo, progObject AssignFrom, String StatementName)
            : base(StatementName)
        {
            aFrom = AssignFrom.getJCode();
            aTo = AssignTo.getJCode();
        }

        //Constructor for progObject/statement - Overrides parent class
        public AssignStatement(progObject AssignTo, Statement AssignFrom, String StatementName)
            : base(StatementName)
        {
            aFrom = AssignFrom.getJCode();
            aTo = AssignTo.getJCode();
        }

        //Constructor for progObject/int - Overrides parent class
        public AssignStatement(progObject AssignTo, String AssignFrom, String StatementName)
            : base(StatementName)
        {
            //aFrom = String.valueOf(AssignFrom);
            aFrom = AssignFrom.ToString();
            aTo = AssignTo.getJCode();
        }

        //Constructor for progObject/int - Overrides parent class
        public AssignStatement(progObject AssignTo, String AssignFrom, String StatementName, String type)
            : base(StatementName)
        {
            //aFrom = String.valueOf(AssignFrom);
            aFrom = AssignFrom.ToString();
            aTo = AssignTo.getJCode();
            varInit = true;
            dataType = type;
        }

        public override String getJCode()
        {
            String Code;
            if (varInit == false) Code = aTo + " = " + aFrom + ";";
            else Code = dataType + " " + aTo + " = " + aFrom + ";";
            return Code;
        }
    }

    class ArithStatement : Statement
    {
        //Fields
        private String operA;
        private String operB;
        private String operator1;

        //Constructor - Overrides parent class
        public ArithStatement(progObject OperandA, progObject OperandB, String Operator, String StatementName)
            : base(StatementName)
        {
            operA = OperandA.getJCode();
            operB = OperandB.getJCode();
            operator1 = Operator;

        }




        public override String getJCode()
        {
            String Code;
            Code = "(" + operA + " " + operator1 + " " + operB + ")";
            return Code;
        }
    }

    class progObject
    {

        //Fields
        private String name;
        private String value;
        private int type; //type of datatype this object is. 1=int, 2=char, 3=string


        //constructor
        public progObject(String name, int type)
        {
            //this.value = 0;
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
            String i = "";
            if (this.getType() == 1) i = "int";
            else if (this.getType() == 2) i = "char";
            else if (this.getType() == 3) i = "String";
            AssignStatement a = new AssignStatement(this, this.getValue(), this.name, i);
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
}
