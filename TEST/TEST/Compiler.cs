using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace TEST
{
    class IDECompiler
    {
        CSharpCodeProvider CompilerService;

        public IDECompiler()
        {
            CompilerService = new CSharpCodeProvider();

        }
        public bool CompileExecutable(StudentProgram oProgram)
        {
            
            CodeDomProvider provider = null;
            bool compileOk = false;

            
            provider = CodeDomProvider.CreateProvider("CSharp");
            

            if (provider != null)
            {

                // Format the executable file name. 
                // Build the output assembly path using the current directory 
                // and <source>_cs.exe or <source>_vb.exe.

                String exeName = oProgram.FilePath + ".exe";

                CompilerParameters cp = new CompilerParameters();

                // Generate an executable instead of  
                // a class library.
                cp.GenerateExecutable = true;

                // Specify the assembly file name to generate.
                cp.OutputAssembly = exeName;

                // Save the assembly as a physical file.
                cp.GenerateInMemory = false;

                // Set whether to treat all warnings as errors.
                cp.TreatWarningsAsErrors = false;

                // Invoke compilation of the source file.
                CompilerResults cr = provider.CompileAssemblyFromSource(cp,
                    oProgram.getCCode());

                if (cr.Errors.Count > 0)
                {
                    // Display compilation errors.
                    Console.WriteLine("Errors building {0} into {1}",
                        oProgram.FilePath, cr.PathToAssembly);
                    foreach (CompilerError ce in cr.Errors)
                    {
                        Console.WriteLine("  {0}", ce.ToString());
                        Console.WriteLine();
                    }
                }
                else
                {
                    // Display a successful compilation message.
                    Console.WriteLine("Source {0} built into {1} successfully.",
                        oProgram.FilePath, cr.PathToAssembly);
                }

                // Return the results of the compilation. 
                if (cr.Errors.Count > 0)
                {
                    compileOk = false;
                }
                else
                {
                    compileOk = true;
                }
            }
            return compileOk;
        }
    }
}
