using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ToDoApp
{
    public class List_Tasks
    {
        private static string path = @"../../Todolist.txt";
        private static string[] contentOfTodoList = File.ReadAllLines(path);

        public void ListTasks()
        {
            try
            {
                if (contentOfTodoList.Length == 0)
                {
                    Console.WriteLine("No todos for today! :)");
                }
                for (int i = 0; i < contentOfTodoList.Length; i++)
                {
                    string[] oneLineOfTodoList = contentOfTodoList[i].Split(';');
                    if (oneLineOfTodoList[1] == "done")
                    {
                        Console.WriteLine((i + 1) + " - [x] " + oneLineOfTodoList[0]);
                    }
                    else
                    {
                        Console.WriteLine((i + 1) + " - [ ] " + oneLineOfTodoList[0]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Unable to read file.");
            }
        }
    }
}
