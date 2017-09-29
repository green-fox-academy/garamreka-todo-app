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
                AddNewTask(args);
            }
            else if (args.Contains("-r"))
            {
                RemoveTask(args);
            }
            else if (args.Contains("-c"))
            {
                CheckTask(args);
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
        
        public static void AddNewTask(string[] args)
        {
            if (args.Length == 2)
            {
                using (StreamWriter writer = File.AppendText(@"../../Todolist.txt"))
                {
                    writer.WriteLine(args[1] + ";todo");
                }
            }
            else
            {
                Console.WriteLine("Unable to add: no task provided");
            }
        }
        public static void RemoveTask(string[] args)
        {
            if (args.Length == 2)
            {
                try
                {

                }
                catch
                {
                    Console.WriteLine("Unable to remove");
                }
            }
            else
            {
                Console.WriteLine("Unable to remove: no index provided");
            }
        }
        public static void CheckTask(string[] args)
        {
            if (args.Length == 2)
            {
                try
                {
                    string[] contentOfTodoList = File.ReadAllLines(@"../../Todolist.txt");
                    int indexOfLine = int.Parse(args[1]);

                    using (StreamWriter writer = new StreamWriter(@"../../Todolist.txt"))
                    {
                        

                        for (int i = 0; i < contentOfTodoList.Length; i++)
                        {
                            if (i == indexOfLine -1)
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
