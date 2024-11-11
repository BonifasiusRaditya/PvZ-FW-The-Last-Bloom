using System;
using System.Collections.Generic;

class Program{
    enum Type{
        Water,
        Fire,
        Lightning,
        Dark,
        Light,
        Normal
    }

    // Method to get the effectiveness multiplier between attack and defense types
    static double GetEffectiveness(Type attacker, Type defender)
    {
        // Matchup table based on the provided data
        double[,] matchupTable = {
            // Water, Fire, Lightning, Dark, Light, Normal
            { 1.0, 2.0, 0.5, 1.0, 1.0, 1.0 }, // Water
            { 0.5, 1.0, 2.0, 1.0, 1.0, 1.0 }, // Fire
            { 2.0, 0.5, 1.0, 1.0, 1.0, 1.0 }, // Lightning
            { 1.0, 1.0, 1.0, 1.0, 2.0, 1.0 }, // Dark
            { 1.0, 1.0, 1.0, 2.0, 1.0, 1.0 }, // Light
            { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 }  // Normal
        };

        // Get the effectiveness multiplier from the table
        return matchupTable[(int)attacker, (int)defender];
    }

    // Method to print the effectiveness of a given attack type against all defense types
    static void PrintEffectiveness(Type attacker)
    {
        Console.WriteLine($"Effectiveness of {attacker} attack:");
        foreach (Type defender in Enum.GetValues(typeof(Type)))
        {
            double effectiveness = GetEffectiveness(attacker, defender);
            Console.WriteLine($"Against {defender}: {effectiveness}x");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Example: Check the effectiveness of different types
        PrintEffectiveness(Type.Water);
        PrintEffectiveness(Type.Fire);
        PrintEffectiveness(Type.Lightning);
        PrintEffectiveness(Type.Dark);
        PrintEffectiveness(Type.Light);
        PrintEffectiveness(Type.Normal);

        // Example: Calculate effectiveness for a specific matchup
        Type attacker = Type.Fire;
        Type defender = Type.Water;
        double multiplier = GetEffectiveness(attacker, defender);
        Console.WriteLine($"{attacker} attacking {defender} results in a multiplier of {multiplier}x damage.");
    }
}
