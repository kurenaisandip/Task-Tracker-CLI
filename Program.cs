
public class Program
{

    public static void Main(string[] args)
    {

        string? name;
        string? description;
        string? status;
        DateTime? createdAt;
        DateTime? updatedAt;

        TaskManager manager = new TaskManager();

        if (args.Length == 0)
        {
            Console.WriteLine("No command provided. Use 'task-cli help' for usage information.");
            return;
        }

        string command = args[0].ToLower();

        switch (command)
        {
            case "add":
                if (args.Length < 2)
                {
                    Console.WriteLine("Usage: task-cli add \"Task name\"");
                }
                else
                {
                    //           Console.WriteLine("Input the name of the task");
                    //         Console.WriteLine("Input the description of the task");
                    manager.AddTask(args[1], args[2]);
                    Console.WriteLine(args[1] + args[2]);

                    //manager.AddTask(args[1]);
                }
                break;

            default:
                Console.WriteLine("type task-cli lists for all the command");
                break;
        }

        // Console.WriteLine("Input the Name of the Task");
        // name = Console.ReadLine();
        //Console.WriteLine("Input the Description about the task");
        //description = Console.ReadLine();
        //Console.WriteLine("Input the Status of the Task");
        //status = Console.ReadLine();
        //createdAt = DateTime.Now;
        //updatedAt = DateTime.Now;
        //Console.WriteLine("Created Date:" + createdAt + "Updated Date:" + updatedAt);
    }
}
