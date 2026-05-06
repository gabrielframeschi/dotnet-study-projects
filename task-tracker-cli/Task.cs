using System.Text.Json.Serialization;

namespace task_tracker_cli;

internal class Task(string description)
{
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; } = DateTime.Now;
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get;  } = DateTime.Now;

    [JsonPropertyName("id")]
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    [JsonPropertyName("description")]
    public string Description { get; set; } = description;
    [JsonPropertyName("status")]
    public TaskStatus Status { get; set; } = TaskStatus.ToDo;

    public void ShowTaskInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Descrição: {Description}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"Creation: {CreatedAt}");
        Console.WriteLine($"Update: {UpdatedAt}");
        Console.WriteLine();
    }
}
