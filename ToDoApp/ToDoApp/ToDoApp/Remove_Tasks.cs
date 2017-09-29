using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Remove_Tasks
    {
        private static string path = @"../../Todolist.txt";

        public  void RemoveTask(string[] args)
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
    }
}
