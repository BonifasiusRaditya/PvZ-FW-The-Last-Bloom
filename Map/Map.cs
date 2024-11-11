using System;
using System.Collections.Generic;

public class Map
{
    public string Name { get; }
    public List<Stage> Stages { get; }
    public bool IsBossMap { get; }
    public bool IsCompleted => Stages.TrueForAll(stage => stage.IsCompleted);

    public Map(string name, bool isBossMap = false)
    {
        Name = name;
        IsBossMap = isBossMap;
        Stages = new List<Stage>();
    }

    public void AddStage(Stage stage)
    {
        Stages.Add(stage);
    }

    public void CompleteStages()
    {
        foreach (var stage in Stages)
        {
            if (!stage.IsCompleted)
            {
                stage.CompleteStage();
            }
        }
    }
}
