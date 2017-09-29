using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoApp
{
    class Add_Tasks
    {
        private static string path = @"../../Todolist.txt";

        public void AddNewTask(string[] args)
        {
            if (args.Length == 2)
            {
                using (StreamWriter writer = File.AppendText(path))
                {
                    writer.WriteLine(args[1] + ";todo");
                }
            }
            else
            {
                Console.WriteLine("Unable to add: no task provided");
            }
        }
    }
}
