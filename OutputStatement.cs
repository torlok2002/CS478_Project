using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class OutputStatement:Statement
    {
        //Fields
        private String outputString;


        //Constructor - Overrides parent class
        public OutputStatement(progObject input, String StatementName):base (StatementName)
        {
            outputString = input.getJCode();
        }

        //Constructor - Overrides parent class
        public OutputStatement(Statement input, String StatementName):base (StatementName)
        {
            outputString = input.getJCode();
        }



        public String getJCode()
        {
            String Code;
            Code = "System.out.println(" + outputString + ");";
            return Code;
        }
    }
}
