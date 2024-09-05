public class TaskManager
{
    private TaskContext _context;

    public TaskManager()
    {
        //creating database
        _context = new TaskContext();
        _context.Database.EnsureCreated(); 
    }

    //task adding
    public void AddTask(string description)
    {
        var task = new Task { Description = description };
        _context.Tasks.Add(task);
        _context.SaveChanges();
    }

    public void ViewTasks()
    {
        var tasks = _context.Tasks.ToList();
        foreach (var task in tasks)
        {
            Console.WriteLine($"{task.Id}. {task.Description} - Completed: {task.IsCompleted}");
        }
    }

    public void CompleteTask(int id)
    {
        var task = _context.Tasks.Find(id);
        if (task != null)
        {
            task.IsCompleted = true;
            _context.SaveChanges();
        }
    }

    public void DeleteTask(int id)
    {
        var task = _context.Tasks.Find(id);
        if (task != null)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }
}
