
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;



public class TaskManager
{
    private List<ToDos> tasks = new List<ToDos>();
    private readonly string filePath = "tasks.json";
    private int nextId = 1;

    public TaskManager()
    {
        LoadTask();
    }

    private void LoadTask()
    {
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            tasks = JsonConvert.DeserializeObject<List<ToDos>>(json) ?? new List<ToDos>();

            if (tasks.Any())
            {
                nextId = tasks.Max(t => t.Id) + 1;
            }
        }
    }

    public void AddTask(string name, string description)
    {
        var todos = new ToDos
        {
            Id = nextId++,
            description = description,
            name = name,
            createdAt = DateTime.Now
        };


    }


}
