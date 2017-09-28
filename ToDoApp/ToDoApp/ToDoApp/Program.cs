using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");

            if (args.Length == 0)
            {
                Console.WriteLine("Command Line Todo application"
                + "\n=============================\n"
                + "\nCommand line arguments:"
                + "\n-l   Lists all the tasks"
                + "\n-a   Adds a new task"
                + "\n-r   Removes a task"
                + "\n-c   Completes a task");
            }
            else if (args.Contains("-l"))
            {
                try
                {
                    string[] contentOfTodoList = File.ReadAllLines(@"../../Todolist.txt");

                    if (contentOfTodoList.Length == 0)
                    {
                        Console.WriteLine("No todos for today! :)");
                    }

                    for (int i = 0; i < contentOfTodoList.Length; i++)
                    {
                        Console.WriteLine((i + 1) + " - " + contentOfTodoList[i]);
                    }
                }
                catch
                {
                    Console.WriteLine("Unable to read file.");
                }
            }
            else if (args.Contains("-a"))
            {
                if (args.Length == 2)
                {
                    try
                    {
                        using (StreamWriter writer = File.AppendText(@"../../Todolist.txt"))
                        {
                            writer.WriteLine(args[1]);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Unable to add task.");
                    }
                }
                else
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
                
            }
            //Console.ReadLine();
        }
    }
}
