using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class ArithStatement:Statement
    {
        //Fields
	private String operA;
	private String operB;
	private String operator1;
	
	//Constructor - Overrides parent class
	public ArithStatement(	progObject OperandA, progObject OperandB, String Operator, String StatementName):base (StatementName)
    {
		operA = OperandA.getJCode();
		operB = OperandB.getJCode();
		operator1 = Operator;
				
	}
		
		
		
		
	public override String getJCode(){
		String Code;
		Code = "(" + operA + " " + operator1 + " " + operB+")";
		return Code;
		}
    }
}
