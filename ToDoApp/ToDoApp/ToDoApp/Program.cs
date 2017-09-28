using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Command Line Todo application"
                + "\n=============================\n"
                + "\nCommand line arguments:"
                + "\n-l   Lists all the tasks"
                + "\n-a   Adds a new task"
                + "\n-r   Removes an task"
                + "\n-c   Completes an task");

            Console.ReadLine();
        }
    }
}
