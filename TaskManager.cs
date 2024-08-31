
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;



public class TaskManager
{
    private List<ToDos> tasks = new List<ToDos>();
    int nextId;
    private readonly string filePath = "D:\\Personal Projects\\Task-Tracker\\Task-Tracker\\Datatasks.json";

    public TaskManager()
    {
        LoadTask();
    }

    private void LoadTask()
    {

        if (File.Exists(filePath))
        {
            try
            {
                var json = File.ReadAllText(filePath);
                tasks = JsonConvert.DeserializeObject<List<ToDos>>(json) ?? new List<ToDos>();

                if (tasks.Any())
                {
                    nextId = tasks.Max(t => t.Id) + 1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading tasks: " + e.Message);
            }


        }
    }



    public void AddTask(string name, string description)
    {
        int newId = nextId;
        var todos = new ToDos
        {
            Id = newId,
            description = description,
            name = name,
            createdAt = DateTime.Now
        };

        tasks.Add(todos);
        Console.WriteLine($"Task has been added sucessfully (Id: {newId}");
        SaveTask();


    }


    // update method
    public void Updatetask(int id, string name, string description)
    {

        // linq to check if data exists in the json file
        var record = tasks.FirstOrDefault(task => task.Id == id);
        if (record != null)
        {
            var loadData = tasks.FirstOrDefault(data => data.Id == id);

            loadData.name = name;
            loadData.description = description;
            loadData.updatedAt = DateTime.Now;
            File.WriteAllText(filePath, JsonConvert.SerializeObject(record, Formatting.Indented));
            Console.WriteLine("The Task has been updated");
        }
        else
        {
            Console.WriteLine($"The id: {id} is not found in the saved file");
        }

    }

    public void DeleteTask(int id)
    {
        var task = tasks.FirstOrDefault(task => task.Id == id);
        if (task != null)
        {
            tasks.Remove(task);
            SaveTask();
            Console.WriteLine($"Task with id {id} has been deleted.");
        }
    }


    private void SaveTask()
    {
        var json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }


}
