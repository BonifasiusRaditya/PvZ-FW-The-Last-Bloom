using System;
using System.Collections.Generic;

public class Game
{
    private List<Map> Maps;
    private int currentMapIndex;

    public Game()
    {
        Maps = new List<Map>();
        currentMapIndex = 0;
        InitializeMaps();
    }

    private void InitializeMaps()
    {
        for (int i = 1; i <= 5; i++)
        {
            bool isBossMap = i == 5;
            Map map = new Map($"Map {i}", isBossMap);

            int stagesInMap = isBossMap ? 1 : 3; // Map terakhir hanya 1 stage (Boss)
            for (int j = 1; j <= stagesInMap; j++)
            {
                string stageName = isBossMap ? "Boss Fight" : $"Stage {j}";
                map.AddStage(new Stage(stageName));
            }

            Maps.Add(map);
        }
    }

    public void Play()
    {
        while (currentMapIndex < Maps.Count)
        {
            Map currentMap = Maps[currentMapIndex];
            Console.WriteLine($"Entering {currentMap.Name}...");

            currentMap.CompleteStages();

            if (currentMap.IsCompleted)
            {
                Console.WriteLine($"{currentMap.Name} completed!");
                currentMapIndex++;
            }
        }

        Console.WriteLine("Congratulations! You've completed all maps!");
    }
}
