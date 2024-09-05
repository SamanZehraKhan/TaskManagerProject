public class Task
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

   
    public Task() { }

    
    public Task(string description)
    {
        Description = description;
     
        IsCompleted = false; // Default value
    }
}
