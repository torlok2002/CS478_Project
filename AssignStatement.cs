using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class AssignStatement : Statement
    {
    
            //Fields
	    private String aTo;
	    private String aFrom;
	
	    //Constructor for progObject/progObject - Overrides parent class
	    public AssignStatement(	progObject AssignTo, progObject AssignFrom, String StatementName):base(StatementName) 
        {
		    //super(StatementName);
		
		    aFrom = AssignFrom.getJCode();
		    aTo = AssignTo.getJCode();
	    }
	    
        //Constructor for Statement/Statement - Overrides parent class
	    public AssignStatement(	Statement AssignTo, Statement AssignFrom, String StatementName):base(StatementName)
        {
		    aFrom = AssignFrom.getJCode();
		    aTo = AssignTo.getJCode();
	    }
		
	    //Constructor for Statement/progObject - Overrides parent class
	    public AssignStatement(	Statement AssignTo, progObject AssignFrom, String StatementName): base(StatementName)
        
        {
		    aFrom = AssignFrom.getJCode();
		    aTo = AssignTo.getJCode();
	    }
	
	    //Constructor for progObject/statement - Overrides parent class
	    public AssignStatement(progObject AssignTo, Statement AssignFrom, String StatementName): base (StatementName)
        {
		    aFrom = AssignFrom.getJCode();
		    aTo = AssignTo.getJCode();
	    }

	    //Constructor for progObject/int - Overrides parent class
	    public AssignStatement(	progObject AssignTo, int AssignFrom, String StatementName):base (StatementName)
        {
            //aFrom = String.valueOf(AssignFrom);
            aFrom = AssignFrom.ToString();
		    aTo = AssignTo.getJCode();
	    }
		
		
	    public String getJCode(){
		    String Code;
		    Code = aTo + " = " + aFrom+";";
		    return Code;
		    }
    }
}
