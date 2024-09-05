class Program
{
    static void Main()
    {
        var taskManager = new TaskManager();

        Console.WriteLine("Task Manager\n Choose an option");
        while (true)
        {
            Console.WriteLine("\n1. Add Task\n2. View Tasks\n3. Complete Task\n4. Delete Task\n5. Exit");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter task description: ");
                    var description = Console.ReadLine();
            
                    taskManager.AddTask(description);
                    break;

                case "2":
                    taskManager.ViewTasks();
                    break;

                case "3":
                    Console.Write("Enter task ID to complete: ");
                    int completeId = int.Parse(Console.ReadLine());
                    taskManager.CompleteTask(completeId);
                    break;

                case "4":
                    Console.Write("Enter task ID to delete: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    taskManager.DeleteTask(deleteId);
                    break;

                case "5":
                    return;
            }
        }
    }
}
