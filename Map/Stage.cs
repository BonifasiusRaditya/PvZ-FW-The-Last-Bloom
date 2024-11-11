using System;

public class Stage
{
    public string Name { get; }
    public bool IsCompleted { get; private set; }

    public Stage(string name)
    {
        Name = name;
        IsCompleted = false;
    }

    public void CompleteStage()
    {
        IsCompleted = true;
        Console.WriteLine($"{Name} completed!");
    }
}
