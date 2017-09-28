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
            if (args.Length == 0)
            {
                Console.WriteLine("\nCommand Line Todo application"
                + "\n=============================\n"
                + "\nCommand line arguments:"
                + "\n-l   Lists all the tasks"
                + "\n-a   Adds a new task"
                + "\n-r   Removes a task"
                + "\n-c   Completes a task");
            }
            if (args.Contains("-l"))
            {
                //string path = @"./todolist.txt";

                try
                {
                    string[] content = File.ReadAllLines("Todolist.txt");

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
