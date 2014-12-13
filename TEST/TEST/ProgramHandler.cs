using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TEST
{
    class ProgramHandler
    {
        MessageQueue IDEQueue;
        StudentProgram IDEProgram;
        TextBox txtOutputBox;

        public ProgramHandler(StudentProgram oProgram, TextBox txtOutputBox)
        {
            this.IDEProgram = oProgram;
            this.txtOutputBox = txtOutputBox;
        }
        public void Run()
        {

            IDECompiler comp = new IDECompiler();
            comp.CompileExecutable(IDEProgram);
            Thread myThread = new System.Threading.Thread(delegate()
            {
                comp.RunAssembly();
            });
            myThread.Start();
            IDEQueue = GetQ(@".\Private$\IDEQueue");
            IDEQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            
            while (! IDEQueue.Peek().Label.Contains("EndProgram"))
            {
                if (IDEQueue.Peek().Label.Contains("InputRequest"))
                {

                    string type = IDEQueue.Receive().Label;
                    
                    IDEQueue.Send(Microsoft.VisualBasic.Interaction.InputBox("Input " + type.Substring(12), "Input"));
                }
                else if (IDEQueue.Peek().Label.Contains("Output"))
                {
                    txtOutputBox.Text += "Output: " + GetMessage().Body.ToString() + Environment.NewLine;
                }
            }

        }
        private MessageQueue GetQ(string queueName)
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
                    throw new Exception("Error creating queue", ex);
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
                    throw new Exception("Error getting queue", ex);
                }
            }
            return msgQ;
        }
        private System.Messaging.Message GetMessage()
        {
            bool recievedMsg = false;

            while (true)
            {
                try
                {
                    if (IDEQueue.Peek(new TimeSpan(5)).Label != "Input" && recievedMsg == false) { return IDEQueue.Receive(new TimeSpan(5)); }
                }
                catch { }
            }
        }
    }
}
