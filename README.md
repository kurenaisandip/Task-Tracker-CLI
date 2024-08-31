Here is a comprehensive README file for your task management program:

---

# Task CLI - A Simple Task Manager

Task CLI is a command-line application that allows you to manage tasks effectively from your terminal. You can add, update, delete, mark tasks as in-progress or done, and list tasks based on their status.

## Features

- **Add New Tasks**: Easily add new tasks with a description.
- **Update Existing Tasks**: Modify existing tasks by specifying their ID.
- **Delete Tasks**: Remove tasks by ID.
- **Change Task Status**: Mark tasks as "in-progress" or "done".
- **List Tasks**: View tasks by status or view all tasks.
- **Help Command**: Provides usage information for all available commands.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/kurenaisandip/Task-Tracker-CLI
   ```

2. Navigate to the project directory:
   ```bash
   cd Task-Tracker
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

## Usage

To use Task CLI, run commands from your terminal as shown below:

### Add a New Task
```bash
dotnet run -- add "Task Name" "Task Description"
```

### Update an Existing Task
```bash
dotnet run -- update <ID> "Updated Task Name" "Updated Task Description"
```

### Delete a Task
```bash
dotnet run -- delete <ID>
```

### Mark a Task as In-Progress
```bash
dotnet run -- mark-in-progress <ID>
```

### Mark a Task as Done
```bash
dotnet run -- mark-done <ID>
```

### List Tasks

- List all tasks:
  ```bash
  dotnet run -- list
  ```

- List tasks by status (`todo`, `in-progress`, `done`):
  ```bash
  dotnet run -- list <status>
  ```

### Show Help
```bash
dotnet run -- help
```

## Commands Summary

| Command                          | Description                                 |
|----------------------------------|---------------------------------------------|
| `dotnet run -- add "Task Name" "Task Description"`  | Add a new task                             |
| `dotnet run -- update <ID> "Updated Task Name" "Updated Task Description"` | Update an existing task                    |
| `dotnet run -- delete <ID>`      | Delete a task by its ID                     |
| `dotnet run -- mark-in-progress <ID>` | Mark a task as in-progress               |
| `dotnet run -- mark-done <ID>`   | Mark a task as done                         |
| `dotnet run -- list`             | List all tasks                             |
| `dotnet run -- list <status>`    | List tasks by status (todo, in-progress, done) |
| `dotnet run -- help`             | Show help message                          |

## Example

Adding a new task:

```bash
dotnet run -- add "Buy Groceries" "Milk, Bread, Eggs, Cheese"
```

Updating a task:

```bash
dotnet run -- update 1 "Buy Groceries" "Milk, Bread, Eggs, Cheese, Butter"
```

Listing all tasks:

```bash
dotnet run -- list
```

Marking a task as done:

```bash
dotnet run -- mark-done 1
```

## Notes

- Ensure your JSON data file (`Datatasks.json`) is formatted correctly as an array to prevent deserialization errors.
- Use the correct command syntax as shown in the commands summary table.

## Contributing

Contributions are welcome! Please fork this repository, make changes, and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- This project uses .NET for application development.
- Inspired by common task management needs in everyday workflows.

---

