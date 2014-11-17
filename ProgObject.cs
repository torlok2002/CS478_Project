using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class progObject
    {
        
	//Fields
	private String name;
	private int value;
	private bool valueinit;

	//constructor
	public progObject(String name) {
		//super();
		this.value = 0;
		this.name = name;
		valueinit = false;
		
	}

	public String getJCode(){
		return name;
		//return String.valueOf(value);
	}
	
	public AssignStatement getStatement(){
		AssignStatement a = new AssignStatement(this, this.getValue(), this.name);
		return a;
	}
	
	public void setValue(int value){
		this.value = value;
		valueinit = true;
	}
	
	public int getValue(){
		return value;
	}
    }
}
