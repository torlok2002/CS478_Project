using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    class Test_Statements
    {
        public static void Main(String[] args) 
        {
		
		    //instantiate progObject objects (AKA Variables)
		    progObject objectA = new progObject("a");
		    objectA.setValue(2);
		    progObject objectB = new progObject("b");
		    objectB.setValue(3);
		
		    //Instantiate statement objects.
            //Statement statement0 = new Statement("name");
		    AssignStatement statement1 = new AssignStatement(objectA, objectB, "testAssignStatement");
		    ArithStatement statement2 = new ArithStatement(objectA, objectB, "+", "testarithStatement");
		    OutputStatement statement5 = new OutputStatement(objectB, "testOutputAssignment");
		    OutputStatement statement6 = new OutputStatement(statement2,"testOutputAssignment2");
		
		    //Instantiate linked list and add statement objects to it. 
		    LinkedList<Statement> list1 = new LinkedList<Statement>();
        
            //list1.AddFirst(statement0);
            list1.AddLast(statement1);
		    list1.AddLast(statement5);
		    list1.AddFirst(objectA.getStatement());
		    list1.AddFirst(objectB.getStatement());
		    list1.AddLast(statement6);
		

   		    //Iterate through list and print out code form each statement.
		    foreach(var stat  in list1)
            {
                Console.WriteLine(stat.getJCode());
                //stat.getJCode();
            }


		}					
	}
}
