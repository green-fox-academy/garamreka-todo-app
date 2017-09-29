using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoApp
{
    class Add_Tasks
    {
        public void AddNewTask(string[] args)
        {
            if (args.Length == 2)
            {
                using (StreamWriter writer = File.AppendText(List_Tasks.Path))
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
