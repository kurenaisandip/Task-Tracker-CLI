
public class Program
{

    public static void Main(string[] args)
    {

        string? name;
        string? description;
        string? status;
        DateTime? createdAt;
        DateTime? updatedAt;

        Console.WriteLine("Input the Name of the Task");
        name = Console.ReadLine();
        Console.WriteLine("Input the Description about the task");
        description = Console.ReadLine();
        Console.WriteLine("Input the Status of the Task");
        status = Console.ReadLine();
        createdAt = DateTime.Now;
        updatedAt = DateTime.Now;
        Console.WriteLine("Created Date:" + createdAt + "Updated Date:" + updatedAt);
    }
}
