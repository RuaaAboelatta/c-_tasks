using System.ComponentModel.Design;

namespace task._1.todolist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Note:this program keeps track of 10 daily tasks put by the user");
            string[] tasks = new string[10];
            writingtasks();
            Console.WriteLine("To edit your list press 1 \t\t To create new list press 2 \t\t To exit press enter ");
            int press =int.Parse(Console.ReadLine());
            switch (press)
            {
                case 1:
                    Console.WriteLine("Enter the task number");
                    int n = int.Parse(Console.ReadLine());
                    if (n >= 1 && n <= 10)
                    {
                        Console.WriteLine("Write the new task");
                        string newtask = Console.ReadLine();
                        tasks[n - 1] = newtask;
                        Console.WriteLine("Task edited succsessfully");
                    }
                    else
                        Console.WriteLine("Invalid task number");
                    break;
                case 2:
                    writingtasks();
                    Console.WriteLine("New list created successfully");
                    break;
                default:
                    break;
           
            }
            
        }
        static void writingtasks()
        {
            Console.WriteLine("Please enter your tasks:");
            string[] tasks = new string[10];
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine("task no {0}", i + 1);
                tasks[i] = Console.ReadLine();
            }
        }
    }
}
