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
        private static string path = @"../../Todolist.txt";
        private static string[] contentOfTodoList = File.ReadAllLines(path);

        public void CheckTask(string[] args)
        {
            if (args.Length == 2)
            {
                try
                {
                    int indexOfLine = int.Parse(args[1]);

                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        for (int i = 0; i < contentOfTodoList.Length; i++)
                        {
                            if (i == indexOfLine - 1)
                            {
                                writer.WriteLine(contentOfTodoList[i].Replace("todo", "done"));
                            }
                            else
                            {
                                writer.WriteLine(contentOfTodoList[i]);
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
