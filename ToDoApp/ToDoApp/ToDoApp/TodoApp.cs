using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoApp
{
    class TodoApp
    {
        static void Main(string[] args)
        {
            List_Tasks listTasks = new List_Tasks();
            Add_Tasks addTasks = new Add_Tasks();
            Remove_Tasks removeTasks = new Remove_Tasks();
            Check_Tasks checkTasks = new Check_Tasks();

            Console.WriteLine("\n");

            if (args.Length == 0)
            {
                UsageInfo();
            }
            else if (args.Contains("-l"))
            {
                listTasks.ListTasks();
            }
            else if (args.Contains("-a"))
            {
                addTasks.AddNewTask(args);
            }
            else if (args.Contains("-r"))
            {
                removeTasks.RemoveTask(args);
            }
            else if (args.Contains("-c"))
            {
                checkTasks.CheckTask(args);
            }
        }
        public static void UsageInfo()
        {
            Console.WriteLine("Command Line Todo application"
                + "\n=============================\n"
                + "\nCommand line arguments:"
                + "\n-l   Lists all the tasks"
                + "\n-a   Adds a new task"
                + "\n-r   Removes a task"
                + "\n-c   Completes a task");
        }
    }
}
