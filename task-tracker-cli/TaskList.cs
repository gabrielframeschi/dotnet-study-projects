using System.Text.Json;

namespace task_tracker_cli;

internal class TaskList
{
    const string FILE_NAME = "tasks.json";
    const string FILE_DIR = @"C:\Tasks";
    const string FILE_PATH = $"{FILE_DIR}\\{FILE_NAME}";
    public List<Task> Tasks { get; } = [];

    public TaskList()
    {
        if (!File.Exists(FILE_PATH))
        {
            Directory.CreateDirectory(FILE_DIR);
            File.Create(FILE_PATH);
        }

        string fileContent = File.ReadAllText(FILE_PATH);
        if (fileContent.Length == 0)
        {
            Tasks = [];
            return;
        }

        var tasks = JsonSerializer.Deserialize<List<Task>>(fileContent);
        Tasks = tasks ?? [];
    }

    public void AddTask(string description)
    {
        Task newTask = new(description);
        Tasks.Add(newTask);

        string json = JsonSerializer.Serialize(Tasks);
        File.WriteAllText(FILE_PATH, json);

        newTask.ShowTaskInfo();
    }
}
