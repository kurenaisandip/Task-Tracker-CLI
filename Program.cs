
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
            Console.WriteLine("No command provided. Use 'dotnet run --help' for usage information.");
            return;
        }

        string command = args[0].ToLower();

        switch (command)
        {
            case "add":
                if (args.Length < 2)
                {
                    Console.WriteLine("Usage: dotnet run --add \"Task name\"");
                }
                else
                {
                    //           Console.WriteLine("Input the name of the task");
                    //         Console.WriteLine("Input the description of the task");
                    manager.AddTask(args[1], args[2]);
                    Console.WriteLine($"Task added: Name = {args[1]}, Description = {args[2]}");
                    //manager.AddTask(args[1]);
                }
                break;


            case "update":

                if (args.Length < 3)
                {
                    Console.WriteLine("Usage: dotnet run --update id,Task name,Task Description ");
                }
                else
                {
                    if (int.TryParse(args[1], out int id))
                    {
                        manager.Updatetask(id, args[2], args[3]);

                    }
                    else
                    {
                        Console.WriteLine("Invalid ID provided.");
                    }
                }
                break;

            case "delete":
                if (args.Length < 2)
                {
                    Console.WriteLine("Usage: dotnet run --delete id");
                }
                else
                {
                    if (int.TryParse(args[1], out int id))
                    {
                        manager.DeleteTask(id);
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID provided.");
                    }
                }
                break;

            case "mark-in-progress":
                if (args.Length < 2) {
                    Console.WriteLine("Usage: dotnet run --mark-in-progress <ID>");
                }
                else
                {
                    if (int.TryParse(args[1], out int inProgressId))
                    {
                        manager.markInProgress(inProgressId);
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID provided.");
                    }
                }
                break;

            case "mark-done":
                if (args.Length < 2)
                {
                    Console.WriteLine("Usage: dotnet run --mark-done <ID>");
                }
                else
                {
                    if (int.TryParse(args[1], out int inProgressId))
                    {
                        manager.markDone(inProgressId);
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID provided.");
                    }
                }
                break;

            case "list":
                if (args.Length == 2)
                {
                    status = args[1].ToLower();
                    if (status == "todo" || status == "in-progress" || status == "done")
                    {
                        if (status == "todo")
                        {
                            manager.ListtaskInToDo(status);
                        }
                        else if (status == "in-progress")
                        {
                            manager.ListtaskInProgress(status);
                        }
                        else if (status == "done")
                        {
                            manager.ListtaskDone(status);
                        }
                        else
                        {
                             manager.ListTasks();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid status. Use 'todo', 'in-progress', or 'done'.");
                    }
                }
                else if (args.Length == 1)
                {
                    manager.ListTasks(); // Lists all tasks if no status is provided
                }
                else
                {
                    Console.WriteLine("Usage: task-cli list [status]");
                }
                break;

            case "help":
                ShowHelp();
                break;

            default:
                Console.WriteLine("type dotnet run -- help for all the command");
                break;
        }

        static void ShowHelp()
        {
            Console.WriteLine("Task CLI - A simple task manager");
            Console.WriteLine();
            Console.WriteLine("Usage:");
            Console.WriteLine("  dotnet run -- add \"Task description\"                 - Add a new task");
            Console.WriteLine("  dotnet run -- update <ID> \"Updated task description\" - Update an existing task");
            Console.WriteLine("  dotnet run -- delete <ID>                             - Delete a task");
            Console.WriteLine("  dotnet run -- mark-in-progress <ID>                   - Mark a task as in-progress");
            Console.WriteLine("  dotnet run -- mark-done <ID>                          - Mark a task as done");
            Console.WriteLine("  dotnet run -- list [status]                       - List tasks, optionally by status");
            Console.WriteLine("  dotnet run -- help                                    - Show this help message");
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
