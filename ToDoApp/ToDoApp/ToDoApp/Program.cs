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
                    string[] content = File.ReadAllLines("Todolist.txt");

                    if (content.Length == 0)
                    {
                        Console.WriteLine("No todos for today! :)");
                    }

                    for (int i = 0; i < content.Length; i++)
                    {
                        Console.WriteLine((i + 1) + " - " + content[i]);
                    }
                }
                catch
                {
                    Console.WriteLine("Unable to read file.");
                }
            }
            Console.ReadLine();
        }
    }
}
