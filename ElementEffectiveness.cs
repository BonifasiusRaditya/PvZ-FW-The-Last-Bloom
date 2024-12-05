using ElementType;

public static class ElementEffectiveness {
    private static readonly double[,] EffectivenessTable = {
        { 1.0, 2.0, 0.5, 1.0, 1.0, 1.0 }, // Water
        { 0.5, 1.0, 2.0, 1.0, 1.0, 1.0 }, // Fire
        { 2.0, 0.5, 1.0, 1.0, 1.0, 1.0 }, // Lightning
        { 1.0, 1.0, 1.0, 1.0, 2.0, 1.0 }, // Dark
        { 1.0, 1.0, 1.0, 2.0, 1.0, 1.0 }, // Light
        { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 }  // Normal
    };

    public static double GetMultiplier(Element attacker, Element defender) {
        return EffectivenessTable[(int)attacker, (int)defender];
    }

    public static string GetEffectivenessDescription(Element attacker, Element defender) {
        double multiplier = GetMultiplier(attacker, defender);
        if (multiplier > 1.0) return "Super Effective!";
        if (multiplier < 1.0) return "Not Very Effective...";
        return "Normal Effectiveness.";
    }
}