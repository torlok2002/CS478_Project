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
                            
                               IDEQueue = GetQ(@".\Private$\IDEQueue");
                               IDEQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                               IDEQueue.Purge();
                               int X = 0;
X = 5;
IDEQueue.Send(X+"","Output");
if (X == 5) {X = (X+X);}
IDEQueue.Send(X+"","Output");

                               IDEQueue.Send("","EndProgram");
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
                            private static Message GetMessage() 
                            {
                                bool recievedMsg = false;
                            
                                while (true)
                                {
                                    try 
                                    {
                                        if (IDEQueue.Peek(new TimeSpan(5)).Label == "Input" && recievedMsg == false) { return IDEQueue.Receive(new TimeSpan(5)); }
                                    }
                                    catch { }
                                }
                                return null;
                            }
                        }
                    }