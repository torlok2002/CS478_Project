using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
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
            Code = "There should be real code here...this needs replaced";
            return Code;
        }
    }
}
