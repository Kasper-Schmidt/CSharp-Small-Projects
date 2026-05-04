using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeNCode
{
    internal class ToDoList
    {
        public static void Run()
        {
            List<TaskItem> tasks = new List<TaskItem>();
            int nextId = 1;

            while (true)
            {
                ShowMenu();

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    nextId = AddTask(tasks, nextId);
                }
                
                else if (choice == "2")
                {
                    ViewTasks(tasks);
                }
                
                else if (choice == "3")
                {
                    DeleteTask(tasks);
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You choice was not found.");
                }
            }

       

        }

        private static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Delete tasks");
            Console.WriteLine("4. Exit");
        }

        private static int AddTask(List<TaskItem> tasks, int nextId)
        {
            Console.Write("Enter task: ");
            string text = Console.ReadLine();

            TaskItem task = new TaskItem
            {
                Id = nextId,
                Text = text
            };

            tasks.Add(task);
            
            Console.WriteLine("Task added.");

            return nextId + 1;
        }

        private static void ViewTasks(List<TaskItem> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to display");
                return;
            }

            foreach (TaskItem task in tasks)
            {
                Console.WriteLine($"{task.Id}: {task.Text}");
            }
        }

        private static void DeleteTask(List<TaskItem> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to delete");
                return;
            }

            Console.WriteLine("Tasks:");
            foreach (TaskItem task in tasks)
            {
                Console.WriteLine($"{task.Id}: {task.Text}");
            }

            Console.WriteLine("Enter task id to delete");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int id))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            TaskItem taskToDelete = tasks.FirstOrDefault(task => task.Id == id);

            if (taskToDelete != null)
            {
                tasks.Remove(taskToDelete);
                Console.WriteLine("Task deleted");
            }
            else
            {
                Console.WriteLine("Task not found");
            }
        }


    }
    internal class TaskItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
