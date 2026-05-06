using task_tracker_cli;

public class Program
{
    private static void Main(string[] args)
    {
        if (args.Length < 2) return;

        TaskList taskList = new();
        string command = args[0];
        
        switch (command)
        {
            case "add":
                string details = args[1];
                taskList.AddTask(details);
                Console.WriteLine($"The task \"{details}\" was added!");
                break;
            default:
                Console.WriteLine("Command not found!");
                break;
        }
    }
}
