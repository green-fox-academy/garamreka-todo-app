using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Check_Tasks
    {
        public void CheckTask(string[] args)
        {
            if (args.Length == 2)
            {
                try
                {
                    int indexOfLine = int.Parse(args[1]);

                    using (StreamWriter writer = new StreamWriter(List_Tasks.Path))
                    {
                        for (int i = 0; i < List_Tasks.ContentOfTodoList.Length; i++)
                        {
                            if (i == indexOfLine - 1)
                            {
                                writer.WriteLine(List_Tasks.ContentOfTodoList[i].Replace("todo", "done"));
                            }
                            else
                            {
                                writer.WriteLine(List_Tasks.ContentOfTodoList[i]);
                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Unable to check");
                }
            }
            else
            {
                Console.WriteLine("Unable to check: no index provided");
            }
        }
    }
}
