using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.CompilerServices;


namespace TEST
{
    class IDECompiler
    {
        CSharpCodeProvider CompilerService;
        CompilerResults cr;
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
                System.Collections.Specialized.StringCollection stringCol = new System.Collections.Specialized.StringCollection();

                String exeName = oProgram.FilePath.Substring(0, oProgram.FilePath.Length - 5) + ".exe";
                String code = @" 
                using System;
                using System.Collections.Generic;
                using System.Text;
                using System.Threading.Tasks;
                using System.Messaging;
                    
                namespace testCompile 
                {
                    class Program
                    {
                        static MessageQueue IDEQueue;
                        static public void ExecuteStatements()
                        {
                            
                            IDEQueue = GetQ(@"".\Private$\IDEQueue"");
                            IDEQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                            IDEQueue.Purge();
                            "
                            + oProgram.getCCode() + @"
                            IDEQueue.Send("""",""EndProgram"");
                            IDEQueue.Close();
                        }         
                        private static MessageQueue GetQ(string queueName)
                        {
                            MessageQueue msgQ;

                            if (!MessageQueue.Exists(queueName))
                            {
                                try
                                {
                                    msgQ = MessageQueue.Create(queueName);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception(""Error creating queue"", ex);
                                }
                            }
                            else
                            {
                                try
                                {
                                    msgQ = new MessageQueue(queueName);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception(""Error getting queue"", ex);
                                }
                            }
                            return msgQ;
                        }      
                        private static Message GetMessage() 
                        {
                            bool recievedMsg = false;
                            
                            while (true)
                            {
                                try 
                                {
                                    if (IDEQueue.Peek(new TimeSpan(5)).Label == ""Input"" && recievedMsg == false) { return IDEQueue.Receive(new TimeSpan(5)); }
                                }
                                catch { }
                            }
                            return null;
                        }
                    }
                }";
                System.IO.File.WriteAllText(oProgram.FilePath.Substring(0, oProgram.FilePath.Length - 5) + ".cs", code);
                CompilerParameters cp = new CompilerParameters();

                cp.ReferencedAssemblies.Add("System.dll");
                cp.ReferencedAssemblies.Add("System.Messaging.dll");
                //cp.OutputAssembly = oProgram.FilePath.Substring(0, oProgram.FilePath.Length - 5) + ".exe";
                cp.GenerateExecutable = false;
                cp.GenerateInMemory = true;
                cp.TreatWarningsAsErrors = false;

                // Invoke compilation of the source file.
                cr = provider.CompileAssemblyFromSource(cp, new string[] { code });

                //oProgram.getCCode());

                if (cr.Errors.Count > 0)
                {
                   
                    foreach (CompilerError ce in cr.Errors)
                    {
                        MessageBox.Show("  {0}", ce.ToString());
                    }
                }
                else
                {
                    // Display a successful compilation message.
                    //statusStrip.Text = "Source " + oProgram.FilePath + " built into " + cr.PathToAssembly + " successfully.\n";

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
        public void RunAssembly()
        {
            Module module = cr.CompiledAssembly.GetModules()[0];
            Type mt = null;
            MethodInfo methInfo = null;

            if (module != null)
            {
                mt = module.GetType("testCompile.Program");
            }

            if (mt != null)
            {
                methInfo = mt.GetMethod("ExecuteStatements");
            }

            if (methInfo != null)
            {
                methInfo.Invoke(null, null);
            }
        }
    }
}
