using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace TEST
{
    class IDECompiler
    {
        CSharpCodeProvider CompilerService;

        public IDECompiler()
        {
            CompilerService = new CSharpCodeProvider();

        }
        public void RunProgram(StudentProgram oProgram)
        {
            //CompilerService.CompileAssemblyFromSource(,oProgram.getCSCode());

        }
    }
}
